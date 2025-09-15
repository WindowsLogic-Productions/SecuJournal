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
    public partial class sjPassword : Form
    {
        public sjPassword()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SJPassword == TextBox1.Text)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("You have entered the wrong password for this journal.", "Journal Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
