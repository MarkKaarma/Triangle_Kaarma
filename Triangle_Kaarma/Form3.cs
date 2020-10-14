using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_Kaarma
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        
        // Эта большая часть checkBox нужен для того, что при убирании галочки (бокс и/или текстбокс) был недоступен и наоборот.
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Enabled = true;
                checkBox7.Enabled = false;
            }
            else
            {
                textBox1.Enabled = false;
                checkBox7.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.Enabled = true;
                checkBox8.Enabled = false;
            }
            else
            {
                textBox2.Enabled = false;
                checkBox8.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox3.Enabled = true;
                checkBox9.Enabled = false;
            }
            else
            {
                textBox3.Enabled = false;
                checkBox9.Enabled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox4.Enabled = true;
                checkBox10.Enabled = false;
            }
            else
            {
                textBox4.Enabled = false;
                checkBox10.Enabled = true;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                textBox5.Enabled = true;
                checkBox11.Enabled = false;
            }
            else
            {
                textBox5.Enabled = false;
                checkBox11.Enabled = true;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                textBox6.Enabled = true;
                checkBox12.Enabled = false;
            }
            else
            {
                textBox6.Enabled = false;
                checkBox12.Enabled = true;
            }
        }

        
    }
}
