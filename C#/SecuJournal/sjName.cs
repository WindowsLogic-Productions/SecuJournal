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
    public partial class sjName : Form
    {
        public sjName()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            var mdiParent = Application.OpenForms.OfType<sjMain>().FirstOrDefault();
            sjMain sjm = new sjMain();
            sjEntry sje = new sjEntry();
            sje.MdiParent = mdiParent;
            sje.Show();

            if (TextBox1.Text == "")
            {
                sje.TextBox1.Text = "New journal entry - " + DateTime.Now.ToString("dd-MM-yyyy");
            }
            else
            {
                sje.TextBox1.Text = TextBox1.Text;
                sje.DateTimePicker1.Text = DateTimePicker1.Text;
            }

            if (Properties.Settings.Default.WriteTitle == true)
            {

            }
            else
            {
                sje.RichTextBox1.Text = sje.TextBox1.Text + " - " + sje.DateTimePicker1.Text;
            }
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
