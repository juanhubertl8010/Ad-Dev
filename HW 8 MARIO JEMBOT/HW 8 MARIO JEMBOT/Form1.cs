using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_8_MARIO_JEMBOT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] text = File.ReadAllLines(@"C:\Users\USER\Downloads\Movie.txt");
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] pisah = text[0].Split(',');
            label1.Text = pisah[0];
            label2.Text = pisah[1];
            label3.Text = pisah[2];
            label4.Text = pisah[3];
            label5.Text = pisah[4];
            label6.Text = pisah[5];
            label7.Text = pisah[6];
            label8.Text = pisah[7];
           
        }
    }
}
