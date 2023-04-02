using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();//category
        DataTable dy = new DataTable();//produk
        int count = 5;
        int ketemu = 0;
        List<string> listcategory = new List<string>();
        List<string> listproduk = new List<string>();
        List<string> idprodukbarang = new List<string>();
        List<string>idprodukbarangdanangka = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            dy.Rows.Clear();
            Cmb_filter.Text = string.Empty;
            //foreach (string n in idprodukbarang.ToList())
            //{
            //    idprodukbarang.Remove(n);
            //}
            foreach (string produk in listproduk)
            {
                string[] splitproduk = produk.Split(',');
                string idproduk = splitproduk[4];


                //ketemu = 0;
                //idprodukbarang.Add(idproduk);
                //foreach (string id in idprodukbarang)
                //{
                //    if (id == idproduk)
                //    {
                //        ketemu++;
                //    }

                //}
                dy.Rows.Add(idproduk , splitproduk[0], splitproduk[1], splitproduk[2], "C" + splitproduk[3]);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID Cat");
            dt.Columns.Add("Nama Category");
            dgv_category.DataSource = dt;
            listcategory.Add("Jas," + 1);
            listcategory.Add("T-Shirt," + 2);
            listcategory.Add("Rok," + 3);
            listcategory.Add("Celana," + 4);
            listcategory.Add("Cawat," + 5);
            foreach (string category in listcategory) //masukin ke dgvcat
            {
                string[] namacat = category.Split(',');
                dt.Rows.Add("C" + namacat[1], namacat[0]);
            }
            foreach (string category in listcategory) //masukan ke cmb category
            {
                string[] namecat = category.Split(',');
                cmb_category.Items.Add(namecat[0]);
            }
            ///////
            dy.Columns.Add("ID Product");
            dy.Columns.Add("Nama Product");
            dy.Columns.Add("Harga");
            dy.Columns.Add("Stock");
            dy.Columns.Add("ID Category");
            dgv_product.DataSource = dy;
            listproduk.Add("Jas Hitam," + 10000 + "," + 10 + "," + 1+",J001");
            listproduk.Add("T-Shirt BlackPink," + 70000 + "," + 20 + "," + 2+",T001");
            listproduk.Add("T-Shirt Obsessive," + 75000 + "," + 20 + "," + 2+",T002");
            listproduk.Add("Rok Mini," + 82000 + "," + 26 + "," + 3+",R001");
            listproduk.Add("Jeans Biru," + 90000 + "," + 5 + "," + 4+",J002");
            listproduk.Add("Celana Pendek Coklat," + 60000 + "," + 11 + "," + 4+",C001");
            listproduk.Add("Cawat Blink-Blink," + 1000000 + "," + 1 + "," + 5+",C002");
            listproduk.Add("Rocca Shirt," + 50000 + "," + 8 + "," + 2+",R002");

            foreach (string produk in listproduk)
            {
                string[] splitproduk = produk.Split(',');
                string idproduk = splitproduk[4];
                //idprodukbarang.Add(idproduk);
                //ketemu = 0;
                //foreach (string id in idprodukbarang)
                //{
                //    if (id == idproduk)
                //    {
                //        ketemu++;
                //    }
                //}
                dy.Rows.Add(idproduk, splitproduk[0], splitproduk[1], splitproduk[2], "C" + splitproduk[3]);
                idprodukbarang.Add(idproduk);
            }
        }

        private void btn_addcategory_Click(object sender, EventArgs e)
        {
            int ada = 0;
            foreach (string category in listcategory) //ngecek apakah categorynya ada apa gak
            {
                string[] namacategory = category.Split(',');
                if (namacategory[0] == txt_namacategory.Text)
                {
                    ada++;
                }
            }
            if (ada == 0)
            {
                count++; //biar c nya nambah
                listcategory.Add(txt_namacategory.Text + "," + count);
                dt.Rows.Clear();
                cmb_category.Items.Clear();
                Cmb_filter.Items.Clear();
                foreach (string category in listcategory) //masukin add category
                {
                    string[] namacat = category.Split(',');
                    dt.Rows.Add("C" + namacat[1], namacat[0]);
                    Cmb_filter.Items.Add(namacat[0]);
                    cmb_category.Items.Add(namacat[0]);
                }
            }
            else
            {
                MessageBox.Show("Category Sudah Ada");
            }
        }

        private void btn_removecategory_Click(object sender, EventArgs e)
        {
            int a = dgv_category.CurrentCell.RowIndex;
            string kode = dgv_category.Rows[a].Cells[0].Value.ToString();
            string ambilangkakode = kode.Substring(1, 1);
            dt.Rows[a].Delete();
            listcategory.RemoveAt(a);
            cmb_category.Items.Clear();
            Cmb_filter.Items.Clear();
            foreach (string category in listcategory) //masukin add category
            {
                string[] namacat = category.Split(',');
                Cmb_filter.Items.Add(namacat[0]);
                cmb_category.Items.Add(namacat[0]);
            }
            //if (Cmb_filter.Text == string.Empty)
            //{
            Cmb_filter.Text = string.Empty;
                dy.Rows.Clear();
                foreach (string n in idprodukbarang.ToList())
                {
                    idprodukbarang.Remove(n);
                }
                foreach (string produk in listproduk.ToList())
                {
                    string[] splitproduk = produk.Split(',');
                    string idproduk = splitproduk[4];


                    //ketemu = 0;
                    //idprodukbarang.Add(idproduk);
                    //foreach (string id in idprodukbarang)
                    //{
                    //    if (id == idproduk)
                    //    {
                    //        ketemu++;
                    //    }

                    //}
                    if (ambilangkakode != splitproduk[3])//diinput ulang bagi category yang tidak ke klik
                    {
                        dy.Rows.Add(idproduk, splitproduk[0], splitproduk[1], splitproduk[2], "C" + splitproduk[3]);
                    }
                    if (ambilangkakode == splitproduk[3])
                    {
                        listproduk.Remove(produk);
                    }

            //    }
            //}
            //if (Cmb_filter.Text != "")
            //{
            //    Cmb_filter.Text = "";
            //    dy.Rows.Clear();
            //    string adadicmb = Cmb_filter.Text;
            //    //foreach (string n in idprodukbarang.ToList())
            //    //{
            //    //    idprodukbarang.Remove(n);
            //    //}
            //    foreach (string category in listcategory.ToList())
            //    {
            //        string[] pisah = category.Split(',');
            //        if (pisah[0] == adadicmb)
            //        {
            //            foreach (string produk in listproduk.ToList())
            //            {

            //                string[] pisahproduk = produk.Split(',');
            //                string idproduk = pisahproduk[0].Substring(0, 1);
            //                //idprodukbarang.Add(idproduk);
            //                //int hapus = 0;
            //                //foreach (string id in idprodukbarang.ToList())
            //                //{
            //                //    hapus++;
            //                //}
            //                if (pisahproduk[3] == ambilangkakode)
            //                {
            //                    listproduk.Remove(produk);
            //                    //dy.Rows.Clear();

            //                }
            //                if (pisah[1] == pisahproduk[3])
            //                {
            //                    dy.Rows.Add(pisahproduk[4], pisahproduk[0], pisahproduk[1], pisahproduk[2], "C" + pisahproduk[3]);

            //                }

            //            }

            //        }


            //    }

            }
        }


        private void btn_Filter_Click(object sender, EventArgs e)
        {
            Cmb_filter.Enabled = true;
            Cmb_filter.Items.Clear();
            foreach (string category in listcategory)
            {
                string[] namecat = category.Split(',');
                Cmb_filter.Items.Add(namecat[0]);
            }
        }

        private void dgv_category_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int a = dgv_category.CurrentCell.RowIndex;
            txt_namacategory.Text = dgv_category.Rows[a].Cells[1].Value.ToString();
        }

        private void Cmb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ambil = 0;
            string filter = Cmb_filter.SelectedItem.ToString();
            foreach (string category in listcategory)
            {
                string[] pisahcategory = category.Split(',');
                if (pisahcategory[0] == filter) //mencari category yang dipilih
                {
                    ambil = Convert.ToInt32(pisahcategory[1]); //mengambil idcat
                }
            }
            dy.Rows.Clear();
            //foreach (string n in idprodukbarang.ToList()) //menghapus idprodukbarang biar ga kedobelan
            //{
            //    idprodukbarang.Remove(n);
            //}
            foreach (string produk in listproduk)
            {
                string[] pisahproduk = produk.Split(',');
                if (pisahproduk[3] == ambil.ToString()) //mencari id category yang sama dari idcat yang diambil
                {
                    string[] splitproduk = produk.Split(',');
                    string idproduk = splitproduk[4];


                    //ketemu = 0;
                    //idprodukbarang.Add(idproduk);
                    //foreach (string id in idprodukbarang)
                    //{
                    //    if (id == idproduk)
                    //    {
                    //        ketemu++;
                    //    }

                    //}
                    dy.Rows.Add(idproduk, splitproduk[0], splitproduk[1], splitproduk[2], "C" + splitproduk[3]);
                }
            }
        }

        private void dgv_product_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int a = dgv_product.CurrentCell.RowIndex;
            txt_namaproduk.Text = dgv_product.Rows[a].Cells[1].Value.ToString();
            txt_harga.Text = dgv_product.Rows[a].Cells[2].Value.ToString();
            txt_stok.Text = dgv_product.Rows[a].Cells[3].Value.ToString();
            string kodecategory = dgv_product.Rows[a].Cells[4].Value.ToString();
            string id = kodecategory.Substring(1, 1); //Mendapatkan angka dari rownya
            foreach (string n in listcategory)
            {
                string[] pisahcategory = n.Split(',');
                if (pisahcategory[1] == id)
                {
                    cmb_category.Text = pisahcategory[0];

                }
            }
        }

        private void btn_addproduct_Click(object sender, EventArgs e)
        {
            string ambilangka = "";
            string cat = cmb_category.Text;
            int count = 0;
            if (txt_harga.Text == string.Empty || txt_namaproduk.Text == string.Empty || txt_stok.Text == string.Empty || cmb_category.Text == string.Empty)
            {
                MessageBox.Show("Harap diisi dengan lengkap");
            }
            else
            {
                foreach (string n in listcategory)
                {
                    string[] pisah = n.Split(',');
                    if (pisah[0] == cat)
                    {
                        ambilangka = pisah[1];
                    }
                }
                listproduk.Add(txt_namaproduk.Text + "," + txt_harga.Text + "," + txt_stok.Text + "," + ambilangka+",111");
                dy.Rows.Clear();
                foreach (string n in idprodukbarang.ToList()) //menghapus idprodukbarang biar ga kedobelan
                {
                    idprodukbarang.Remove(n);
                }
                foreach (string produk in listproduk.ToList())
                {
                    count = 0;
                    
                    string[] splitproduk = produk.Split(',');
                    string idproduk = splitproduk[4];
                    string hurufsaja = idproduk.Substring(0, 1);
                    string hurufdepan = splitproduk[0].Substring(0, 1);
                    if (idproduk == "111")
                    {
                        
                        idprodukbarang.Add(hurufdepan);
                        count++;
                    }
                    if(idproduk != "111")
                    {
                        idprodukbarang.Add(idproduk);
                    }
                    ketemu = 0;
                    
                    foreach (string id in idprodukbarang)
                    {
                        string ambilhuruf = id.Substring(0, 1);
                        if ( hurufdepan== ambilhuruf)
                        {
                            ketemu++;
                        }

                    }
                    if (count==0)
                    {
                        dy.Rows.Add(idproduk, splitproduk[0], splitproduk[1], splitproduk[2], "C" + splitproduk[3]);
                    }
                    if (count>0)
                    {
                        listproduk.Remove(produk);
                        listproduk.Add(txt_namaproduk.Text + "," + txt_harga.Text + "," + txt_stok.Text + "," + ambilangka + "," + hurufdepan+"00"+ketemu);

                        dy.Rows.Add(hurufdepan + "00" + ketemu, splitproduk[0], splitproduk[1], splitproduk[2], "C" + splitproduk[3]);
                    }




                }
            }
        }

        private void btn_removeproduct_Click(object sender, EventArgs e)
        {
            if (Cmb_filter.Text == string.Empty)
            {
                int a = dgv_product.CurrentCell.RowIndex;
                string namaabarang = dgv_product.Rows[a].Cells[1].Value.ToString();
                dy.Rows[a].Delete();
                listproduk.RemoveAt(a);
                txt_harga.Text = "";
                cmb_category.Text = "";
                txt_namaproduk.Text = "";
                txt_stok.Text = "";
            }
            if(Cmb_filter.Text != "")
            {
                
                dy.Rows.Clear();
                foreach (string cat in listcategory)
                {
                    string[] splitt = cat.Split(',');
                    if (splitt[0]==Cmb_filter.Text)
                    {
                        foreach(string produk in listproduk.ToList())
                        {
                            string[] pisah = produk.Split(',');
                            if (pisah[0]==txt_namaproduk.Text)
                            {
                                listproduk.Remove(produk);
                            }
                            if (pisah[0]!=txt_namaproduk.Text)
                            {
                                dy.Rows.Add(pisah[4], pisah[0], pisah[1], pisah[2], "C" + pisah[3]);
                            }
                        }
                    }

                    
                }
                Cmb_filter.Text = "";
            }
            //foreach(string n in listproduk)
            //{
            //    if(n==namaabarang)
            //    {
            //        MessageBox.Show("Munculkan");
            //    }
            //}
        }

        private void btn_editproduct_Click(object sender, EventArgs e)
        {
            string nama = txt_namaproduk.Text;
            string categ  = cmb_category.Text;
            string ambilll = "";
            dy.Rows.Clear();
            int couy = 0;
            foreach(string o in listcategory)
            {
                string[] pisahcate = o.Split(',');
                if (pisahcate[0] ==categ)
                {
                    ambilll = pisahcate[1];
                }
            }
            foreach(string n in listproduk.ToList()) 
            {
                couy = 0;
                string[] pisah = n.Split(',');
                if (pisah[0]==nama)
                {
                    listproduk.Remove(n);
                    couy++;
                }
                if(couy > 0)
                {
                    listproduk.Add(nama +","+ txt_harga.Text +"," + txt_stok.Text + ","+ambilll +"," +pisah[4]);
                }
            }
            foreach(string y in listproduk) 
            {
                string[] pisahh = y.Split(',');
                dy.Rows.Add(pisahh[4], pisahh[0], pisahh[1], pisahh[2], "C"+pisahh[3]);
            }
        }
        //tinggal add produk, edit produk, remove produk
    }
}
