using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using VPKSoft.WinFormsRtfPrint;
using System.IO;

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
        #region Window Controls
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaximiseButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized == true)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void MinimiseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region Load Settings
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
        #endregion
        #region Title Right-click Menu
        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TextBox1.Cut();
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            TextBox1.Copy();
        }

        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            TextBox1.Paste();
        }

        private void ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            TextBox1.SelectAll();
        }
        #endregion
        #region Right-click Menu
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
            OpenFileDialog openImage = new OpenFileDialog();
            openImage.Filter = "Image Files|*.jpg;*.jpeg;*.gif;*.png;*.tiff;*.bmp";
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                sjImage sji = new sjImage();
                sji.ShowDialog();
                Image img = Image.FromFile(openImage.FileName);
                Bitmap bmp = new Bitmap(Properties.Settings.Default.SetImgWidth, Properties.Settings.Default.SetImgHeight);
                Graphics grphcs = Graphics.FromImage(bmp);
                grphcs.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), new Rectangle(0, 0, img.Width, img.Height), GraphicsUnit.Pixel);
                Clipboard.SetImage(bmp);
                RichTextBox1.Paste();
                grphcs.Dispose();
                bmp.Dispose();
                img.Dispose();
            }
        }

        private void InsertDateAndTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sjDate sjd = new sjDate();
            sjd.ShowDialog();
        }

        private void EncryptTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sPlainText = this.RichTextBox1.SelectedText;
            if (!string.IsNullOrEmpty(sPlainText))
            {
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, this.encryptor, CryptoStreamMode.Write);
                cryptoStream.Write(this.enc.GetBytes(sPlainText), 0, sPlainText.Length);
                cryptoStream.FlushFinalBlock();
                this.RichTextBox1.SelectedText = Convert.ToBase64String(memoryStream.ToArray());
                memoryStream.Close();
                cryptoStream.Close();
            }
        }

        private void DecryptTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] cypherTextBytes = Convert.FromBase64String(this.RichTextBox1
.Text);
                MemoryStream memoryStream = new MemoryStream(cypherTextBytes);
                CryptoStream cryptoStream = new CryptoStream(memoryStream, this.decryptor, CryptoStreamMode.Read);
                byte[] plainTextBytes = new byte[cypherTextBytes.Length];
                int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                memoryStream.Close();
                cryptoStream.Close();
                this.RichTextBox1.Text = this.enc.GetString(plainTextBytes, 0, decryptedByteCount);
            }
            catch (Exception)
            {
                MessageBox.Show("Text is already decrypted.");
            }
        }
        #endregion

        
    }
}
