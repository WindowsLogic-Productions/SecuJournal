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
    public partial class sjImage : Form
    {
        public sjImage()
        {
            InitializeComponent();
        }

        private void RatioButton169_CheckedChanged(object sender, EventArgs e)
        {
            if (RatioButton169.Checked == true)
            {
                numericUpDownX.Enabled = false;
                numericUpDownY.Enabled = false;
            }
        }

        private void RatioButton43_CheckedChanged(object sender, EventArgs e)
        {
            if (RatioButton43.Checked == true)
            {
                numericUpDownX.Enabled = false;
                numericUpDownY.Enabled = false;
            }
        }

        private void RatioButtonCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (RatioButtonCustom.Checked == true)
            {
                numericUpDownX.Enabled = true;
                numericUpDownY.Enabled = true;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (RatioButton169.Checked == true)
            {
                Properties.Settings.Default.SetImgWidth = 208;
                Properties.Settings.Default.SetImgHeight = 117;
            }
            else if (RatioButton43.Checked == true)
            {
                Properties.Settings.Default.SetImgWidth = 200;
                Properties.Settings.Default.SetImgHeight = 150;
            }
            else
            {
                Properties.Settings.Default.SetImgWidth = Convert.ToInt32(numericUpDownX.Value);
                Properties.Settings.Default.SetImgHeight = Convert.ToInt32(numericUpDownY.Value);
            }
        }
    }
}
