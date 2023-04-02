using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;


namespace TAKEHOME_WEEK6
{
    public partial class Form1 : Form
    {
        int index = 5;
        public class product
        {
            public string idbarang { get; set; }
            public string namabarang { get; set; }
            public string hargabarang { get; set; }
            public string stockbarang { get; set; }
            public string idkategori { get; set; }

            public product(string id, string nama, string harga, string stock, string kategori)
            {
                this.idbarang = id;
                this.namabarang = nama;
                this.hargabarang = harga;
                this.stockbarang = stock;
                this.idkategori = kategori;
            }

        }
        public class kategori
        {
            public string idkategori { get; set; }
            public string namakategori { get; set; }

            public kategori(string id, string kat)
            {
                this.idkategori = id;
                this.namakategori = kat;
            }
        }
        List<product> products = new List<product>();
        List<kategori> kategoris = new List<kategori>();
        List<string> id = new List<string>();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();





        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID PRODUCT");
            dt.Columns.Add("NAMA PRODUK");
            dt.Columns.Add("HARGA");
            dt.Columns.Add("STOCK");
            dt.Columns.Add("ID CATEGORY");

            dt2.Columns.Add("ID CATEGORY");
            dt2.Columns.Add("NAMA CATEGORY");

            dgv_product.DataSource = dt;
            dgv_category.DataSource = dt2;

            products.Add(new product("J001", "JAS HITAM", "100000", "10", "C1"));
            products.Add(new product("T001", "T-shirt black men", "70000", "20", "C2"));
            products.Add(new product("T002", "T-shirt obsessive", "75000", "16", "C2"));
            products.Add(new product("R001", "Rok mini", "82000", "26", "C3"));
            products.Add(new product("J002", "Jeans biru", "90000", "5", "C4"));
            products.Add(new product("C001", "Celana pendek coklat", "60000", "11", "C4"));
            products.Add(new product("C002", "Cawat blink-blink", "1000000", "1", "C5"));
            products.Add(new product("R002", "Roca shirt", "50000", "8", "C2"));

            id.Add("J001");
            id.Add("T001");
            id.Add("T002");
            id.Add("R001");
            id.Add("J002");
            id.Add("C001");
            id.Add("C002");
            id.Add("R002");

            kategoris.Add(new kategori("C1", "Jas"));
            kategoris.Add(new kategori("C2", "T-shirt"));
            kategoris.Add(new kategori("C3", "Rok"));
            kategoris.Add(new kategori("C4", "Celana"));
            kategoris.Add(new kategori("C5", "Cawat"));

            /*string id = products[0].idbarang;
            string nama = products[1].namabarang;
            string harga = products[2].hargabarang;
            string stock = products[3].stockbarang;
            string kategori = products[4].idkategori;

            string ide = kategoris[0].idkategori;
            string namakategori = kategoris[1].namakategori;
            */
            int hitung = 0;
            int hitung2 = 0;
            foreach (product i in products)
            {
                dt.Rows.Add(products[hitung].idbarang, products[hitung].namabarang, products[hitung].hargabarang, products[hitung].stockbarang, products[hitung].idkategori);
                hitung++;
            }

            foreach (kategori p in kategoris)
            {
                dt2.Rows.Add(kategoris[hitung2].idkategori, kategoris[hitung2].namakategori);
                cb_category.Items.Add(p.namakategori);
                hitung2++;
            }
        }

