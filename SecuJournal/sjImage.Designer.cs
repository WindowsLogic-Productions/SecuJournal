namespace SecuJournal
{
    partial class sjImage
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
            this.OKButton = new System.Windows.Forms.Button();
            this.RatioButtonCustom = new System.Windows.Forms.RadioButton();
            this.RatioButton43 = new System.Windows.Forms.RadioButton();
            this.RatioButton169 = new System.Windows.Forms.RadioButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OKButton.Location = new System.Drawing.Point(214, 12);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 15;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // RatioButtonCustom
            // 
            this.RatioButtonCustom.AutoSize = true;
            this.RatioButtonCustom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RatioButtonCustom.Location = new System.Drawing.Point(229, 82);
            this.RatioButtonCustom.Name = "RatioButtonCustom";
            this.RatioButtonCustom.Size = new System.Drawing.Size(66, 18);
            this.RatioButtonCustom.TabIndex = 14;
            this.RatioButtonCustom.TabStop = true;
            this.RatioButtonCustom.Text = "Custom";
            this.RatioButtonCustom.UseVisualStyleBackColor = true;
            this.RatioButtonCustom.CheckedChanged += new System.EventHandler(this.RatioButtonCustom_CheckedChanged);
            // 
            // RatioButton43
            // 
            this.RatioButton43.AutoSize = true;
            this.RatioButton43.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RatioButton43.Location = new System.Drawing.Point(125, 82);
            this.RatioButton43.Name = "RatioButton43";
            this.RatioButton43.Size = new System.Drawing.Size(104, 18);
            this.RatioButton43.TabIndex = 13;
            this.RatioButton43.TabStop = true;
            this.RatioButton43.Text = "200 X 150 (4:3)";
            this.RatioButton43.UseVisualStyleBackColor = true;
            this.RatioButton43.CheckedChanged += new System.EventHandler(this.RatioButton43_CheckedChanged);
            // 
            // RatioButton169
            // 
            this.RatioButton169.AutoSize = true;
            this.RatioButton169.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RatioButton169.Location = new System.Drawing.Point(15, 82);
            this.RatioButton169.Name = "RatioButton169";
            this.RatioButton169.Size = new System.Drawing.Size(110, 18);
            this.RatioButton169.TabIndex = 12;
            this.RatioButton169.TabStop = true;
            this.RatioButton169.Text = "208 X 117 (16:9)";
            this.RatioButton169.UseVisualStyleBackColor = true;
            this.RatioButton169.CheckedChanged += new System.EventHandler(this.RatioButton169_CheckedChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(70, 13);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Resize image";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(105, 44);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(14, 13);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "X";
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(125, 40);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownY.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownY.TabIndex = 9;
            this.numericUpDownY.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(54, 40);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownX.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownX.TabIndex = 8;
            this.numericUpDownX.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // sjImage
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 113);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.RatioButtonCustom);
            this.Controls.Add(this.RatioButton43);
            this.Controls.Add(this.RatioButton169);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.numericUpDownY);
            this.Controls.Add(this.numericUpDownX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "sjImage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Image";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button OKButton;
        internal System.Windows.Forms.RadioButton RatioButtonCustom;
        internal System.Windows.Forms.RadioButton RatioButton43;
        internal System.Windows.Forms.RadioButton RatioButton169;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.NumericUpDown numericUpDownY;
        internal System.Windows.Forms.NumericUpDown numericUpDownX;
    }
}