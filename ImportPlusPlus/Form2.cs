namespace ImportPlusPlus
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            VersionLabel.Text += ProductVersion;
        }

        private void WebsiteButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/c start https://nm-games.eu");
        }

        private void GitHubButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/c start https://github.com/ILoveAndLikePizza/ImportPlusPlus");
        }

        private void DiscordButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe", "/c start https://discord.gg/CaMaGRXDqB");
        }
    }
}
