namespace ImportPlusPlus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FromDirectoryInput = new System.Windows.Forms.TextBox();
            this.FromDirectoryLabel = new System.Windows.Forms.Label();
            this.FromDirectoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FromDirectoryInput
            // 
            this.FromDirectoryInput.BackColor = System.Drawing.SystemColors.HighlightText;
            this.FromDirectoryInput.Enabled = false;
            this.FromDirectoryInput.Location = new System.Drawing.Point(17, 45);
            this.FromDirectoryInput.Name = "FromDirectoryInput";
            this.FromDirectoryInput.Size = new System.Drawing.Size(564, 27);
            this.FromDirectoryInput.TabIndex = 0;
            // 
            // FromDirectoryLabel
            // 
            this.FromDirectoryLabel.AutoSize = true;
            this.FromDirectoryLabel.Location = new System.Drawing.Point(17, 18);
            this.FromDirectoryLabel.Name = "FromDirectoryLabel";
            this.FromDirectoryLabel.Size = new System.Drawing.Size(124, 20);
            this.FromDirectoryLabel.TabIndex = 1;
            this.FromDirectoryLabel.Text = "Import files from:";
            // 
            // FromDirectoryButton
            // 
            this.FromDirectoryButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FromDirectoryButton.Location = new System.Drawing.Point(599, 44);
            this.FromDirectoryButton.Name = "FromDirectoryButton";
            this.FromDirectoryButton.Size = new System.Drawing.Size(94, 29);
            this.FromDirectoryButton.TabIndex = 2;
            this.FromDirectoryButton.Text = "Browse...";
            this.FromDirectoryButton.UseVisualStyleBackColor = true;
            this.FromDirectoryButton.Click += new System.EventHandler(this.FromDirectoryButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.FromDirectoryButton);
            this.Controls.Add(this.FromDirectoryLabel);
            this.Controls.Add(this.FromDirectoryInput);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Import++";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox FromDirectoryInput;
        private Label FromDirectoryLabel;
        private Button FromDirectoryButton;
    }
}