        private void bt_addcategory_Click(object sender, EventArgs e)
        {
            int kategorisudahada = 0;

            foreach (kategori x in kategoris)
            {
                if (x.namakategori == tb_namacategory.Text)
                {
                    kategorisudahada++;
                }

            }
            if (kategorisudahada == 1)
            {
                MessageBox.Show("hahahah...");
            }
            else
            {
                index++;
                kategoris.Add(new kategori("C" + index, tb_namacategory.Text));

                dt2.Rows.Clear();
                cb_category.Items.Clear();
                cb_filter.Items.Clear();
                foreach (kategori p in kategoris.ToList())
                {
                    dt2.Rows.Add(p.idkategori, p.namakategori);
                    cb_filter.Items.Add(p.namakategori);
                    cb_category.Items.Add(p.namakategori);

                }

            }
        }

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_removecategory_Click(object sender, EventArgs e)
        {
            int plus = dgv_category.CurrentCell.RowIndex;
            string kode = dgv_category.Rows[plus].Cells[0].Value.ToString();
            string ambilangkakode = kode.Substring(1, 1);
            dt2.Rows[plus].Delete();
            kategoris.RemoveAt(plus);
            cb_category.Items.Clear();
            cb_filter.Items.Clear();
            int hitung2 = 0;
            foreach (kategori p in kategoris.ToList())
            {

                cb_filter.Items.Add(kategoris[hitung2].namakategori);
                cb_category.Items.Add(kategoris[hitung2].namakategori);
                hitung2++;
            }

            cb_filter.Text = string.Empty;
            dt.Rows.Clear();
            foreach (string n in id.ToList())
            {
                id.Remove(n);
            }

            foreach (product h in products.ToList())
            {


                if (ambilangkakode != h.idkategori.Substring(1, 1))//diinput ulang bagi category yang tidak ke klik
                {
                    dt.Rows.Add(h.idbarang, h.namabarang, h.hargabarang, h.stockbarang, h.idkategori);


                }
                if (ambilangkakode == h.idkategori.Substring(1, 1))
                {
                    products.Remove(h);

                }

            }
        }

