using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_4
{
    public partial class MainWindow : Form
    {
        public static string txt1 = "";
        public static string txt2 = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txt_nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_openNextForm_Click(object sender, EventArgs e)
        {
            txt1= txt_nama.Text;
            txt2= Txt_MyFavArtist.Text;
            new Form2().ShowDialog();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            txt1 = txt_nama.Text;
            txt2 = Txt_MyFavArtist.Text;
            if (txt1.Length == 0 || txt2.Length == 0)
            {
                MessageBox.Show("harap mengisi nama dan favourite artis terlebih dahulu");
            }
            else
            {
                btn_openNextForm.Enabled = true;
            }
        }

        private void Chck_agreement_CheckedChanged(object sender, EventArgs e)
        {
            if(Chck_agreement.Checked)
            {
                btn_submit.Enabled = true;
            }
            else
            {
                btn_submit.Enabled = false;
            }
        }
    }
}
