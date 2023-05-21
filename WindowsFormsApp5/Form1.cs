using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        MySqlConnection SqlConnect;
        MySqlCommand SqlCommand;
        MySqlDataAdapter SqlDataAdapter;
        MySqlDataReader SqlDataReader;
        DataTable dy = new DataTable();
        DataTable dt = new DataTable();
        DataTable dr = new DataTable();
        DataTable dx = new DataTable();
        DataTable dk = new DataTable();
        DataTable dz = new DataTable();
        DataTable dc = new DataTable();
        DataTable dh = new DataTable();
        public Form1()
        {
            InitializeComponent();
            string connection = "server=localhost;uid=root;pwd=root123456@;database=premier_league";
            SqlConnect = new MySqlConnection(connection);

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            isicombobox();
            isicombotimbuateditmanager();
            comboisitimbuatdelete();
        }

        private void isicombobox()
        {
            string command = "select nation, nationality_id from nationality;";
            SqlCommand = new MySqlCommand(command, SqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(dy);
            comboBox1.DataSource = dy;
            comboBox1.DisplayMember = "nation";
            comboBox1.ValueMember = "nationality_id";


        }
        private void isicombotimbuateditmanager()
        {
            string command = "select team_name, team_id from team;";
            SqlCommand = new MySqlCommand(command, SqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(dx);
            comboBox3.DataSource = dx;
            comboBox3.DisplayMember = "team_name";
            comboBox3.ValueMember = "team_id";
        }
        private void isicombotim()
        {
            string command = "select team_name, team_id from team;";
            SqlCommand = new MySqlCommand(command, SqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(dr);
            comboBox2.DataSource = dr;
            comboBox2.DisplayMember = "team_name";
            comboBox2.ValueMember = "team_id";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Clear();
            string isicombobox = comboBox1.SelectedValue.ToString();
            string command = "select * from player where player.nationality_id = '" + isicombobox + "';";
            SqlCommand = new MySqlCommand(command, SqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dr.Clear();
            isicombotim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string playerid = textBox1.Text;
            string name = textBox2.Text;
            string timnumber = textBox3.Text;
            string position = textBox4.Text;
            string height = textBox5.Text;
            string weight = textBox6.Text;
            string birthdate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string nationalityid = comboBox1.SelectedValue.ToString();
            string timid = comboBox2.SelectedValue.ToString();

            string command = $"insert into player values ('{playerid}','{timnumber}', '{name}', '{nationalityid}', '{position}', '{height}', '{weight}', '{birthdate}', '{timid}',1,0);";
            try
            {
                SqlConnect.Open();
                SqlCommand = new MySqlCommand(command, SqlConnect);
                SqlDataReader = SqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlConnect.Close();
                dt.Clear();
                string isicombobox = comboBox1.SelectedValue.ToString();
                string commmand = "select * from player where player.nationality_id = '" + isicombobox + "';";
                SqlCommand = new MySqlCommand(commmand, SqlConnect);
                SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
                SqlDataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            dk.Clear();
            string timdipilih = comboBox3.SelectedValue.ToString();
            string command = "select m.manager_name as Manager_Name, m.birthdate as Birthdate, n.nation as Nation\r\nfrom manager m, team t, nationality n\r\nwhere n.nationality_id = m.nationality_id && t.manager_id = m.manager_id && t.team_id = '" + timdipilih + "';";
            SqlCommand = new MySqlCommand(command, SqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(dk);
            dataGridView2.DataSource = dk;
            managernganggur();

        }
        private void managernganggur()
        {
            dz.Clear();
            string command = "select m.manager_name as \"Name\", m.birthdate as \"Birthdate\", n.nation as \"Nation\"\r\nfrom manager m, nationality n\r\nwhere n.nationality_id = m.nationality_id && m.working = 0;";
            SqlCommand = new MySqlCommand(command, SqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(dz);
            dataGridView3.DataSource = dz;
        }

        private void managerharusdianggurin()
        {
            string manageryangdianggurin = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            string command = "update manager set `working` = 0 where manager_name ='" + manageryangdianggurin + "';";
            try
            {
                SqlConnect.Open();
                SqlCommand = new MySqlCommand(command, SqlConnect);
                SqlDataReader = SqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlConnect.Close();
                //dz.Clear();
                //string commmand = "select m.manager_name as \"Name\", m.birthdate as \"Birthdate\", n.nation as \"Nation\"\r\nfrom manager m, nationality n\r\nwhere n.nationality_id = m.nationality_id && m.working = 0;";
                //SqlCommand = new MySqlCommand(commmand, SqlConnect);
                //SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
                //SqlDataAdapter.Fill(dz);
                //dataGridView3.DataSource = dz;
            }
        }

        //tinggal manager timnya diganti
        private void penggantianmanager()
        {
            managerharusdianggurin();
            string managermaunganggur = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            string timidmanager = comboBox3.SelectedValue.ToString();
            string command = "update team set `manager_id` = (select manager_id from manager where manager_name = '" + managermaunganggur + "') where team_id ='" + timidmanager + "';";
            try
            {
                SqlConnect.Open();
                SqlCommand = new MySqlCommand(command, SqlConnect);
                SqlDataReader = SqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlConnect.Close();
                dk.Clear();
                string commmand = "select m.manager_name as Manager_Name, m.birthdate as Birthdate, n.nation as Nation\r\nfrom manager m, team t, nationality n\r\nwhere n.nationality_id = m.nationality_id && t.manager_id = m.manager_id && t.team_id = '" + timidmanager + "';";
                SqlCommand = new MySqlCommand(commmand, SqlConnect);
                SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
                SqlDataAdapter.Fill(dk);
                dataGridView2.DataSource = dk;
            }
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            penggantianmanager();
           // managerharusdianggurin();

            string manageryangdianggurin = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            string manageryangdiklik = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            string command = "\r\nupdate manager set `working` = 1\r\nwhere manager_name ='" + manageryangdianggurin + "';";
            try
            {
                SqlConnect.Open();
                SqlCommand = new MySqlCommand(command, SqlConnect);
                SqlDataReader = SqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlConnect.Close();
                dz.Clear();
                string commmand = "select m.manager_name as \"Name\", m.birthdate as \"Birthdate\", n.nation as \"Nation\"\r\nfrom manager m, nationality n\r\nwhere n.nationality_id = m.nationality_id && m.working = 0;";
                SqlCommand = new MySqlCommand(commmand, SqlConnect);
                SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
                SqlDataAdapter.Fill(dz);
                dataGridView3.DataSource = dz;

            }



        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboisitimbuatdelete()
        {
            string command = "select team_name, team_id from team;";
            SqlCommand = new MySqlCommand(command, SqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(dc);
            comboBox4.DataSource = dc;
            comboBox4.DisplayMember = "team_name";
            comboBox4.ValueMember = "team_id";
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            dh.Clear();
            string ygdipilih = comboBox4.Text;
            string command = "select p.player_name as \"Name\", n.nation as \"Nation\", p.playing_pos as \"Position\", p.team_number as \"Number\", p.height, p.weight, p.birthdate\r\nfrom player p, team t, nationality n\r\nwhere n.nationality_id = p.nationality_id and p.team_id = t.team_id and t.team_name ='" + ygdipilih + "'and p.status = 1;";
            SqlCommand = new MySqlCommand(command, SqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(dh);
            dataGridView4.DataSource = dh;
        }

        private void pemainbuangan()
        {
            string namapemain = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            string command = "update player set `status` = 0 where player_name = '" + namapemain + "';";
            try
            {
                SqlConnect.Open();
                SqlCommand = new MySqlCommand(command, SqlConnect);
                SqlDataReader = SqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlConnect.Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int jumlahrow = dataGridView4.Rows.Count;
            if(jumlahrow <=12)
            {
                MessageBox.Show("Tidak bisa remove player lagi");
            }
            else
            {
                pemainbuangan();
                dh.Clear();
                string ygdipilih = comboBox4.Text;
                string command = "select p.player_name as \"Name\", n.nation as \"Nation\", p.playing_pos as \"Position\", p.team_number as \"Number\", p.height, p.weight, p.birthdate\r\nfrom player p, team t, nationality n\r\nwhere n.nationality_id = p.nationality_id and p.team_id = t.team_id and t.team_name ='" + ygdipilih + "'and p.status = 1;";
                SqlCommand = new MySqlCommand(command, SqlConnect);
                SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
                SqlDataAdapter.Fill(dh);
                dataGridView4.DataSource = dh;
            }
        }
    }
}
