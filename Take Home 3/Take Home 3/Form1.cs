using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Take_Home_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label_umur_Click(object sender, EventArgs e)
        {

        }

        private void button_submit(object sender, EventArgs e)
        {
            string namaa = txt_Nama.Text;
            string emaill = txt_email.Text;
            int phonenumber = Convert.ToInt32(txt_phonenumber.Text);
            int age = Convert.ToInt32(txt_umur.Text);
            if (age >= 18)
            {
                MessageBox.Show("Nama : " + namaa + Environment.NewLine + "Email :" + emaill + Environment.NewLine + "Phone number : " + phonenumber + Environment.NewLine + "golongan : adult");
            }
            else
            {
                MessageBox.Show("Nama : " + namaa + Environment.NewLine + "Email :" + emaill + Environment.NewLine + "Phone number : " + phonenumber + Environment.NewLine + "golongan : minor");
            }
        }

        private void btn_clear(object sender, EventArgs e)
        {

            txt_Nama.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_phonenumber.Text = string.Empty;
            txt_umur.Text = string.Empty;
        }
    }
}
