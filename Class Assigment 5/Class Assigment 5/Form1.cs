using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Assigment_5
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        int count = 0;
        string hometeam = "";
        string awayteam = "";
        public List<string> listtim = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
          
            dt.Columns.Add("Date");
            dt.Columns.Add("Home Team Name");
            dt.Columns.Add("Home Score");
            dt.Columns.Add("Away Score");
            dt.Columns.Add("Away Team Name");
            dataGridView1.DataSource = dt;
            listtim.Add("Boston Celtics");
            listtim.Add("Brooklyn Nets");
            listtim.Add("New York Knicks");
            listtim.Add("Philadelphia 76ers");
            listtim.Add("Toronto Raptors");
            listtim.Add("Chicago Bulls");
            listtim.Add("Cleveland Cavaliers");
            listtim.Add("Detroit Pistons");
            listtim.Add("Indiana Pacers");
            listtim.Add("Milwauke Bucks");
            comboBox1.Items.Add("Boston Celtics");
            comboBox1.Items.Add("Brooklyn Nets");
            comboBox1.Items.Add("New York Knicks");
            comboBox1.Items.Add("Philadelphia 76ers");
            comboBox1.Items.Add("Toronto Raptors");
            comboBox1.Items.Add("Chicago Bulls");
            comboBox1.Items.Add("Cleveland Cavaliers");
            comboBox1.Items.Add("Detroit Pistons");
            comboBox1.Items.Add("Indiana Pacers");
            comboBox1.Items.Add("Milwauke Bucks");
            //
            comboBox2.Items.Add("Boston Celtics");
            comboBox2.Items.Add("Brooklyn Nets");
            comboBox2.Items.Add("New York Knicks");
            comboBox2.Items.Add("Philadelphia 76ers");
            comboBox2.Items.Add("Toronto Raptors");
            comboBox2.Items.Add("Chicago Bulls");
            comboBox2.Items.Add("Cleveland Cavaliers");
            comboBox2.Items.Add("Detroit Pistons");
            comboBox2.Items.Add("Indiana Pacers");
            comboBox2.Items.Add("Milwauke Bucks");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            count = 0;
            count++;
            if(count == 1)
            {
                comboBox2.Items.Clear();
                string namatimyangkepilih = comboBox1.SelectedItem.ToString();
                hometeam = comboBox1.SelectedItem.ToString();
                foreach (string a in listtim)
                {
                    if(namatimyangkepilih != a)
                    {
                        comboBox2.Items.Add(a);
                    }
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            count = 0;
            count++;
            if (count == 1)
            {
                comboBox1.Items.Clear();
                string namatimyangkepilih = comboBox2.SelectedItem.ToString();
                awayteam = comboBox2.SelectedItem.ToString();
                foreach (string a in listtim)
                {
                    if (namatimyangkepilih != a)
                    {
                        comboBox1.Items.Add(a);
                    }
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void btn_match_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString();
            int homescore = Convert.ToInt32(textBox1.Text);
            int awayscore = Convert.ToInt32(textBox2.Text);
            if(textBox1.Text.Length == 0 || textBox1.Text.Length==0)
            {
                MessageBox.Show("HARAP ISI SCORE TERLEBIH DAHULU");
            }
            else
            {
                dt.Rows.Add(date, hometeam, homescore, awayscore, awayteam);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentCell.RowIndex;
            dt.Rows[a].Delete();
        }

        private void btn_team_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.frm1 = this;
            frm2.ShowDialog();
     
        }
    }
}
