using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_7
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

        }
        Button[,] kumpulanbutton = new Button[Form1.jumlahbaris, 5];
        string hurufyangkepilih = "";

        int a = 10;
        int b = 10;
        int hurufke = 0; //hurufkeberapada dalam satu baris
        int count = 0; //ngitung sekarang button keberapa
        int bariske = 0;
        string[] text = File.ReadAllLines(@"C:\Users\USER\Downloads\Wordle Word List.txt"); //ngeload file
        int udaenterberapakali = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            string[] pisah = text[0].Split(',');//split kata per kata dengan koma
            int angkayangkepilih = 0;
            Random rnd = new Random();//ngerandom angka buat ngecek kata yang keberapa yang menjadi kunci jawaban
            for (int counter = 0; counter <= 1; counter++)
            {
                angkayangkepilih = rnd.Next(0, 10000);//random angka
            }
            hurufyangkepilih = pisah[angkayangkepilih].ToUpper();//kata yang kepilih
            //MessageBox.Show(pisah[angkayangkepilih]);
            //i kolom j baris
            //b jarak ke bawah
            for (int i = 0; i < Form1.jumlahbaris; i++) //kolom
            {
                for (int j = 0; j < 5; j++) //baris
                {
                    kumpulanbutton[i, j] = new Button();
                    kumpulanbutton[i, j].Location = new Point(a, b);
                    kumpulanbutton[i, j].Size = new Size(50, 50);
                    kumpulanbutton[i, j].Tag = "belum ada";
                    this.Controls.Add(kumpulanbutton[i, j]);
                    a += 60;
                }
                b += 60;
                a = 10;
            }
        }

        private void btn_Q_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            foreach (Button b in kumpulanbutton)
            {
                if (b.Tag == "belum ada" && cumasekali == 0 && hurufke < 5)
                {
                    b.Tag = "sudah ada";
                    b.Text = "Q";
                    cumasekali++;
                    hurufke++;
                    count++;
                }
            }
        }

        private void btn_W_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            foreach (Button b in kumpulanbutton)
            {
                if (b.Tag == "belum ada" && cumasekali == 0 && hurufke < 5)
                {
                    b.Tag = "sudah ada";
                    b.Text = "W";
                    cumasekali++;
                    hurufke++;
                    count++;
                }
            }
        }

        private void btn_E_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            foreach (Button b in kumpulanbutton)
            {
                if (b.Tag == "belum ada" && cumasekali == 0 && hurufke < 5)
                {
                    b.Tag = "sudah ada";
                    b.Text = "E";
                    cumasekali++;
                    hurufke++;
                    count++;
                }
            }
        }

        private void btn_R_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            foreach (Button b in kumpulanbutton)
            {
                if (b.Tag == "belum ada" && cumasekali == 0 && hurufke < 5)
                {
                    b.Tag = "sudah ada";
                    b.Text = "R";
                    cumasekali++;
                    hurufke++;
                    count++;
                }
            }
        }

        private void btn_T_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            foreach (Button b in kumpulanbutton)
            {
                if (b.Tag == "belum ada" && cumasekali == 0 && hurufke < 5)
                {
                    b.Tag = "sudah ada";
                    b.Text = "T";
                    cumasekali++;
                    hurufke++;
                    count++;
                }
            }
        }

        private void btn_Y_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            foreach (Button b in kumpulanbutton)
            {
                if (b.Tag == "belum ada" && cumasekali == 0 && hurufke < 5)
                {
                    b.Tag = "sudah ada";
                    b.Text = "Y";
                    cumasekali++;
                    hurufke++;
                    count++;
                }
            }
        }

        private void btn_U_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            foreach (Button b in kumpulanbutton)
            {
                if (b.Tag == "belum ada" && cumasekali == 0 && hurufke < 5)
                {
                    b.Tag = "sudah ada";
                    b.Text = "U";
                    cumasekali++;
                    hurufke++;
                    count++;
                }
            }
        }

        private void btn_I_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            foreach (Button b in kumpulanbutton)
            {
                if (b.Tag == "belum ada" && cumasekali == 0 && hurufke < 5)
                {
                    b.Tag = "sudah ada";
                    b.Text = "I";
                    cumasekali++;
                    hurufke++;
                    count++;
                }
            }
        }

        private void btn_O_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            foreach (Button b in kumpulanbutton)
            {
                if (b.Tag == "belum ada" && cumasekali == 0 && hurufke < 5)
                {
                    b.Tag = "sudah ada";
                    b.Text = "O";
                    cumasekali++;
                    hurufke++;
                    count++;
                }
            }
        }

        private void btn_P_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            foreach (Button b in kumpulanbutton)
            {
                if (b.Tag == "belum ada" && cumasekali == 0 && hurufke < 5)
                {
                    b.Tag = "sudah ada";
                    b.Text = "P";
                    cumasekali++;
                    hurufke++;
                    count++;
                }
            }
        }

        private void btn_A_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            foreach (Button b in kumpulanbutton)
            {
                if (b.Tag == "belum ada" && cumasekali == 0 && hurufke < 5)
                {
                    b.Tag = "sudah ada";
                    b.Text = "A";
                    cumasekali++;
                    hurufke++;
                    count++;
                }
            }
        }

        private void btn_S_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            foreach (Button b in kumpulanbutton)
            {
                if (b.Tag == "belum ada" && cumasekali == 0 && hurufke < 5)
                {
                    b.Tag = "sudah ada";
                    b.Text = "S";
                    cumasekali++;
                    hurufke++;
                    count++;
                }
            }
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            foreach (Button b in kumpulanbutton)
            {
                if (b.Tag == "belum ada" && cumasekali == 0 && hurufke < 5)
                {
                    b.Tag = "sudah ada";
                    b.Text = "D";
                    cumasekali++;
                    hurufke++;
                    count++;
                }
            }
        }

        private void btn_F_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            foreach (Button b in kumpulanbutton)
            {
                if (b.Tag == "belum ada" && cumasekali == 0 && hurufke < 5)
                {
                    b.Tag = "sudah ada";
                    b.Text = "F";
                    cumasekali++;
                    hurufke++;
                    count++;
                }
            }
        }

        private void btn_G_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            foreach (Button b in kumpulanbutton)
            {
                if (b.Tag == "belum ada" && cumasekali == 0 && hurufke < 5)
                {
                    b.Tag = "sudah ada";
                    b.Text = "G";
                    cumasekali++;
                    hurufke++;
                    count++;
                }
            }
        }

        private void btn_H_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            foreach (Button b in kumpulanbutton)
            {
                if (b.Tag == "belum ada" && cumasekali == 0 && hurufke < 5)
                {
                    b.Tag = "sudah ada";
                    b.Text = "H";
                    cumasekali++;
                    hurufke++; count++;
                }
            }
        }

        private void btn_J_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            foreach (Button b in kumpulanbutton)
            {
                if (b.Tag == "belum ada" && cumasekali == 0 && hurufke < 5)
                {
                    b.Tag = "sudah ada";
                    b.Text = "J";
                    cumasekali++;
                    hurufke++;
                    count++;
                }
            }
        }

        private void btn_K_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            foreach (Button b in kumpulanbutton)
            {
                if (b.Tag == "belum ada" && cumasekali == 0 && hurufke < 5)
                {
                    b.Tag = "sudah ada";
                    b.Text = "K";
                    cumasekali++;
                    hurufke++;
                    count++;
                }
            }
        }

        private void btn_L_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            foreach (Button b in kumpulanbutton)
            {
                if (b.Tag == "belum ada" && cumasekali == 0 && hurufke < 5)
                {
                    b.Tag = "sudah ada";
                    b.Text = "L";
                    cumasekali++;
                    hurufke++;
                    count++;
                }
            }
        }

        private void btn_Z_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            foreach (Button b in kumpulanbutton)
            {
                if (b.Tag == "belum ada" && cumasekali == 0 && hurufke < 5)
                {
                    b.Tag = "sudah ada";
                    b.Text = "Z";
                    cumasekali++;
                    hurufke++;

                    count++;
                }
            }
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            foreach (Button b in kumpulanbutton)
            {
                if (b.Tag == "belum ada" && cumasekali == 0 && hurufke < 5)
                {
                    b.Tag = "sudah ada";
                    b.Text = "X";
                    cumasekali++;
                    hurufke++;
                    count++;
                }
            }
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            foreach (Button b in kumpulanbutton)
            {
                if (b.Tag == "belum ada" && cumasekali == 0 && hurufke < 5)
                {
                    b.Tag = "sudah ada";
                    b.Text = "C";
                    cumasekali++;
                    hurufke++;

                    count++;
                }
            }
        }

        private void btn_V_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            foreach (Button b in kumpulanbutton)
            {
                if (b.Tag == "belum ada" && cumasekali == 0 && hurufke < 5)
                {
                    b.Tag = "sudah ada";
                    b.Text = "V";
                    cumasekali++;
                    hurufke++;
                    count++;
                }
            }
        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            foreach (Button b in kumpulanbutton)
            {
                if (b.Tag == "belum ada" && cumasekali == 0 && hurufke < 5)
                {
                    b.Tag = "sudah ada";
                    b.Text = "B";
                    cumasekali++;
                    hurufke++;
                    count++;
                }
            }
        }

        private void btn_N_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            foreach (Button b in kumpulanbutton)
            {
                if (b.Tag == "belum ada" && cumasekali == 0 && hurufke < 5)
                {
                    b.Tag = "sudah ada";
                    b.Text = "N";
                    cumasekali++;
                    hurufke++; count++;
                }
            }
        }

        private void btn_M_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            foreach (Button b in kumpulanbutton)
            {
                if (b.Tag == "belum ada" && cumasekali == 0 && hurufke < 5)
                {
                    b.Tag = "sudah ada";
                    b.Text = "M";
                    cumasekali++;
                    hurufke++; count++;
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            int tambahhuruf = 0;
            foreach (Button b in kumpulanbutton)
            {
                tambahhuruf++;
                if (tambahhuruf == hurufke+bariske && hurufke>0)
                {
                    b.Tag = "belum ada";
                    b.Text = "";
                    hurufke--;
                }

            }
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            var buttonclick = sender as Button;
            int cumasekali = 0;
            int tambahhuruf = 0;
            string huruff = "";
            int hurufditemukan = 0;
            int ygudahjadiijo = 0;
            List<char> hurufgabungan = new List<char>();
            int sudahada = 0; //ngecek kolom 1 sudah jalan berapa kali
            int sudahada1 = 0; //ngecek kolom 2 sudah jalan berapa kali
            int sudahada2 = 0;//ngecek kolom 3 sudah jalan berapa kali
            int sudahada3 = 0;//ngecek kolom 4 sudah jalan berapa kali
            int sudahada4 = 0;//ngecek kolom 5 sudah jalan berapa kali
      
            //MessageBox.Show(hurufyangkepilih + hurufke);
            if (hurufke == 5)
            {
                udaenterberapakali++;
                //foreach(Button c in kumpulanbutton)
                //{
                //    if(tambahhuruf == 0 + bariske)
                //    {
                //        char huruf = Convert.ToChar(c.Text);
                //        hurufgabungan.Add(huruf);
                //    }
                //    if(tambahhuruf == 1 + bariske)
                //    {
                //        char huruf = Convert.ToChar(c.Text);
                //        hurufgabungan.Add(huruf);
                //    }
                //    if (tambahhuruf == 2 + bariske)
                //    {
                //        char huruf = Convert.ToChar(c.Text);
                //        hurufgabungan.Add(huruf);
                //    }
                //    if (tambahhuruf == 3 + bariske)
                //    {
                //        char huruf = Convert.ToChar(c.Text);
                //        hurufgabungan.Add(huruf);
                //    }
                //    if (tambahhuruf == 4 + bariske)
                //    {
                //        char huruf = Convert.ToChar(c.Text);
                //        hurufgabungan.Add(huruf);
                //    }
                //    tambahhuruf++;
                //}
                //foreach (char n in hurufgabungan)
                //{
                //    huruff = huruff + n.ToString();
                //}
                //for (int i = 0; i < 10000; i++)
                //{
                //    string[] pisah = text[0].Split(',');
                //    if (huruff == pisah[i].ToUpper())
                //    {
                //        hurufditemukan++;
                //    }
                //}
                //if (hurufditemukan == 0)
                //{
                //    MessageBox.Show("Kata tidak Ditemukan");
                //}

                foreach (Button b in kumpulanbutton)//ngecek hijau atau kuning
                    {

                        if (hurufke == 5)
                        {
                            if (tambahhuruf == 0 + bariske)
                            {
                                int COUNT = 0;
                                char huruf = Convert.ToChar(b.Text);
                                b.BackColor = Color.White;
                                foreach (char n in hurufyangkepilih)
                                {

                                    if (n == huruf)
                                    {

                                        if (sudahada == 0)
                                        {
                                            b.BackColor = Color.Green;
                                        ygudahjadiijo++;
                                        }

                                        COUNT++;
                                    }
                                    sudahada++;

                                }
                                if (b.BackColor != Color.Green)
                                {

                                    if (COUNT > 0)
                                    {

                                        b.BackColor = Color.Yellow;
                                    }


                                }
                            }
                            if (tambahhuruf == 1 + bariske)
                            {

                                int COUNT = 0;
                                char huruf = Convert.ToChar(b.Text);
                                b.BackColor = Color.White;
                                foreach (char n in hurufyangkepilih)
                                {

                                    if (n == huruf)
                                    {

                                        if (sudahada1 == 1)
                                        {
                                            b.BackColor = Color.Green;
                                        ygudahjadiijo++;
                                    }

                                        COUNT++;
                                    }
                                    sudahada1++;
                                }
                                if (b.BackColor != Color.Green)
                                {



                                    if (COUNT > 0)
                                    {

                                        b.BackColor = Color.Yellow;
                                    }


                                }
                            }


                            if (tambahhuruf == 2 + bariske)
                            {
                                int COUNT = 0;
                                char huruf = Convert.ToChar(b.Text);
                                b.BackColor = Color.White;
                                foreach (char n in hurufyangkepilih)
                                {

                                    if (n == huruf)
                                    {

                                        if (sudahada2 == 2)
                                        {
                                            b.BackColor = Color.Green;
                                        ygudahjadiijo++;

                                    }

                                        COUNT++;
                                    }
                                    sudahada2++;
                                }
                                if (b.BackColor != Color.Green)
                                {



                                    if (COUNT > 0)
                                    {

                                        b.BackColor = Color.Yellow;
                                    }


                                }
                            }

                            if (tambahhuruf == 3 + bariske)
                            {
                                int COUNT = 0;
                                char huruf = Convert.ToChar(b.Text);
                                b.BackColor = Color.White;
                                foreach (char n in hurufyangkepilih)
                                {

                                    if (n == huruf)
                                    {

                                        if (sudahada3 == 3)
                                        {
                                            b.BackColor = Color.Green;
                                        ygudahjadiijo++;

                                    }

                                        COUNT++;
                                    }
                                    sudahada3++;
                                }
                                if (b.BackColor != Color.Green)
                                {



                                    if (COUNT > 0)
                                    {

                                        b.BackColor = Color.Yellow;
                                    }


                                }
                            }
                            if (tambahhuruf == 4 + bariske)
                            {
                                int COUNT = 0;
                                char huruf = Convert.ToChar(b.Text);
                                b.BackColor = Color.White;
                                foreach (char n in hurufyangkepilih)
                                {

                                    if (n == huruf)
                                    {

                                        if (sudahada4 == 4)
                                        {
                                            b.BackColor = Color.Green;
                                        ygudahjadiijo++;

                                    }
                                        COUNT++;
                                    }
                                    sudahada4++;


                                }
                                if (b.BackColor != Color.Green)
                                {



                                    if (COUNT > 0)
                                    {

                                        b.BackColor = Color.Yellow;
                                    }


                                }
                            }
                            tambahhuruf++;
                        }

                    }

                  

                        hurufke = 0;
                        bariske += 5;
                if (ygudahjadiijo == 5)
                {
                    MessageBox.Show("Selamat Anda Berhasil Memenangkan Game Setan Ini");
                    this.Close();
                }
                else
                {
                    if (udaenterberapakali == Form1.jumlahbaris)
                    {
                        MessageBox.Show("Anda Cupu Sekali");
                        this.Close();
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Masih Belum Lengkap");
                
            }
         }
        }
    }

