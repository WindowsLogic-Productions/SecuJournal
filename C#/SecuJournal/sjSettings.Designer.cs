namespace SecuJournal
{
    partial class sjSettings
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
            this.WTCheckBox = new System.Windows.Forms.CheckBox();
            this.WWCheckbox = new System.Windows.Forms.CheckBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.OTFECheckBox = new System.Windows.Forms.CheckBox();
            this.OTFEPassword = new System.Windows.Forms.TextBox();
            this.DSLBrowseButton = new System.Windows.Forms.Button();
            this.DSLText = new System.Windows.Forms.TextBox();
            this.DSLLabel = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WTCheckBox
            // 
            this.WTCheckBox.AutoSize = true;
            this.WTCheckBox.Location = new System.Drawing.Point(130, 48);
            this.WTCheckBox.Name = "WTCheckBox";
            this.WTCheckBox.Size = new System.Drawing.Size(176, 17);
            this.WTCheckBox.TabIndex = 18;
            this.WTCheckBox.Text = "Write journal title on top of page";
            this.WTCheckBox.UseVisualStyleBackColor = true;
            this.WTCheckBox.CheckedChanged += new System.EventHandler(this.WTCheckBox_CheckedChanged);
            // 
            // WWCheckbox
            // 
            this.WWCheckbox.AutoSize = true;
            this.WWCheckbox.Location = new System.Drawing.Point(13, 48);
            this.WWCheckbox.Name = "WWCheckbox";
            this.WWCheckbox.Size = new System.Drawing.Size(111, 17);
            this.WWCheckbox.TabIndex = 17;
            this.WWCheckbox.Text = "Enable word wrap";
            this.WWCheckbox.UseVisualStyleBackColor = true;
            this.WWCheckbox.CheckedChanged += new System.EventHandler(this.WWCheckbox_CheckedChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.OTFECheckBox);
            this.GroupBox1.Controls.Add(this.OTFEPassword);
            this.GroupBox1.Location = new System.Drawing.Point(12, 80);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(371, 90);
            this.GroupBox1.TabIndex = 16;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Text Encryption";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(354, 13);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "When using text encryption, a password is required to unlock your journal.";
            // 
            // OTFECheckBox
            // 
            this.OTFECheckBox.AutoSize = true;
            this.OTFECheckBox.Location = new System.Drawing.Point(6, 67);
            this.OTFECheckBox.Name = "OTFECheckBox";
            this.OTFECheckBox.Size = new System.Drawing.Size(200, 17);
            this.OTFECheckBox.TabIndex = 8;
            this.OTFECheckBox.Text = "Use text encryption for journal entries";
            this.OTFECheckBox.UseVisualStyleBackColor = true;
            this.OTFECheckBox.CheckedChanged += new System.EventHandler(this.OTFECheckBox_CheckedChanged);
            // 
            // OTFEPassword
            // 
            this.OTFEPassword.Enabled = false;
            this.OTFEPassword.Location = new System.Drawing.Point(6, 41);
            this.OTFEPassword.Name = "OTFEPassword";
            this.OTFEPassword.PasswordChar = '*';
            this.OTFEPassword.Size = new System.Drawing.Size(359, 20);
            this.OTFEPassword.TabIndex = 9;
            // 
            // DSLBrowseButton
            // 
            this.DSLBrowseButton.Location = new System.Drawing.Point(308, 12);
            this.DSLBrowseButton.Name = "DSLBrowseButton";
            this.DSLBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.DSLBrowseButton.TabIndex = 15;
            this.DSLBrowseButton.Text = "Browse...";
            this.DSLBrowseButton.UseVisualStyleBackColor = true;
            this.DSLBrowseButton.Click += new System.EventHandler(this.DSLBrowseButton_Click);
            // 
            // DSLText
            // 
            this.DSLText.Location = new System.Drawing.Point(129, 14);
            this.DSLText.Name = "DSLText";
            this.DSLText.Size = new System.Drawing.Size(173, 20);
            this.DSLText.TabIndex = 14;
            // 
            // DSLLabel
            // 
            this.DSLLabel.AutoSize = true;
            this.DSLLabel.Location = new System.Drawing.Point(13, 17);
            this.DSLLabel.Name = "DSLLabel";
            this.DSLLabel.Size = new System.Drawing.Size(110, 13);
            this.DSLLabel.TabIndex = 13;
            this.DSLLabel.Text = "Default save location:";
            // 
            // sjSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 183);
            this.Controls.Add(this.WTCheckBox);
            this.Controls.Add(this.WWCheckbox);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.DSLBrowseButton);
            this.Controls.Add(this.DSLText);
            this.Controls.Add(this.DSLLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "sjSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SecuJournal Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sjSettings_FormClosing);
            this.Load += new System.EventHandler(this.sjSettings_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox WTCheckBox;
        internal System.Windows.Forms.CheckBox WWCheckbox;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.CheckBox OTFECheckBox;
        internal System.Windows.Forms.TextBox OTFEPassword;
        internal System.Windows.Forms.Button DSLBrowseButton;
        internal System.Windows.Forms.TextBox DSLText;
        internal System.Windows.Forms.Label DSLLabel;
    }
}