using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using VPKSoft.WinFormsRtfPrint;

namespace SecuJournal
{
    public partial class sjEntry : Form
    {
        private System.Text.UTF8Encoding enc;
        private ICryptoTransform encryptor;
        private ICryptoTransform decryptor;

        private static readonly byte[] KEY_128 = { 42, 1, 52, 67, 231, 13, 94, 101, 123, 6, 0, 12, 32, 91, 4, 111, 31, 70, 21, 141, 123, 142, 234, 82, 95, 129, 187, 162, 12, 55, 98, 23 };
        private static readonly byte[] IV_128 = { 234, 12, 52, 44, 214, 222, 200, 109, 2, 98, 45, 76, 88, 53, 23, 78 };

        public sjEntry()
        {
            InitializeComponent();
        }

        #region Form Movability
        public bool MoveForm;
        public Point MoveForm_MousePosition;

        private void sjEntry_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MoveForm = true;
                MoveForm_MousePosition = e.Location;
            }
        }

        private void sjEntry_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveForm)
            {
                this.Location = new Point(this.Location.X + (e.Location.X - MoveForm_MousePosition.X),
                                           this.Location.Y + (e.Location.Y - MoveForm_MousePosition.Y));
            }
        }

        private void sjEntry_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MoveForm = false;
                this.Cursor = Cursors.Default;
            }
        }
        #endregion
        #region Panel Movability
        public bool MovePanel;
        public Point MovePanel_MousePosition;

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MovePanel = true;
                MovePanel_MousePosition = e.Location;
            }
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MovePanel)
            {
                this.Location = new Point(this.Location.X + (e.Location.X - MovePanel_MousePosition.X),
                                           this.Location.Y + (e.Location.Y - MovePanel_MousePosition.Y));
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MovePanel = false;
                this.Cursor = Cursors.Default;
            }
        }

        #endregion

        private void sjEntry_Load(object sender, EventArgs e)
        {
            // Load  and create encryption key.
            using (RijndaelManaged symmetricKey = new RijndaelManaged())
            {
                symmetricKey.Mode = CipherMode.CBC;

                enc = new UTF8Encoding();
                encryptor = symmetricKey.CreateEncryptor(KEY_128, IV_128);
                decryptor = symmetricKey.CreateDecryptor(KEY_128, IV_128);
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RichTextBox1.Text == "")
            {
                MessageBox.Show("You cannot print a blank document.");
            }
            else
            {
                RichTextBox1.PrintWithDialog();
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel1.Show();
            txtSearchText.Text = RichTextBox1.SelectedText;
        }

        private void UndoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RichTextBox1.Undo();
        }

        private void RedoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RichTextBox1.Redo();
        }

        private void CutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RichTextBox1.Cut();
        }

        private void CopyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RichTextBox1.Copy();
        }

        private void PasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RichTextBox1.Paste();
        }

        private void SelectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RichTextBox1.SelectAll();
        }

        private void InsertPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void InsertDateAndTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EncryptTextToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DecryptTextToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
