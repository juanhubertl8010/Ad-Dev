using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp6
{
    public partial class Form2 : Form
    {
        MySqlConnection conn;
        MySqlCommand sqlCommand;
        MySqlDataAdapter mySqlDataAdapter;
        MySqlDataReader mySqlDataReader;
        DataTable dy = new DataTable();
        DataTable namacost = new DataTable();
        DataTable dn = new DataTable();
        DataTable transpel = new DataTable();
        DataTable ordertiappesanan =new DataTable();
        public Form2()
        {
            InitializeComponent();
            string connection = "server=localhost;user=root;pwd=root123456@;database=pos_resto";
            conn = new MySqlConnection(connection);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            dy.Clear();
            string command = "select nama from pelanggan where nama = '" + textBox1.Text + "';";
            sqlCommand = new MySqlCommand(command, conn);
            mySqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            mySqlDataAdapter.Fill(dy);
            if(dy.Rows.Count == 0)
            {
                MessageBox.Show("Pelanggan Tidak Ditemukan");
            }
            else
            {
                namacost.Clear();
                string commmand = " select pelanggan_id as ID, nama as Nama, alamat as Alamat, telepon as Telp, email as Email from pelanggan where nama = '" + textBox1.Text + "' and status=1;";
                sqlCommand = new MySqlCommand(commmand, conn);
                mySqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                mySqlDataAdapter.Fill(namacost);
                dataGridView1.DataSource = namacost;
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                label5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                label8.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                transpel.Clear();
                string commmmmand = "select transaksi_pelanggan_id as \"ID Transaksi\" , pesanan_id as \"ID Pesanan\", waktu_transaksi as \"Waktu\" from transaksi_pelanggan \r\nwhere pelanggan_id = '" + label8.Text + "';";
                sqlCommand = new MySqlCommand(commmmmand, conn);
                mySqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                mySqlDataAdapter.Fill(transpel);
                dataGridView2.DataSource = transpel;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            dn.Clear();
            textBox1.Text = "Costumer";
            string command = "select * from pelanggan";
            sqlCommand = new MySqlCommand(command, conn);
            mySqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            mySqlDataAdapter.Fill(dn);
            int rows = dn.Rows.Count;
           int rowsplus1 = rows + 1;
            string nama = textBox2.Text;
            string alamat = textBox3.Text;
            string telepon = textBox4.Text;
            string email = textBox5.Text;
            string id = "PLG0" + rowsplus1.ToString();
       

            string commmand = $"insert into pelanggan values ('{id}', '{nama}', '{email}', '{telepon}', '{alamat}');";
            try
            {
                conn.Open();
                sqlCommand = new MySqlCommand(commmand, conn);
                mySqlDataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                namacost.Clear();
                string commmmand = " select pelanggan_id as ID, nama as Nama, alamat as Alamat, telepon as Telp, email as Email from pelanggan where nama = '" + textBox2.Text + "' and status = 1;";
                sqlCommand = new MySqlCommand(commmmand, conn);
                mySqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                mySqlDataAdapter.Fill(namacost);
                dataGridView1.DataSource = namacost;
            }
            label5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label8.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            transpel.Clear();
            string commmmmand = "select transaksi_pelanggan_id as \"ID Transaksi\" , pesanan_id as \"ID Pesanan\", waktu_transaksi as \"Waktu\" from transaksi_pelanggan \r\nwhere pelanggan_id = '" + label8.Text + "';";
            sqlCommand = new MySqlCommand(commmmmand, conn);
            mySqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            mySqlDataAdapter.Fill(transpel);
            dataGridView2.DataSource = transpel;
        }



        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ordertiappesanan.Clear();
            string pesananid = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            string comand = "select d.jumlah as Jumlah, m.nama_menu as \"Nama Menu\", d.harga as \"Harga\"\r\nfrom detail_pesanan d, menu m\r\nwhere m.menu_id = d.menu_id && d.pesanan_id ='" + pesananid + "';";
            sqlCommand = new MySqlCommand(comand, conn);
            mySqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            mySqlDataAdapter.Fill(ordertiappesanan);
            dataGridView3.DataSource = ordertiappesanan;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string pelangganid = label8.Text;
            string command = "update pelanggan set `status` = 0 where pelanggan_id = '"+pelangganid+"';";
            try
            {
                conn.Open();
                sqlCommand = new MySqlCommand(command, conn);
                mySqlDataReader = sqlCommand.ExecuteReader();

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                namacost.Clear();
                string commmand = " select pelanggan_id as ID, nama as Nama, alamat as Alamat, telepon as Telp, email as Email from pelanggan where nama = '" + textBox1.Text + "' and status=1;";
                sqlCommand = new MySqlCommand(commmand, conn);
                mySqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                mySqlDataAdapter.Fill(namacost);
                label5.Text = "Nama";
                label8.Text = "Id";
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;
                textBox5.Text= string.Empty;
                textBox1.Text = "Costumer";
                transpel.Clear();
                ordertiappesanan.Clear();


            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string namabaru = textBox2.Text;
            string alamatbaru = textBox3.Text;
            string teleponbaru = textBox4.Text;
            string emailbaru = textBox5.Text;
            string idpelanggan = label8.Text;

            string command = "update pelanggan set `nama` = '" + namabaru + "', `alamat` ='" + alamatbaru + "' , `telepon` ='" + teleponbaru + "', `email` ='" + emailbaru + "' where pelanggan_id ='" + idpelanggan + "';";
            try
            {
                conn.Open();
                sqlCommand = new MySqlCommand(command, conn);
                mySqlDataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                namacost.Clear();
                string commmand = " select pelanggan_id as ID, nama as Nama, alamat as Alamat, telepon as Telp, email as Email from pelanggan where nama = '" + textBox1.Text + "' and status=1;";
                sqlCommand = new MySqlCommand(commmand, conn);
                mySqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                mySqlDataAdapter.Fill(namacost);
            }
        }
    }
}
