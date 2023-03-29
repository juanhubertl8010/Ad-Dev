using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Assigment_5
{
    public partial class Form2 : Form
    {
        public Form1 frm1;
        public Form2()
        {
            InitializeComponent();
        }
        int counter = 0;
        private void button1_Click(object sender, EventArgs e)
        {

          foreach(string a in frm1.listtim)
            {
                if(a==textBox1.Text) 
                {
                    MessageBox.Show("Tim Sudah Ada");
                    counter++;
                }
            }
          if(counter == 0)
            {
                ((Form1)frm1).listtim.Add(textBox1.Text);
            }
          this.Close();
        }
      
    }
}
