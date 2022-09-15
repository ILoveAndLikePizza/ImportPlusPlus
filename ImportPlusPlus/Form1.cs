using System.Net.Http;

namespace ImportPlusPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CanStart(object sender, EventArgs e)
        {
            StartButton.Enabled = (
                FromDirectoryInput.Text.Length > 0 && ToDirectoryInput.Text.Length > 0 &&
                FileNameFormat.Text.Length > 0 && FileNameFormat.Text.Contains('*') &&
                RenameTo.Text.Length > 0 && FromNumber.Value > 0 &&
                FromNumber.Value <= ToNumber.Value && StartRenameAt.Value > 0
            );
        }

        private void SetBusy(bool to)
        {
            FormatLabel.Enabled = RenameToLabel.Enabled = FromLabel.Enabled = ToLabel.Enabled = StartRenameLabel.Enabled =
                NumberFormat.Enabled = FromDirectoryLabel.Enabled = ToDirectoryLabel.Enabled = FileNameFormat.Enabled = DoOverwrite.Enabled =
                FromNumber.Enabled = ToNumber.Enabled = StartRenameLabel.Enabled = FromDirectoryButton.Enabled = StartButton.Enabled =
                ToDirectoryButton.Enabled = RenameTo.Enabled = StartRenameAt.Enabled = RenameFormat.Enabled = !to;
            if (!to) ProgressBar.Value = 0;
        }

        private void FromDirectoryButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FromDirectoryInput.Text = dialog.SelectedPath;
                CanStart(sender, e);
            }
        }

        private void ToDirectoryButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ToDirectoryInput.Text = dialog.SelectedPath;
                CanStart(sender, e);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            string fromDirectory = FromDirectoryInput.Text;
            string toDirectory = ToDirectoryInput.Text;
            string oldFormat = FileNameFormat.Text;
            long from = (long)FromNumber.Value;
            long to = (long)ToNumber.Value;
            long renamingIndex = (long)StartRenameAt.Value;
            string newName = RenameTo.Text;
            string newFormat = RenameFormat.Text;

            string[] presentFiles = Directory.GetFiles(fromDirectory);
            string[] toImportFiles = new string[0];
            string leadingZeros = "";
            string searchTarget = "";
            int numberCount = 0;
            for (int i = 0; i < oldFormat.Length; i++)
            {
                if (oldFormat[i] == '*')
                {
                    numberCount++;
                    leadingZeros += "0";
                    searchTarget += "*";
                }
            }
            long alreadyImported = 0;
            for (long i=0; i<=(to - from); i++)
            {
                string[] dotFragments = oldFormat.Split('.');
                string extension = dotFragments[dotFragments.Length - 1];
                if (File.Exists(toDirectory + "\\" + newName + " " + newFormat.Replace("<number>", (renamingIndex + i).ToString()) + "." + extension)) alreadyImported++;
            }
            for (long i=from; i<=to; i++)
            {
                string totalNumber = leadingZeros + i.ToString();
                string number = totalNumber.Substring(totalNumber.Length - numberCount, numberCount);
                toImportFiles = toImportFiles.Concat(new string[] { oldFormat.Replace(searchTarget, number) }).ToArray();
            }
            long found = 0;
            foreach (string path in presentFiles)
            {
                string[] directories = path.Split('\\');
                string file = directories[directories.Length - 1];
                if (toImportFiles.Contains(file)) found++;
            }
            if (found == 0)
            {
                MessageBox.Show(((toImportFiles.Length == 1) ? "No queried file has":"None of the " + toImportFiles.Length + " queried files have") + " been found.", "Cannot import", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (MessageBox.Show(((found == 1) ? "The queried file has" : found + " of the " + toImportFiles.Length + " queried files have") + " been found.\nDo you want to continue?", "Please confirm:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            if (alreadyImported > 0 && DoOverwrite.Checked && MessageBox.Show(((alreadyImported == 1) ? "The queried file is" : alreadyImported + " of the " + toImportFiles.Length + " queried files are") + " about to be overwritten.\nDo you want to continue?", "Please confirm:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

            SetBusy(true);
            // start with importing
            decimal progressBarIncrement = Math.Floor((decimal)(100 / found));
            foreach (string path in presentFiles)
            {
                string[] directories = path.Split('\\');
                string file = directories[directories.Length - 1];
                string[] dotFragments = file.Split('.');
                string extension = dotFragments[dotFragments.Length - 1];
                if (toImportFiles.Contains(file))
                {
                    try
                    {
                        if (MoveNotCopy.Checked) File.Move(path, toDirectory + "\\" + newName + " " + newFormat.Replace("<number>", renamingIndex.ToString() + "." + extension), DoOverwrite.Checked);
                        else File.Copy(path, toDirectory + "\\" + newName + " " + newFormat.Replace("<number>", renamingIndex.ToString() + "." + extension), DoOverwrite.Checked);
                    }
                    catch (IOException) { } // when overwriting is prohibited by user, do nothing
                    catch {
                        MessageBox.Show("Something went wrong with importing a file.\nAre you sure that it still exists?", "Cannot import file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SetBusy(false);
                        return;
                    }
                    ProgressBar.Value += (int)progressBarIncrement;
                    renamingIndex++;
                }
            }
            MessageBox.Show("The queried " + ((toImportFiles.Length == 1) ? "file has":"files have") + " been imported and renamed.", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetBusy(false);
        }

        private void TheAboutButton_Click(object sender, EventArgs e)
        {
            Form2 about = new Form2();
            about.ShowDialog();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            RenameFormat.SelectedIndex = 0;
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("User-Agent", "The Import++ Application");
                HttpResponseMessage response = client.GetAsync("https://api.github.com/repos/ILoveAndLikePizza/ImportPlusPlus/releases/latest").Result;
                response.EnsureSuccessStatusCode();
                string responseText = await response.Content.ReadAsStringAsync();
                if (!responseText.Contains("\"name\":\"Import++ v" + ProductVersion + "\""))
                {
                    if (MessageBox.Show("There is a new update available for Import++.\nWould you like to visit the download page?", "Update available", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) System.Diagnostics.Process.Start("cmd.exe", "/c start https://github.com/ILoveAndLikePizza/ImportPlusPlus/releases");
                }
            } catch (Exception)
            {
                MessageBox.Show("Failed to check for updates.\nDon't worry, you can still use Import++.", "Failed to check updates", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }
    }
}