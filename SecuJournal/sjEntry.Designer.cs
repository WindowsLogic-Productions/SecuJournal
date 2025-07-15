namespace SecuJournal
{
    partial class sjEntry
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
            this.components = new System.ComponentModel.Container();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.MaximiseButton = new System.Windows.Forms.Button();
            this.MinimiseButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.RFNCheckBox = new System.Windows.Forms.CheckBox();
            this.FindPanelClose = new System.Windows.Forms.Button();
            this.rightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.UndoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.CutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.InsertPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertDateAndTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.EncryptTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DecryptTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.MCCheckBox = new System.Windows.Forms.CheckBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.txtReplacementText = new System.Windows.Forms.TextBox();
            this.lblReplacementText = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.lblSearchText = new System.Windows.Forms.Label();
            this.rightClickMenu.SuspendLayout();
            this.renameMenu.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RichTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBox1.Location = new System.Drawing.Point(0, 27);
            this.RichTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(618, 431);
            this.RichTextBox1.TabIndex = 2;
            this.RichTextBox1.Text = "";
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(410, 3);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(15, 13);
            this.Label1.TabIndex = 28;
            this.Label1.Text = "=";
            this.toolTip1.SetToolTip(this.Label1, "Drag space");
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePicker1.Location = new System.Drawing.Point(427, 0);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(124, 22);
            this.DateTimePicker1.TabIndex = 27;
            // 
            // TextBox1
            // 
            this.TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox1.ContextMenuStrip = this.renameMenu;
            this.TextBox1.Location = new System.Drawing.Point(0, 0);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(405, 22);
            this.TextBox1.TabIndex = 25;
            this.TextBox1.Text = "New journal entry";
            this.toolTip1.SetToolTip(this.TextBox1, "Rename journal entry.");
            // 
            // MaximiseButton
            // 
            this.MaximiseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximiseButton.FlatAppearance.BorderSize = 0;
            this.MaximiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MaximiseButton.Image = global::SecuJournal.Properties.Resources.WinMaximise;
            this.MaximiseButton.Location = new System.Drawing.Point(577, 0);
            this.MaximiseButton.Name = "MaximiseButton";
            this.MaximiseButton.Size = new System.Drawing.Size(20, 20);
            this.MaximiseButton.TabIndex = 26;
            this.toolTip1.SetToolTip(this.MaximiseButton, "Maximise");
            this.MaximiseButton.UseVisualStyleBackColor = true;
            // 
            // MinimiseButton
            // 
            this.MinimiseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimiseButton.FlatAppearance.BorderSize = 0;
            this.MinimiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MinimiseButton.Image = global::SecuJournal.Properties.Resources.WinMinimise;
            this.MinimiseButton.Location = new System.Drawing.Point(556, 0);
            this.MinimiseButton.Name = "MinimiseButton";
            this.MinimiseButton.Size = new System.Drawing.Size(20, 20);
            this.MinimiseButton.TabIndex = 24;
            this.toolTip1.SetToolTip(this.MinimiseButton, "Minimise");
            this.MinimiseButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.Image = global::SecuJournal.Properties.Resources.WinClose;
            this.CloseButton.Location = new System.Drawing.Point(598, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(20, 20);
            this.CloseButton.TabIndex = 23;
            this.toolTip1.SetToolTip(this.CloseButton, "Close");
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // RFNCheckBox
            // 
            this.RFNCheckBox.AutoSize = true;
            this.RFNCheckBox.Location = new System.Drawing.Point(100, 103);
            this.RFNCheckBox.Name = "RFNCheckBox";
            this.RFNCheckBox.Size = new System.Drawing.Size(116, 17);
            this.RFNCheckBox.TabIndex = 28;
            this.RFNCheckBox.Text = "Replace file name";
            this.toolTip1.SetToolTip(this.RFNCheckBox, "This option is useful if you want to replace the file name of your entry.\r\n\r\nWhen" +
        " doing so, make sure to copy the entire title to not lose anything.");
            this.RFNCheckBox.UseVisualStyleBackColor = true;
            // 
            // FindPanelClose
            // 
            this.FindPanelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FindPanelClose.FlatAppearance.BorderSize = 0;
            this.FindPanelClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FindPanelClose.Image = global::SecuJournal.Properties.Resources.WinClose;
            this.FindPanelClose.Location = new System.Drawing.Point(296, 3);
            this.FindPanelClose.Name = "FindPanelClose";
            this.FindPanelClose.Size = new System.Drawing.Size(20, 20);
            this.FindPanelClose.TabIndex = 27;
            this.toolTip1.SetToolTip(this.FindPanelClose, "Close");
            this.FindPanelClose.UseVisualStyleBackColor = true;
            // 
            // rightClickMenu
            // 
            this.rightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.findToolStripMenuItem,
            this.toolStripSeparator1,
            this.UndoToolStripMenuItem1,
            this.RedoToolStripMenuItem1,
            this.ToolStripSeparator12,
            this.CutToolStripMenuItem1,
            this.CopyToolStripMenuItem1,
            this.PasteToolStripMenuItem1,
            this.ToolStripSeparator11,
            this.SelectAllToolStripMenuItem1,
            this.ToolStripSeparator13,
            this.InsertPictureToolStripMenuItem,
            this.InsertDateAndTimeToolStripMenuItem,
            this.ToolStripSeparator14,
            this.EncryptTextToolStripMenuItem,
            this.DecryptTextToolStripMenuItem});
            this.rightClickMenu.Name = "ContextMenuStrip1";
            this.rightClickMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.rightClickMenu.Size = new System.Drawing.Size(263, 298);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.printToolStripMenuItem.Text = "Print...";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.findToolStripMenuItem.Text = "Find && Replace...";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(259, 6);
            // 
            // UndoToolStripMenuItem1
            // 
            this.UndoToolStripMenuItem1.Name = "UndoToolStripMenuItem1";
            this.UndoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoToolStripMenuItem1.Size = new System.Drawing.Size(262, 22);
            this.UndoToolStripMenuItem1.Text = "Undo";
            this.UndoToolStripMenuItem1.Click += new System.EventHandler(this.UndoToolStripMenuItem1_Click);
            // 
            // RedoToolStripMenuItem1
            // 
            this.RedoToolStripMenuItem1.Name = "RedoToolStripMenuItem1";
            this.RedoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.RedoToolStripMenuItem1.Size = new System.Drawing.Size(262, 22);
            this.RedoToolStripMenuItem1.Text = "Redo";
            this.RedoToolStripMenuItem1.Click += new System.EventHandler(this.RedoToolStripMenuItem1_Click);
            // 
            // ToolStripSeparator12
            // 
            this.ToolStripSeparator12.Name = "ToolStripSeparator12";
            this.ToolStripSeparator12.Size = new System.Drawing.Size(259, 6);
            // 
            // CutToolStripMenuItem1
            // 
            this.CutToolStripMenuItem1.Name = "CutToolStripMenuItem1";
            this.CutToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutToolStripMenuItem1.Size = new System.Drawing.Size(262, 22);
            this.CutToolStripMenuItem1.Text = "Cut";
            this.CutToolStripMenuItem1.Click += new System.EventHandler(this.CutToolStripMenuItem1_Click);
            // 
            // CopyToolStripMenuItem1
            // 
            this.CopyToolStripMenuItem1.Name = "CopyToolStripMenuItem1";
            this.CopyToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyToolStripMenuItem1.Size = new System.Drawing.Size(262, 22);
            this.CopyToolStripMenuItem1.Text = "Copy";
            this.CopyToolStripMenuItem1.Click += new System.EventHandler(this.CopyToolStripMenuItem1_Click);
            // 
            // PasteToolStripMenuItem1
            // 
            this.PasteToolStripMenuItem1.Name = "PasteToolStripMenuItem1";
            this.PasteToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteToolStripMenuItem1.Size = new System.Drawing.Size(262, 22);
            this.PasteToolStripMenuItem1.Text = "Paste";
            this.PasteToolStripMenuItem1.Click += new System.EventHandler(this.PasteToolStripMenuItem1_Click);
            // 
            // ToolStripSeparator11
            // 
            this.ToolStripSeparator11.Name = "ToolStripSeparator11";
            this.ToolStripSeparator11.Size = new System.Drawing.Size(259, 6);
            // 
            // SelectAllToolStripMenuItem1
            // 
            this.SelectAllToolStripMenuItem1.Name = "SelectAllToolStripMenuItem1";
            this.SelectAllToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAllToolStripMenuItem1.Size = new System.Drawing.Size(262, 22);
            this.SelectAllToolStripMenuItem1.Text = "Select all";
            this.SelectAllToolStripMenuItem1.Click += new System.EventHandler(this.SelectAllToolStripMenuItem1_Click);
            // 
            // ToolStripSeparator13
            // 
            this.ToolStripSeparator13.Name = "ToolStripSeparator13";
            this.ToolStripSeparator13.Size = new System.Drawing.Size(259, 6);
            // 
            // InsertPictureToolStripMenuItem
            // 
            this.InsertPictureToolStripMenuItem.Name = "InsertPictureToolStripMenuItem";
            this.InsertPictureToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.InsertPictureToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.InsertPictureToolStripMenuItem.Text = "Insert picture...";
            this.InsertPictureToolStripMenuItem.Click += new System.EventHandler(this.InsertPictureToolStripMenuItem_Click);
            // 
            // InsertDateAndTimeToolStripMenuItem
            // 
            this.InsertDateAndTimeToolStripMenuItem.Name = "InsertDateAndTimeToolStripMenuItem";
            this.InsertDateAndTimeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.InsertDateAndTimeToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.InsertDateAndTimeToolStripMenuItem.Text = "Insert date and time...";
            this.InsertDateAndTimeToolStripMenuItem.Click += new System.EventHandler(this.InsertDateAndTimeToolStripMenuItem_Click);
            // 
            // ToolStripSeparator14
            // 
            this.ToolStripSeparator14.Name = "ToolStripSeparator14";
            this.ToolStripSeparator14.Size = new System.Drawing.Size(259, 6);
            // 
            // EncryptTextToolStripMenuItem
            // 
            this.EncryptTextToolStripMenuItem.Name = "EncryptTextToolStripMenuItem";
            this.EncryptTextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.EncryptTextToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.EncryptTextToolStripMenuItem.Text = "Encrypt text";
            this.EncryptTextToolStripMenuItem.Click += new System.EventHandler(this.EncryptTextToolStripMenuItem_Click);
            // 
            // DecryptTextToolStripMenuItem
            // 
            this.DecryptTextToolStripMenuItem.Name = "DecryptTextToolStripMenuItem";
            this.DecryptTextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.DecryptTextToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.DecryptTextToolStripMenuItem.Text = "Decrypt text";
            this.DecryptTextToolStripMenuItem.Click += new System.EventHandler(this.DecryptTextToolStripMenuItem_Click);
            // 
            // renameMenu
            // 
            this.renameMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem3,
            this.ToolStripMenuItem4,
            this.ToolStripMenuItem5,
            this.ToolStripSeparator6,
            this.ToolStripMenuItem6});
            this.renameMenu.Name = "ContextMenuStrip1";
            this.renameMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.renameMenu.Size = new System.Drawing.Size(163, 98);
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(162, 22);
            this.ToolStripMenuItem3.Text = "Cut";
            // 
            // ToolStripMenuItem4
            // 
            this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
            this.ToolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.ToolStripMenuItem4.Size = new System.Drawing.Size(162, 22);
            this.ToolStripMenuItem4.Text = "Copy";
            // 
            // ToolStripMenuItem5
            // 
            this.ToolStripMenuItem5.Name = "ToolStripMenuItem5";
            this.ToolStripMenuItem5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.ToolStripMenuItem5.Size = new System.Drawing.Size(162, 22);
            this.ToolStripMenuItem5.Text = "Paste";
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(159, 6);
            // 
            // ToolStripMenuItem6
            // 
            this.ToolStripMenuItem6.Name = "ToolStripMenuItem6";
            this.ToolStripMenuItem6.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.ToolStripMenuItem6.Size = new System.Drawing.Size(162, 22);
            this.ToolStripMenuItem6.Text = "Select all";
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.RFNCheckBox);
            this.Panel1.Controls.Add(this.FindPanelClose);
            this.Panel1.Controls.Add(this.MCCheckBox);
            this.Panel1.Controls.Add(this.btnReplace);
            this.Panel1.Controls.Add(this.txtReplacementText);
            this.Panel1.Controls.Add(this.lblReplacementText);
            this.Panel1.Controls.Add(this.btnFind);
            this.Panel1.Controls.Add(this.txtSearchText);
            this.Panel1.Controls.Add(this.lblSearchText);
            this.Panel1.Location = new System.Drawing.Point(0, 326);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(319, 132);
            this.Panel1.TabIndex = 31;
            this.Panel1.Visible = false;
            this.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            this.Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // MCCheckBox
            // 
            this.MCCheckBox.AutoSize = true;
            this.MCCheckBox.Location = new System.Drawing.Point(12, 103);
            this.MCCheckBox.Name = "MCCheckBox";
            this.MCCheckBox.Size = new System.Drawing.Size(83, 17);
            this.MCCheckBox.TabIndex = 26;
            this.MCCheckBox.Text = "Match case";
            this.MCCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnReplace
            // 
            this.btnReplace.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReplace.Location = new System.Drawing.Point(230, 68);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 25;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            // 
            // txtReplacementText
            // 
            this.txtReplacementText.Location = new System.Drawing.Point(12, 68);
            this.txtReplacementText.Name = "txtReplacementText";
            this.txtReplacementText.Size = new System.Drawing.Size(212, 22);
            this.txtReplacementText.TabIndex = 23;
            // 
            // lblReplacementText
            // 
            this.lblReplacementText.AutoSize = true;
            this.lblReplacementText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblReplacementText.Location = new System.Drawing.Point(9, 51);
            this.lblReplacementText.Name = "lblReplacementText";
            this.lblReplacementText.Size = new System.Drawing.Size(98, 13);
            this.lblReplacementText.TabIndex = 22;
            this.lblReplacementText.Text = "Replacement Text:";
            // 
            // btnFind
            // 
            this.btnFind.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFind.Location = new System.Drawing.Point(230, 28);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 24;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(12, 28);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(212, 22);
            this.txtSearchText.TabIndex = 21;
            // 
            // lblSearchText
            // 
            this.lblSearchText.AutoSize = true;
            this.lblSearchText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSearchText.Location = new System.Drawing.Point(9, 12);
            this.lblSearchText.Name = "lblSearchText";
            this.lblSearchText.Size = new System.Drawing.Size(66, 13);
            this.lblSearchText.TabIndex = 20;
            this.lblSearchText.Text = "Search Text:";
            // 
            // sjEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 458);
            this.ControlBox = false;
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.MaximiseButton);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.MinimiseButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RichTextBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "sjEntry";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.sjEntry_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sjEntry_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sjEntry_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sjEntry_MouseUp);
            this.rightClickMenu.ResumeLayout(false);
            this.renameMenu.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.RichTextBox RichTextBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.Button MaximiseButton;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Button MinimiseButton;
        internal System.Windows.Forms.Button CloseButton;
        internal System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.ContextMenuStrip rightClickMenu;
        internal System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem RedoToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator12;
        internal System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator11;
        internal System.Windows.Forms.ToolStripMenuItem SelectAllToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator13;
        internal System.Windows.Forms.ToolStripMenuItem InsertPictureToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem InsertDateAndTimeToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator14;
        internal System.Windows.Forms.ToolStripMenuItem EncryptTextToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DecryptTextToolStripMenuItem;
        internal System.Windows.Forms.ContextMenuStrip renameMenu;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem3;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem4;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem5;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator6;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem6;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.CheckBox RFNCheckBox;
        internal System.Windows.Forms.Button FindPanelClose;
        internal System.Windows.Forms.CheckBox MCCheckBox;
        internal System.Windows.Forms.Button btnReplace;
        internal System.Windows.Forms.TextBox txtReplacementText;
        internal System.Windows.Forms.Label lblReplacementText;
        internal System.Windows.Forms.Button btnFind;
        internal System.Windows.Forms.TextBox txtSearchText;
        internal System.Windows.Forms.Label lblSearchText;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}