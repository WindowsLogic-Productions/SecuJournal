using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecuJournal
{
    public partial class sjSettings : Form
    {
        public sjSettings()
        {
            InitializeComponent();
        }

        private void sjSettings_Load(object sender, EventArgs e)
        {
            // Load default save directory settings.
            DSLText.Text = Properties.Settings.Default.DefaultSaveDirectory;

            // Load word-wrap settings.
            if (Properties.Settings.Default.WordWrap == false)
            {
                WWCheckbox.Checked = false;
            }
            else
            {
                WWCheckbox.Checked = true;
            }

            // Load encryption settings.
            if (Properties.Settings.Default.OTFEncryption == false)
            {
                OTFECheckBox.Checked = false;
                OTFEPassword.Enabled = false;
            }
            else
            {
                OTFECheckBox.Checked = true;
                OTFEPassword.Enabled = true;
            }

            // User set password is always the OTFE password when enabled.
            OTFEPassword.Text = Properties.Settings.Default.SJPassword;
        }

        private void sjSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Need to use a new sjEntry for sjEntry properties because sjEntry = sjEntry all the time.
            sjEntry sje = new sjEntry();

            // Save all user settings.
            if (OTFEPassword.Text == "")
            {

            }
            else
            {
                sje.EncryptTextToolStripMenuItem.Enabled = true;
                sje.DecryptTextToolStripMenuItem.Enabled = true;
            }

            Properties.Settings.Default.SJPassword = OTFEPassword.Text;
            Properties.Settings.Default.Save();
        }

        private void DSLBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialogue = new FolderBrowserDialog();
            folderDialogue.ShowNewFolderButton = true;
            if (folderDialogue.ShowDialog() == DialogResult.OK)
            {
                DSLText.Text = folderDialogue.SelectedPath;
            }
        }

        private void WWCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (WWCheckbox.Checked == true)
            {
                Properties.Settings.Default.WordWrap = true;
            }
            else
            {
                Properties.Settings.Default.WordWrap = false;
            }
        }

        private void WTCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (WTCheckBox.Checked == true)
            {
                Properties.Settings.Default.WriteTitle = true;
            }
            else
            {
                Properties.Settings.Default.WriteTitle = false;
            }
        }

        private void OTFECheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (WTCheckBox.Checked == true)
            {
                Properties.Settings.Default.WriteTitle = true;
            }
            else
            {
                Properties.Settings.Default.WriteTitle = false;
            }
        }
    }
}
