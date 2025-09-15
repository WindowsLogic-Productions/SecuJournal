namespace SecuJournal
{
    partial class sjDate
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
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.UCDTButton = new System.Windows.Forms.Button();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CancelButton = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DateTimePicker2.Location = new System.Drawing.Point(230, 37);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.ShowUpDown = true;
            this.DateTimePicker2.Size = new System.Drawing.Size(124, 20);
            this.DateTimePicker2.TabIndex = 28;
            // 
            // UCDTButton
            // 
            this.UCDTButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.UCDTButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UCDTButton.Location = new System.Drawing.Point(125, 82);
            this.UCDTButton.Name = "UCDTButton";
            this.UCDTButton.Size = new System.Drawing.Size(156, 23);
            this.UCDTButton.TabIndex = 27;
            this.UCDTButton.Text = "Use Current Date and Time";
            this.UCDTButton.UseVisualStyleBackColor = true;
            this.UCDTButton.Click += new System.EventHandler(this.UCDTButton_Click);
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker1.Location = new System.Drawing.Point(100, 37);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(124, 20);
            this.DateTimePicker1.TabIndex = 26;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CancelButton.Location = new System.Drawing.Point(287, 82);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 25;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(11, 10);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(376, 13);
            this.Label2.TabIndex = 24;
            this.Label2.Text = "Select a date and time from the picker below, or use the current date and time.";
            // 
            // OKButton
            // 
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OKButton.Location = new System.Drawing.Point(368, 82);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 23;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // sjDate
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 115);
            this.Controls.Add(this.DateTimePicker2);
            this.Controls.Add(this.UCDTButton);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "sjDate";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insert Date and Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DateTimePicker DateTimePicker2;
        internal System.Windows.Forms.Button UCDTButton;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.Button CancelButton;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button OKButton;
    }
}