using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecuJournal
{
    public partial class sjDate : Form
    {
        public sjDate()
        {
            InitializeComponent();
        }

        private void UCDTButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(DateTime.Now.ToString());
            sjEntry sje = new sjEntry();
            sje.RichTextBox1.Paste();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(DateTimePicker1.Text + " " + DateTimePicker2.Text);
            sjEntry sje = new sjEntry();
            sje.RichTextBox1.Paste();
            this.Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
