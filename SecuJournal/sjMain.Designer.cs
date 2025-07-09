namespace SecuJournal
{
    partial class sjMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sjMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewJournalEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenJournalEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JournalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackupJournalEntriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.JournalToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStripMain.Size = new System.Drawing.Size(618, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewJournalEntryToolStripMenuItem,
            this.OpenJournalEntryToolStripMenuItem,
            this.ToolStripSeparator1,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // NewJournalEntryToolStripMenuItem
            // 
            this.NewJournalEntryToolStripMenuItem.Name = "NewJournalEntryToolStripMenuItem";
            this.NewJournalEntryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewJournalEntryToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.NewJournalEntryToolStripMenuItem.Text = "New journal entry";
            this.NewJournalEntryToolStripMenuItem.Click += new System.EventHandler(this.NewJournalEntryToolStripMenuItem_Click);
            // 
            // OpenJournalEntryToolStripMenuItem
            // 
            this.OpenJournalEntryToolStripMenuItem.Name = "OpenJournalEntryToolStripMenuItem";
            this.OpenJournalEntryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenJournalEntryToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.OpenJournalEntryToolStripMenuItem.Text = "Open journal entry...";
            this.OpenJournalEntryToolStripMenuItem.Click += new System.EventHandler(this.OpenJournalEntryToolStripMenuItem_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(222, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // JournalToolStripMenuItem
            // 
            this.JournalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackupJournalEntriesToolStripMenuItem,
            this.ToolStripSeparator2,
            this.SettingsToolStripMenuItem});
            this.JournalToolStripMenuItem.Name = "JournalToolStripMenuItem";
            this.JournalToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.JournalToolStripMenuItem.Text = "Journal";
            // 
            // BackupJournalEntriesToolStripMenuItem
            // 
            this.BackupJournalEntriesToolStripMenuItem.Name = "BackupJournalEntriesToolStripMenuItem";
            this.BackupJournalEntriesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.BackupJournalEntriesToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.BackupJournalEntriesToolStripMenuItem.Text = "Backup journal entries...";
            this.BackupJournalEntriesToolStripMenuItem.Click += new System.EventHandler(this.BackupJournalEntriesToolStripMenuItem_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(238, 6);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.SettingsToolStripMenuItem.Text = "Settings";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // sjMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 435);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "sjMain";
            this.Text = "SecuJournal";
            this.Load += new System.EventHandler(this.sjMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip menuStripMain;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem NewJournalEntryToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem OpenJournalEntryToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem JournalToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem BackupJournalEntriesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

