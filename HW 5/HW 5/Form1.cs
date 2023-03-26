using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> timlist = new List<string>();
        List <string> playerlist = new List<string>();

        public class playerclass
        {
            private string playername;
            private string playernum;
            private string playerpos;

            public string playernamee { get; set; }
            public string playernumber { get; set; }
            public string playerposition { get; set; }
        }
        public class timclass
        {
            private string timname;
            private string timcountry;
            private string timcity;

            public string timnamee { get; set; }
            public string timcountryy { get; set; }
            public string timcityy { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timlist.Add("England,Manchester United");
            timlist.Add("England,Chelsea");
            timlist.Add("Spain,Barcelona");
           playerlist.Add("(1)" + " De Gea," + "GK" + ";Manchester United");
            playerlist.Add("(2)" + " Dalot," + "DF" + ";Manchester United");
            playerlist.Add("(3)" + " Martinez," + "DF" + ";Manchester United");
            playerlist.Add("(4)" + " Luke Shaw," + "DF" + ";Manchester United");
            playerlist.Add("(5)" + " Varane," + "DF" + ";Manchester United");
            playerlist.Add("(6)" + " Casemiro," + "CMF" + ";Manchester United");
            playerlist.Add("(7)" + " Ericksen," + "CMF" + ";Manchester United");
            playerlist.Add("(8)" + " Bruno Fernandez," + "CMF" + ";Manchester United");
            playerlist.Add("(9)" + " Sancho," + "ST" + ";Manchester United");
            playerlist.Add("(10)" + " Rashford," + "ST" + ";Manchester United");
            playerlist.Add("(11)" + " Martial," + "ST" + ";Manchester United");
            playerlist.Add("(1)" + " Kepa," + "GK" + ";Chelsea");
            playerlist.Add("(2)" + " Fofana," + "DF" + ";Chelsea");
            playerlist.Add("(3)" + " Koulibaly," + "DF" + ";Chelsea");
            playerlist.Add("(4)" + " Badiashile," + "DF" + ";Chelsea");
            playerlist.Add("(5)" + " Reece James," + "CMF" + ";Chelsea");
            playerlist.Add("(6)" + " Enzo Fernandez," + "CMF" + ";Chelsea");
            playerlist.Add("(7)" + " Kovacic," + "CMF" + ";Chelsea");
            playerlist.Add("(8)" + " Chillwell," + "CMF" + ";Chelsea");
            playerlist.Add("(9)" + " Harvest," + "ST" + ";Chelsea");
            playerlist.Add("(10)" + " Pulisic," + "ST" + ";Chelsea");
            playerlist.Add("(11)" + " Jao Felix," + "ST" + ";Chelsea");
            playerlist.Add("(1)" + " Ter Stegen," + "GK" +";Barcelona");
            playerlist.Add("(2)" + " Kounde," + "DF" + ";Barcelona");
            playerlist.Add("(3)" + " Araujo," + "DF" + ";Barcelona");
            playerlist.Add("(4)" + " Balde," + "DF" + ";Barcelona");
            playerlist.Add("(5)" + " Cristensen," + "CMF" + ";Barcelona");
            playerlist.Add("(6)" + " Sergio Roberto," + "CMF" + ";Barcelona");
            playerlist.Add("(7)" + " Sergio Busquest," + "CMF" + ";Barcelona");
            playerlist.Add("(8)" + " De Jong," + "CMF" + ";Barcelona");
            playerlist.Add("(9)" + " Gavi," + "ST" + ";Barcelona");
            playerlist.Add("(10)" + " Pedri," + "ST" + ";Barcelona");
            playerlist.Add("(11)" + " Lewandoski," + "ST" + ";Barcelona");

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int counter = 0;
            if (txt_nameee.Text == string.Empty || txt_position.Text == string.Empty || txt_number.Text == string.Empty)
            {
                MessageBox.Show("Harap diisi dulu woi");
            }
            else
            {
                string timyangdipilih1 = cmb_team.SelectedItem.ToString();
                foreach (string n in playerlist)
                {
                    string[] timyangdiklik = n.Split(';');
                    if (timyangdiklik[1] == timyangdipilih1)
                    {
                        if (timyangdiklik[0] == "(" + txt_number.Text + ")" + " " + txt_nameee.Text + "," + txt_position.Text)
                        {
                            MessageBox.Show("Ada Nama Pemain yang sama");
                            counter++;
                        }

                    }

                }
                if (counter == 0)
                {
                    playerlist.Add("(" + txt_number.Text + ")" + " " + txt_nameee.Text + "," + txt_position.Text + ";" + timyangdipilih1);
                    listBox1.Items.Add("(" + txt_number.Text + ")" + " " + txt_nameee.Text + "," + txt_position.Text);
                }
            }
        }

        private void cmb_choosecontry_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_team.Items.Clear();
            string negarayangdipilih = cmb_choosecontry.SelectedItem.ToString();
            foreach (string n in timlist)
            {
                string[] pisahtim = n.Split(',');
                if (pisahtim[0] == negarayangdipilih)
                {
                    cmb_team.Items.Add(pisahtim[1]);
                }
            }
           



        }

        private void cmb_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            string timyangdipilih = cmb_team.SelectedItem.ToString();
            listBox1.Items.Clear();
        
       
            foreach (string n in playerlist)
            {
                string[]timyangdiklik = n.Split(';');
                if (timyangdiklik[1]==timyangdipilih)
                {
                    listBox1.Items.Add(timyangdiklik[0]);
                }
            }
            
        }

        private void btn_addteam_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == string.Empty || txt_country.Text == string.Empty || txt_city.Text == string.Empty)
            {
                MessageBox.Show("Harap diisi dulu woi");
            }
            else
            {
                int count = 0;

                foreach (var n in timlist.ToList())
                {
                    string[] namatim = n.Split(',');
                    if (namatim[1] == txt_name.Text)
                    {
                        MessageBox.Show("Tim sudah ada");
                        count++;
                    }

                }
                if (count == 0)
                {
                    if (cmb_choosecontry.Items.Contains(txt_country.Text) == false && cmb_team.Items.Contains(txt_name) == false && count == 0)
                    {
                        cmb_choosecontry.Items.Add(txt_country.Text);
                        cmb_team.Items.Add(txt_name.Text);
                        timlist.Add(txt_country.Text + "," + txt_name.Text);
                        count++;

                    }
                    if (cmb_choosecontry.Items.Contains(txt_country.Text) == true && cmb_team.Items.Contains(txt_name) == false && count == 0)
                    {
                        cmb_team.Items.Add(txt_name.Text);
                        timlist.Add(txt_country.Text + "," + txt_name.Text);
                        count++;

                    }

                }
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count <12)
            {
                MessageBox.Show("Pemain ga bisa dikurangi lagi");
            }
            else
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }
    }
    }

