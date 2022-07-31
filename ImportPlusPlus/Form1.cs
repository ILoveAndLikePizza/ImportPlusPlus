using System.IO;

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
                FromNumber.Value < ToNumber.Value && StartRenameAt.Value > 0
            );
        }

        private void SetBusy(bool to)
        {
            FormatLabel.Enabled = RenameToLabel.Enabled = FromLabel.Enabled = ToLabel.Enabled = StartRenameLabel.Enabled =
                NumberFormat.Enabled = FromDirectoryLabel.Enabled = ToDirectoryLabel.Enabled = FileNameFormat.Enabled = DoOverwrite.Enabled =
                FromNumber.Enabled = ToNumber.Enabled = StartRenameLabel.Enabled = FromDirectoryButton.Enabled = StartButton.Enabled =
                ToDirectoryButton.Enabled = RenameTo.Enabled = StartRenameAt.Enabled = RenameFormat.Enabled = !to;
            ProgressLabel.Visible = to;
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
                MessageBox.Show("None of the " + toImportFiles.Length + " queried files have been found.", "Cannot import", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (MessageBox.Show(found + " of the " + toImportFiles.Length + " queried files have been found.\nDo you want to continue?", "Please confirm:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
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
                        File.Copy(path, toDirectory + "\\" + newName + " " + newFormat.Replace("<number>", renamingIndex.ToString() + "." + extension), DoOverwrite.Checked);
                    } catch
                    {
                        MessageBox.Show("Something went wrong with importing a file.\nAre you sure that it still exists?", "Cannot import file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ProgressLabel.Text = "Copying " + file + "...";
                    ProgressBar.Value += (int)progressBarIncrement;
                    renamingIndex++;
                }
            }
            MessageBox.Show(found + " files have been imported and renamed.", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetBusy(false);
        }

        private void TheAboutButton_Click(object sender, EventArgs e)
        {
            Form2 about = new Form2();
            about.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RenameFormat.SelectedIndex = 0;
        }
    }
}