        private void dgv_category_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int a = dgv_category.CurrentCell.RowIndex;
            tb_namacategory.Text = dgv_category.Rows[a].Cells[1].Value.ToString();
        }

        private void bt_all_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            cb_filter.Text = string.Empty;

            foreach (product i in products)
            {
                dt.Rows.Add(i.idbarang, i.namabarang, i.hargabarang, i.stockbarang, i.idkategori);

            }
        }

        private void bt_filter_Click(object sender, EventArgs e)
        {
            cb_filter.Enabled = true;
            cb_filter.Items.Clear();
            foreach (kategori p in kategoris.ToList())
            {
                cb_filter.Items.Add(p.namakategori);
            }
        }

        private void cb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ambil = 0;
            string simpan = "";
            string filter = cb_filter.SelectedItem.ToString();
            foreach (kategori p in kategoris.ToList())
            {
                if (p.namakategori.ToString() == filter)
                {
                    simpan = p.idkategori.Substring(1, 1);
                    ambil = Convert.ToInt32(simpan);

                }
            }
            dt.Rows.Clear();
            foreach (product i in products)
            {
                if (i.idkategori.Substring(1, 1) == ambil.ToString())
                {
                    dt.Rows.Add(i.idbarang, i.namabarang, i.hargabarang, i.stockbarang, i.idkategori);
                }

            }

        }

        private void dgv_product_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int a = dgv_product.CurrentCell.RowIndex;
            tb_nama.Text = dgv_product.Rows[a].Cells[1].Value.ToString();
            tb_harga.Text = dgv_product.Rows[a].Cells[2].Value.ToString();
            tb_stock.Text = dgv_product.Rows[a].Cells[3].Value.ToString();
            string kodecategory = dgv_product.Rows[a].Cells[4].Value.ToString();
            string id = kodecategory.Substring(1, 1); //Mendapatkan angka dari rownya
            foreach (kategori p in kategoris.ToList())
            {
                if (p.idkategori.Substring(1, 1) == id)
                {
                    cb_category.Text = p.namakategori;
                }
            }

        }

        private void bt_addproduct_Click(object sender, EventArgs e)
        {
            string ambilangka = "";
            string cat = cb_category.Text;
            int count = 0;
            if (tb_nama.Text == string.Empty || tb_harga.Text == string.Empty || tb_stock.Text == string.Empty || cb_category.Text == string.Empty)
            {
                MessageBox.Show("Harap diisi dengan lengkap");
            }
            else
            {
                foreach (kategori p in kategoris.ToList())
                {
                    if (p.namakategori == cat)
                    {
                        ambilangka = p.idkategori.Substring(1, 1);
                    }
                }
                products.Add(new product("222", tb_nama.Text, tb_harga.Text, tb_stock.Text, "C" + ambilangka));
                dt.Rows.Clear();
                foreach (string n in id.ToList()) //menghapus idprodukbarang biar ga kedobelan
                {
                    id.Remove(n);
                }
                foreach (product h in products.ToList())
                {
                    count = 0;
                    if (h.idbarang == "222")
                    {
                        id.Add(h.namabarang.Substring(0, 1));
                        count++;
                    }
                    else
                    {
                        id.Add(h.idbarang);
                    }
                    int ketemuu = 0;
                    foreach (string y in id.ToList())
                    {
                        if (y.Substring(0, 1) == h.namabarang.Substring(0, 1))
                        {
                            ketemuu++;
                        }
                    }
                    if (count == 0)
                    {
                        dt.Rows.Add(h.idbarang, h.namabarang, h.hargabarang, h.stockbarang, h.idkategori);
                    }
                    if (count >= 1)
                    {
                        products.Remove(h);
                        products.Add(new product(h.namabarang.Substring(0, 1) + "00" + ketemuu, h.namabarang, h.hargabarang, h.stockbarang, h.idkategori));
                        dt.Rows.Add(h.namabarang.Substring(0, 1) + "00" + ketemuu, h.namabarang, h.hargabarang, h.stockbarang, h.idkategori);
                    }

                }


            }

        }

        private void bt_editproduct_Click(object sender, EventArgs e)
        {
            string nama = tb_nama.Text;
            string cat = cb_category.Text;
            string ambilangka = "";
            
            dt.Rows.Clear();
            int couy = 0;
            foreach (kategori p in kategoris.ToList())
            {
                if (p.namakategori == cat)
                {
                    ambilangka = p.idkategori.Substring(1, 1);
                }
            }
            foreach (product h in products.ToList())
            {
                couy = 0;
                if (h.namabarang == nama)
                {
                    
                    couy++;
                    products.Remove(h);

                }
                if (couy > 0)
                {
                    
                    products.Add(new product(h.idbarang, h.namabarang, tb_harga.Text, tb_stock.Text, "C"+ ambilangka));
                    
                }
            }
            foreach (product h in products.ToList())
            { 
                
            
                dt.Rows.Add(h.idbarang, h.namabarang, h.hargabarang, h.stockbarang, h.idkategori);
            }
        }

        private void bt_removeproduct_Click(object sender, EventArgs e)
        {
            if (cb_filter.Text == string.Empty)
            {
                int a = dgv_product.CurrentCell.RowIndex;
                string namaabarang = dgv_product.Rows[a].Cells[1].Value.ToString();
                dt.Rows[a].Delete();
                products.RemoveAt(a);
                tb_nama.Text = "";
                tb_harga.Text = "";
               tb_stock.Text = "";
                cb_category.Text = "";
            }
            if (cb_filter.Text != "")
            {

                dt.Rows.Clear();
                foreach (kategori cat in kategoris)
                {
                    
                    if (cat.namakategori== cb_filter.Text)
                    {
                        foreach(product h in products.ToList()) 
                        {
                            if(h.namabarang==tb_nama.Text)
                            {
                                products.Remove(h);
                            }
                            if(h.namabarang!=tb_nama.Text)
                            {
                                dt.Rows.Add(h.idbarang, h.namabarang, h.hargabarang, h.idbarang, h.idkategori);
                            }
                        }
                       
                    }
                    cb_filter.Text = "";

                }
               
            }
        }
    }
    }


