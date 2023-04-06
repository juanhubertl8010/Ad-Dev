using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_7
{
    public partial class Form1 : Form
    {
        public static int jumlahbaris = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            //ngecek apakah textboxnya ada string atau engga
            int length_tb_tanayberapabaris = Convert.ToInt32(tb_tanyaberapabaris.Text.Length); //ngecek banyak huruf di tb tersebut
            int adahuruf = 0; //ngecek apakah di tbnya ada huruf apa ga
            for (int i = 0; i<length_tb_tanayberapabaris; i++) 
            {
                if (char.IsDigit(tb_tanyaberapabaris.Text[i]) ==false)
                {
                    adahuruf++;
                }
            }
            if(adahuruf >0) //kalo adahuruf lebih dari 0 berarti di tbnya ada huruf
            {
                MessageBox.Show("Textbox ada huruf tolong isi ulang dengan benar"); //message error soalnya ada huruf
                tb_tanyaberapabaris.Text = string.Empty;
            }
            else //kalo tbnya ga ada huruf sama sekali
            {
                jumlahbaris = Convert.ToInt32(tb_tanyaberapabaris.Text); 
                if(jumlahbaris <3)
                {
                    MessageBox.Show("Angka kurang dari 3"); //message error soalnya angkanya kurang dari 3
                }
                else
                {
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                }
            }
            

        }
    }
}
