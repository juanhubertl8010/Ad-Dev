using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_4
{
    public partial class Form2 : Form
    {
        private int counter = 0;
        private int backcolor = 0;
        private int txtcolor = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void label_pickbackcolor_Click(object sender, EventArgs e)
        {

        }
        private void lbl_Hi_Click(object sender, EventArgs e)
        {
            
        }

        private void rdio_yellow_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Hi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_Hi.Text = "hi my name is " + MainWindow.txt1 + " and my favourite artist is " + MainWindow.txt2;
        }

        private void chck_agree2_CheckedChanged(object sender, EventArgs e)
        {
            if (chck_agree2.Checked)
            {
                counter++;
            }
            if(counter==2)
            {
                button_magic.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked) 
            {
                counter++;
            }
            if (counter == 2)
            {
                button_magic.Enabled = true;
            }
        }

        private void button_magic_Click(object sender, EventArgs e)
        {
            if (backcolor == 0 || txtcolor == 0)
            {
                MessageBox.Show("harap mengklik radio buttonn pada background color dan text color terlebih dahulu");
            }
            else
            {
                if (rdio_yellow.Checked)
                {
                    this.BackColor = Color.Yellow;
                }
                if (rdio_red.Checked)
                {
                    this.BackColor = Color.Red;
                }
                if (rdio_Cyan.Checked)
                { this.BackColor = Color.Cyan; }
                if (rdio_green.Checked)
                { this.BackColor = Color.Green; }
                if (rdio_blue.Checked) { this.BackColor = Color.Blue; }
                if (rdio_grey.Checked)
                {
                    this.ForeColor = Color.Gray;
                }
                if (rdio_White.Checked)
                {
                    this.ForeColor = Color.White;
                }
                if (rdio_black.Checked)
                { this.ForeColor = Color.Black; }
            }
        }

        private void rdio_yellow_CheckedChanged_1(object sender, EventArgs e)
        {
            backcolor++;
        }

        private void rdio_red_CheckedChanged(object sender, EventArgs e)
        {
            backcolor++;
        }

        private void rdio_blue_CheckedChanged(object sender, EventArgs e)
        {
            backcolor++;
        }

        private void rdio_green_CheckedChanged(object sender, EventArgs e)
        {
            backcolor++;
        }

        private void rdio_Cyan_CheckedChanged(object sender, EventArgs e)
        {
            backcolor++;
        }

        private void rdio_black_CheckedChanged(object sender, EventArgs e)
        {
            txtcolor++;
        }

        private void rdio_grey_CheckedChanged(object sender, EventArgs e)
        {
            txtcolor++;
        }

        private void rdio_White_CheckedChanged(object sender, EventArgs e)
        {
            txtcolor++;
        }
    }
}
