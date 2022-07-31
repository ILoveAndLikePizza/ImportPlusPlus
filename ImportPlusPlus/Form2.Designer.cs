namespace ImportPlusPlus
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.VersionLabel = new System.Windows.Forms.Label();
            this.ByLabel = new System.Windows.Forms.Label();
            this.NMGames = new System.Windows.Forms.PictureBox();
            this.WebsiteButton = new System.Windows.Forms.Button();
            this.GitHubButton = new System.Windows.Forms.Button();
            this.DiscordButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NMGames)).BeginInit();
            this.SuspendLayout();
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VersionLabel.Location = new System.Drawing.Point(34, 14);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(200, 45);
            this.VersionLabel.TabIndex = 0;
            this.VersionLabel.Text = "Import++ v";
            // 
            // ByLabel
            // 
            this.ByLabel.AutoSize = true;
            this.ByLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ByLabel.Location = new System.Drawing.Point(29, 80);
            this.ByLabel.Name = "ByLabel";
            this.ByLabel.Size = new System.Drawing.Size(40, 31);
            this.ByLabel.TabIndex = 1;
            this.ByLabel.Text = "by";
            // 
            // NMGames
            // 
            this.NMGames.Image = ((System.Drawing.Image)(resources.GetObject("NMGames.Image")));
            this.NMGames.Location = new System.Drawing.Point(76, 65);
            this.NMGames.Name = "NMGames";
            this.NMGames.Size = new System.Drawing.Size(263, 67);
            this.NMGames.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NMGames.TabIndex = 2;
            this.NMGames.TabStop = false;
            // 
            // WebsiteButton
            // 
            this.WebsiteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.WebsiteButton.Location = new System.Drawing.Point(41, 265);
            this.WebsiteButton.Name = "WebsiteButton";
            this.WebsiteButton.Size = new System.Drawing.Size(94, 31);
            this.WebsiteButton.TabIndex = 3;
            this.WebsiteButton.Text = "Website";
            this.WebsiteButton.UseVisualStyleBackColor = true;
            this.WebsiteButton.Click += new System.EventHandler(this.WebsiteButton_Click);
            // 
            // GitHubButton
            // 
            this.GitHubButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GitHubButton.Location = new System.Drawing.Point(141, 265);
            this.GitHubButton.Name = "GitHubButton";
            this.GitHubButton.Size = new System.Drawing.Size(94, 31);
            this.GitHubButton.TabIndex = 4;
            this.GitHubButton.Text = "GitHub";
            this.GitHubButton.UseVisualStyleBackColor = true;
            this.GitHubButton.Click += new System.EventHandler(this.GitHubButton_Click);
            // 
            // DiscordButton
            // 
            this.DiscordButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DiscordButton.Location = new System.Drawing.Point(241, 265);
            this.DiscordButton.Name = "DiscordButton";
            this.DiscordButton.Size = new System.Drawing.Size(94, 31);
            this.DiscordButton.TabIndex = 5;
            this.DiscordButton.Text = "Discord";
            this.DiscordButton.UseVisualStyleBackColor = true;
            this.DiscordButton.Click += new System.EventHandler(this.DiscordButton_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(43, 146);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(289, 100);
            this.InfoLabel.TabIndex = 6;
            this.InfoLabel.Text = "Import++ is a free and open-source tool\r\nto import and automatically rename files" +
    "!\r\n\r\nNeed help? Take a look at the README on\r\nGitHub for a detailed example.\r\n";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 321);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.DiscordButton);
            this.Controls.Add(this.GitHubButton);
            this.Controls.Add(this.WebsiteButton);
            this.Controls.Add(this.NMGames);
            this.Controls.Add(this.ByLabel);
            this.Controls.Add(this.VersionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::ImportPlusPlus.Properties.Resources.importplusplus;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "About Import++";
            ((System.ComponentModel.ISupportInitialize)(this.NMGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label VersionLabel;
        private Label ByLabel;
        private PictureBox NMGames;
        private Button WebsiteButton;
        private Button GitHubButton;
        private Button DiscordButton;
        private Label InfoLabel;
    }
}