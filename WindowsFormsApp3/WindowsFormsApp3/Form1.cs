using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private int counter = 0;
        private int counter1 = 0;
        private int counter2 = 0;
        private int sudahbenar3 = 0;
        private int sudahbenar2 = 0;
        private int sudahbenar1 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

            string nama = txt_nama.Text;
            counter = 0;
            counter1 = 0;
            counter2 = 0;
            for (int i = 0; i < nama.Length; i++)
            {
                if (char.IsLetter(nama[i]) == true)
                {
                    counter++;
                    sudahbenar1 = 1;
                }

            }
            string umur = txt_umur.Text;
            for (int i = 0; i < umur.Length; i++)
            {
                if (char.IsDigit(umur[i]) == true)
                {
                    counter1++;
                    sudahbenar2 = 1;
                }

            }
            string hobby = txt_lainnya.Text;
            for (int i = 0; i < hobby.Length; i++)
            {
                if (char.IsLetter(hobby[i]) == true)
                {
                    counter2++;
                    sudahbenar3 = 1;
                }

            }
            if (counter != nama.Length)
            {
                MessageBox.Show("Hobby bukan string");
            }
            if (counter1 != umur.Length)
            {
                MessageBox.Show("Umur Bukan Integer");
            }
            if (counter2 != hobby.Length)
            {
                MessageBox.Show("Nama Bukan String");
            }
            else
            {
                if (radiobtn_female.Checked == true)
                {
                    if (chck_playingsport.Checked == true)
                    {
                        MessageBox.Show("nama " + nama + Environment.NewLine + "umur: " + umur + Environment.NewLine + "Gender: " + "Female" + Environment.NewLine + "Hobby : Playing Sport");

                    }
                    if (chck_reading.Checked == true)
                    {
                        MessageBox.Show("nama " + nama + Environment.NewLine + "umur: " + umur + Environment.NewLine + "Gender: " + "Female" + Environment.NewLine + "Hobby : Reading");

                    }
                    if (chck_watchingTV.Checked == true)
                    {
                        MessageBox.Show("nama " + nama + Environment.NewLine + "umur: " + umur + Environment.NewLine + "Gender: " + "Female" + Environment.NewLine + "Hobby : Watching TV");
                    }
                    if (chck_lainnya.Checked == true)
                    {
                        MessageBox.Show("nama " + nama + Environment.NewLine + "umur: " + umur + Environment.NewLine + "Gender: " + "Female" + Environment.NewLine + "Hobby :" + hobby);
                    }
                }
                if (radiobtn_male.Checked == true)
                {
                    if (chck_playingsport.Checked == true)
                    {
                        MessageBox.Show("nama " + nama + Environment.NewLine + "umur: " + umur + Environment.NewLine + "Gender: " + "male" + Environment.NewLine + "Hobby : Playing Sport");

                    }
                    if (chck_reading.Checked == true)
                    {
                        MessageBox.Show("nama " + nama + Environment.NewLine + "umur: " + umur + Environment.NewLine + "Gender: " + "male" + Environment.NewLine + "Hobby : Reading");

                    }
                    if (chck_watchingTV.Checked == true)
                    {
                        MessageBox.Show("nama " + nama + Environment.NewLine + "umur: " + umur + Environment.NewLine + "Gender: " + "male" + Environment.NewLine + "Hobby : Watching TV");
                    }
                    if (chck_lainnya.Checked == true)
                    {
                        MessageBox.Show("nama " + nama + Environment.NewLine + "umur: " + umur + Environment.NewLine + "Gender: " + "male" + Environment.NewLine + "Hobby :" + hobby);
                    }
                }
                if (radiobtn_blue.Checked == true)
                {
                    this.BackColor = Color.Blue;
                }
                if (radiobtn_red.Checked == true)
                {
                    this.BackColor = Color.Red;
                }
                if (radiobtn_cyan.Checked == true)
                { this.BackColor = Color.Cyan; }
            }
        }

        private void txt_nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void radiobtn_female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chck_reading_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_lainnya_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_lainnya.Text = "";
            txt_nama.Text= string.Empty;
            txt_umur.Text= string.Empty;
            radiobtn_cyan.Checked= false;
            radiobtn_female.Checked= false;
            radiobtn_male.Checked= false;
            radiobtn_red .Checked= false;
            radiobtn_cyan .Checked= false;
            chck_lainnya.Checked= false;
            chck_playingsport .Checked= false;
            chck_reading.Checked= false;
            chck_watchingTV.Checked= false;
            this.BackColor = Color.White;

        }
    }
}
