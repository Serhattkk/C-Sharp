using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hmm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                progressBar1.Value = 20;
                checkBox2.Enabled = true;
            }
            else
            {
                progressBar1.Value = 0;
                checkBox2.Enabled = false;
            }


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                progressBar1.Value = 40;
                checkBox3.Enabled = true;
            }
            else 
            {
                progressBar1.Value = 20;
                checkBox3.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                progressBar1.Value = 60;
                checkBox4.Enabled = true;
            }
            else
            {
                progressBar1.Value = 40;
                checkBox4.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                progressBar1.Value = 80;
                checkBox5.Enabled = true;
            }
            else
            {
                progressBar1.Value = 60;
                checkBox5.Enabled = false;
            }

            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                progressBar1.Value = 100;
            }
            else
            {
                
                progressBar1.Value = 80;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
