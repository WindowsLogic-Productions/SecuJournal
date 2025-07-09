//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;


namespace SecuJournal
{
    public partial class sjMain : Form
    {
        public sjMain()
        {
            InitializeComponent();
        }

        private void sjMain_Load(object sender, System.EventArgs e)
        {
            if (Properties.Settings.Default.OTFEncryption == true)
            {
                //sjPassword sjp = new sjPassword;
                //sjp.showdialog();
            }
            else
            {

            }


            string root = "C:\\SecuJournal";
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }

        }

        private void NewJournalEntryToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            sjName sjn = new sjName();
            sjn.ShowDialog();
        }

        private void OpenJournalEntryToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            openFileDialog1.InitialDirectory = Properties.Settings.Default.DefaultSaveDirectory;
            openFileDialog1.Title = "Open Journal Entry";
            openFileDialog1.Filter = "SecuJournal Entry|*.sje";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sjEntry openEntry = new sjEntry();
                openEntry.MdiParent = this;
                openEntry.Show();
                openEntry.RichTextBox1.LoadFile(openFileDialog1.FileName);
                openEntry.TextBox1.Text = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void BackupJournalEntriesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog FolderDialogue = new FolderBrowserDialog();
            FolderDialogue.ShowNewFolderButton = true;
            string sourcePath = Properties.Settings.Default.DefaultSaveDirectory;
            string destinationPath;
            if (FolderDialogue.ShowDialog() == DialogResult.OK)
            {
                destinationPath = FolderDialogue.SelectedPath;
                System.Environment.SpecialFolder root = FolderDialogue.RootFolder;
                string newDirectory = System.IO.Path.Combine(destinationPath, Path.GetFileName(Path.GetDirectoryName(sourcePath)));
                if (!Directory.Exists(newDirectory))
                {
                    Directory.CreateDirectory(newDirectory);
                }
                Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(sourcePath, newDirectory);
            }
        }

        private void SettingsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            sjSettings sjs = new sjSettings();
            sjs.ShowDialog();
        }
    }
}
