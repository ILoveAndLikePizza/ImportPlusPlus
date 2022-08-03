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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FromDirectoryInput = new System.Windows.Forms.TextBox();
            this.FromDirectoryLabel = new System.Windows.Forms.Label();
            this.FromDirectoryButton = new System.Windows.Forms.Button();
            this.FormatLabel = new System.Windows.Forms.Label();
            this.FileNameFormat = new System.Windows.Forms.TextBox();
            this.FromLabel = new System.Windows.Forms.Label();
            this.FromNumber = new System.Windows.Forms.NumericUpDown();
            this.ToNumber = new System.Windows.Forms.NumericUpDown();
            this.ToLabel = new System.Windows.Forms.Label();
            this.RenameTo = new System.Windows.Forms.TextBox();
            this.StartRenameAt = new System.Windows.Forms.NumericUpDown();
            this.StartRenameLabel = new System.Windows.Forms.Label();
            this.NumberFormat = new System.Windows.Forms.Label();
            this.RenameToLabel = new System.Windows.Forms.Label();
            this.MainLabel = new System.Windows.Forms.Label();
            this.ToDirectoryButton = new System.Windows.Forms.Button();
            this.ToDirectoryLabel = new System.Windows.Forms.Label();
            this.ToDirectoryInput = new System.Windows.Forms.TextBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.StartButton = new System.Windows.Forms.Button();
            this.TheAboutButton = new System.Windows.Forms.Button();
            this.RenameFormat = new System.Windows.Forms.ComboBox();
            this.DoOverwrite = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MoveNotCopy = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.FromNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartRenameAt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FromDirectoryInput
            // 
            this.FromDirectoryInput.BackColor = System.Drawing.SystemColors.HighlightText;
            this.FromDirectoryInput.Enabled = false;
            this.FromDirectoryInput.Location = new System.Drawing.Point(17, 108);
            this.FromDirectoryInput.Name = "FromDirectoryInput";
            this.FromDirectoryInput.Size = new System.Drawing.Size(564, 27);
            this.FromDirectoryInput.TabIndex = 0;
            // 
            // FromDirectoryLabel
            // 
            this.FromDirectoryLabel.AutoSize = true;
            this.FromDirectoryLabel.Location = new System.Drawing.Point(17, 81);
            this.FromDirectoryLabel.Name = "FromDirectoryLabel";
            this.FromDirectoryLabel.Size = new System.Drawing.Size(124, 20);
            this.FromDirectoryLabel.TabIndex = 1;
            this.FromDirectoryLabel.Text = "Import files from:";
            // 
            // FromDirectoryButton
            // 
            this.FromDirectoryButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FromDirectoryButton.Location = new System.Drawing.Point(599, 107);
            this.FromDirectoryButton.Name = "FromDirectoryButton";
            this.FromDirectoryButton.Size = new System.Drawing.Size(94, 32);
            this.FromDirectoryButton.TabIndex = 2;
            this.FromDirectoryButton.Text = "Browse...";
            this.FromDirectoryButton.UseVisualStyleBackColor = true;
            this.FromDirectoryButton.Click += new System.EventHandler(this.FromDirectoryButton_Click);
            // 
            // FormatLabel
            // 
            this.FormatLabel.AutoSize = true;
            this.FormatLabel.Cursor = System.Windows.Forms.Cursors.Help;
            this.FormatLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.FormatLabel.Location = new System.Drawing.Point(17, 156);
            this.FormatLabel.Name = "FormatLabel";
            this.FormatLabel.Size = new System.Drawing.Size(125, 20);
            this.FormatLabel.TabIndex = 3;
            this.FormatLabel.Text = "File name format:";
            this.toolTip1.SetToolTip(this.FormatLabel, "Define the file name format, including extension.\nUse * to indicate all numbers, " +
        "including leading zeros.\nNote that this is case sensitive!\nExample: IMG_****.JPG" +
        "");
            // 
            // FileNameFormat
            // 
            this.FileNameFormat.Location = new System.Drawing.Point(17, 184);
            this.FileNameFormat.Name = "FileNameFormat";
            this.FileNameFormat.Size = new System.Drawing.Size(374, 27);
            this.FileNameFormat.TabIndex = 3;
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FromLabel.Location = new System.Drawing.Point(415, 156);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(46, 20);
            this.FromLabel.TabIndex = 5;
            this.FromLabel.Text = "From:";
            // 
            // FromNumber
            // 
            this.FromNumber.Location = new System.Drawing.Point(418, 184);
            this.FromNumber.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.FromNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FromNumber.Name = "FromNumber";
            this.FromNumber.Size = new System.Drawing.Size(123, 27);
            this.FromNumber.TabIndex = 4;
            this.FromNumber.BorderStyle = BorderStyle.FixedSingle;
            this.FromNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FromNumber.ValueChanged += new System.EventHandler(this.CanStart);
            // 
            // ToNumber
            // 
            this.ToNumber.Location = new System.Drawing.Point(565, 184);
            this.ToNumber.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ToNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ToNumber.Name = "ToNumber";
            this.ToNumber.BorderStyle = BorderStyle.FixedSingle;
            this.ToNumber.Size = new System.Drawing.Size(123, 27);
            this.ToNumber.TabIndex = 5;
            this.ToNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ToNumber.ValueChanged += new System.EventHandler(this.CanStart);
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToLabel.Location = new System.Drawing.Point(562, 156);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(114, 20);
            this.ToLabel.TabIndex = 7;
            this.ToLabel.Text = "Until (included):";
            // 
            // RenameTo
            // 
            this.RenameTo.Location = new System.Drawing.Point(17, 255);
            this.RenameTo.Name = "RenameTo";
            this.RenameTo.Size = new System.Drawing.Size(374, 27);
            this.RenameTo.TabIndex = 6;
            this.RenameTo.TextChanged += new System.EventHandler(this.CanStart);
            // 
            // StartRenameAt
            // 
            this.StartRenameAt.Location = new System.Drawing.Point(418, 255);
            this.StartRenameAt.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.StartRenameAt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartRenameAt.BorderStyle = BorderStyle.FixedSingle;
            this.StartRenameAt.Name = "StartRenameAt";
            this.StartRenameAt.Size = new System.Drawing.Size(123, 27);
            this.StartRenameAt.TabIndex = 7;
            this.StartRenameAt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartRenameAt.ValueChanged += new System.EventHandler(this.CanStart);
            // 
            // StartRenameLabel
            // 
            this.StartRenameLabel.AutoSize = true;
            this.StartRenameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartRenameLabel.Location = new System.Drawing.Point(415, 227);
            this.StartRenameLabel.Name = "StartRenameLabel";
            this.StartRenameLabel.Size = new System.Drawing.Size(60, 20);
            this.StartRenameLabel.TabIndex = 11;
            this.StartRenameLabel.Text = "Start at:";
            // 
            // NumberFormat
            // 
            this.NumberFormat.AutoSize = true;
            this.NumberFormat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberFormat.Location = new System.Drawing.Point(562, 227);
            this.NumberFormat.Name = "NumberFormat";
            this.NumberFormat.Size = new System.Drawing.Size(115, 20);
            this.NumberFormat.TabIndex = 14;
            this.NumberFormat.Text = "Number format:";
            // 
            // RenameToLabel
            // 
            this.RenameToLabel.AutoSize = true;
            this.RenameToLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RenameToLabel.Location = new System.Drawing.Point(17, 227);
            this.RenameToLabel.Name = "RenameToLabel";
            this.RenameToLabel.Size = new System.Drawing.Size(115, 20);
            this.RenameToLabel.TabIndex = 15;
            this.RenameToLabel.Text = "Rename files to:";
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainLabel.Location = new System.Drawing.Point(14, 24);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(281, 32);
            this.MainLabel.TabIndex = 16;
            this.MainLabel.Text = "Welcome to Import++";
            // 
            // ToDirectoryButton
            // 
            this.ToDirectoryButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ToDirectoryButton.Location = new System.Drawing.Point(598, 326);
            this.ToDirectoryButton.Name = "ToDirectoryButton";
            this.ToDirectoryButton.Size = new System.Drawing.Size(94, 32);
            this.ToDirectoryButton.TabIndex = 9;
            this.ToDirectoryButton.Text = "Browse...";
            this.ToDirectoryButton.UseVisualStyleBackColor = true;
            this.ToDirectoryButton.Click += new System.EventHandler(this.ToDirectoryButton_Click);
            // 
            // ToDirectoryLabel
            // 
            this.ToDirectoryLabel.AutoSize = true;
            this.ToDirectoryLabel.Location = new System.Drawing.Point(16, 300);
            this.ToDirectoryLabel.Name = "ToDirectoryLabel";
            this.ToDirectoryLabel.Size = new System.Drawing.Size(158, 20);
            this.ToDirectoryLabel.TabIndex = 18;
            this.ToDirectoryLabel.Text = "Save imported files to:";
            // 
            // ToDirectoryInput
            // 
            this.ToDirectoryInput.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ToDirectoryInput.Enabled = false;
            this.ToDirectoryInput.Location = new System.Drawing.Point(16, 327);
            this.ToDirectoryInput.Name = "ToDirectoryInput";
            this.ToDirectoryInput.Size = new System.Drawing.Size(564, 27);
            this.ToDirectoryInput.TabIndex = 17;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(17, 420);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(564, 38);
            this.ProgressBar.TabIndex = 22;
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StartButton.Location = new System.Drawing.Point(599, 420);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(93, 38);
            this.StartButton.TabIndex = 11;
            this.StartButton.Text = "Start!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // TheAboutButton
            // 
            this.TheAboutButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TheAboutButton.Location = new System.Drawing.Point(488, 16);
            this.TheAboutButton.Name = "TheAboutButton";
            this.TheAboutButton.Size = new System.Drawing.Size(93, 29);
            this.TheAboutButton.TabIndex = 1;
            this.TheAboutButton.Text = "About...";
            this.TheAboutButton.UseVisualStyleBackColor = true;
            this.TheAboutButton.Click += new System.EventHandler(this.TheAboutButton_Click);
            // 
            // RenameFormat
            // 
            this.RenameFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RenameFormat.FormattingEnabled = true;
            this.RenameFormat.Items.AddRange(new object[] {
            "<number>",
            "(<number>)",
            "- <number>"});
            this.RenameFormat.Location = new System.Drawing.Point(562, 255);
            this.RenameFormat.Name = "RenameFormat";
            this.RenameFormat.Size = new System.Drawing.Size(126, 28);
            this.RenameFormat.TabIndex = 8;
            // 
            // DoOverwrite
            // 
            this.DoOverwrite.AutoSize = true;
            this.DoOverwrite.Checked = true;
            this.DoOverwrite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DoOverwrite.Location = new System.Drawing.Point(17, 375);
            this.DoOverwrite.Name = "DoOverwrite";
            this.DoOverwrite.FlatStyle = FlatStyle.System;
            this.DoOverwrite.Size = new System.Drawing.Size(302, 24);
            this.DoOverwrite.TabIndex = 10;
            this.DoOverwrite.Text = "Overwrite files if they are already present";
            this.DoOverwrite.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(617, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // MoveNotCopy
            // 
            this.MoveNotCopy.AutoSize = true;
            this.MoveNotCopy.Location = new System.Drawing.Point(374, 375);
            this.MoveNotCopy.Name = "MoveNotCopy";
            this.MoveNotCopy.Size = new System.Drawing.Size(289, 24);
            this.MoveNotCopy.TabIndex = 11;
            this.MoveNotCopy.FlatStyle = FlatStyle.System;
            this.MoveNotCopy.Text = "Move the files instead of copying them";
            this.MoveNotCopy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 481);
            this.Controls.Add(this.MoveNotCopy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DoOverwrite);
            this.Controls.Add(this.RenameFormat);
            this.Controls.Add(this.TheAboutButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ToDirectoryButton);
            this.Controls.Add(this.ToDirectoryLabel);
            this.Controls.Add(this.ToDirectoryInput);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.RenameToLabel);
            this.Controls.Add(this.NumberFormat);
            this.Controls.Add(this.StartRenameAt);
            this.Controls.Add(this.StartRenameLabel);
            this.Controls.Add(this.RenameTo);
            this.Controls.Add(this.ToNumber);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FromNumber);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.FileNameFormat);
            this.Controls.Add(this.FormatLabel);
            this.Controls.Add(this.FromDirectoryButton);
            this.Controls.Add(this.FromDirectoryLabel);
            this.Controls.Add(this.FromDirectoryInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::ImportPlusPlus.Properties.Resources.importplusplus;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Import++";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FromNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartRenameAt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox FromDirectoryInput;
        private Label FromDirectoryLabel;
        private Button FromDirectoryButton;
        private Label FormatLabel;
        private TextBox FileNameFormat;
        private Label FromLabel;
        private NumericUpDown FromNumber;
        private NumericUpDown ToNumber;
        private Label ToLabel;
        private TextBox RenameTo;
        private NumericUpDown StartRenameAt;
        private Label StartRenameLabel;
        private Label NumberFormat;
        private Label RenameToLabel;
        private Label MainLabel;
        private Button ToDirectoryButton;
        private Label ToDirectoryLabel;
        private TextBox ToDirectoryInput;
        private ProgressBar ProgressBar;
        private Button StartButton;
        private Button TheAboutButton;
        private ComboBox RenameFormat;
        private CheckBox DoOverwrite;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
        private CheckBox MoveNotCopy;
    }
}