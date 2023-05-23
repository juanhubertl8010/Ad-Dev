using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
       MySqlCommand sqlCommand;
       MySqlDataAdapter mySqlDataAdapter;
     MySqlDataReader mySqlDataReader;
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
           string connection = "server=localhost;user=root;pwd=root123456@;database=pos_resto";
            conn = new MySqlConnection(connection);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt.Clear();
            string command = "select username,password from Admin_Pos where username='" + Tb_Username.Text + "' && password='" + Tb_Pass.Text + "';";
            sqlCommand = new MySqlCommand(command, conn);
            mySqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            mySqlDataAdapter.Fill(dt);
            if(dt.Rows.Count ==1 ) 
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }

        }
    }
}
