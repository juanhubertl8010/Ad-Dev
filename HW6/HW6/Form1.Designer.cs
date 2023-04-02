namespace HW6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.btn_All = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.Cmb_filter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_category = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_namaproduk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_harga = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.btn_addproduct = new System.Windows.Forms.Button();
            this.btn_editproduct = new System.Windows.Forms.Button();
            this.btn_removeproduct = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_namacategory = new System.Windows.Forms.TextBox();
            this.btn_addcategory = new System.Windows.Forms.Button();
            this.btn_removecategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCT";
            // 
            // dgv_product
            // 
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Location = new System.Drawing.Point(12, 71);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.RowHeadersWidth = 51;
            this.dgv_product.RowTemplate.Height = 24;
            this.dgv_product.Size = new System.Drawing.Size(662, 260);
            this.dgv_product.TabIndex = 1;
            this.dgv_product.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_product_CellMouseClick);
            // 
            // btn_All
            // 
            this.btn_All.Location = new System.Drawing.Point(337, 28);
            this.btn_All.Name = "btn_All";
            this.btn_All.Size = new System.Drawing.Size(75, 23);
            this.btn_All.TabIndex = 2;
            this.btn_All.Text = "All";
            this.btn_All.UseVisualStyleBackColor = true;
            this.btn_All.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Filter
            // 
            this.btn_Filter.Location = new System.Drawing.Point(418, 28);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(75, 23);
            this.btn_Filter.TabIndex = 3;
            this.btn_Filter.Text = "Filter";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // Cmb_filter
            // 
            this.Cmb_filter.Enabled = false;
            this.Cmb_filter.FormattingEnabled = true;
            this.Cmb_filter.Location = new System.Drawing.Point(499, 28);
            this.Cmb_filter.Name = "Cmb_filter";
            this.Cmb_filter.Size = new System.Drawing.Size(121, 24);
            this.Cmb_filter.TabIndex = 4;
            this.Cmb_filter.SelectedIndexChanged += new System.EventHandler(this.Cmb_filter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(940, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "CATEGORY";
            // 
            // dgv_category
            // 
            this.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_category.Location = new System.Drawing.Point(844, 71);
            this.dgv_category.Name = "dgv_category";
            this.dgv_category.RowHeadersWidth = 51;
            this.dgv_category.RowTemplate.Height = 24;
            this.dgv_category.Size = new System.Drawing.Size(331, 260);
            this.dgv_category.TabIndex = 6;
            this.dgv_category.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_category_CellMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(12, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "DETAIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nama: ";
            // 
            // txt_namaproduk
            // 
            this.txt_namaproduk.Location = new System.Drawing.Point(89, 404);
            this.txt_namaproduk.Name = "txt_namaproduk";
            this.txt_namaproduk.Size = new System.Drawing.Size(180, 22);
            this.txt_namaproduk.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Category: ";
            // 
            // cmb_category
            // 
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(89, 438);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(180, 24);
            this.cmb_category.TabIndex = 11;
            this.cmb_category.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Harga: ";
            // 
            // txt_harga
            // 
            this.txt_harga.Location = new System.Drawing.Point(89, 475);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(180, 22);
            this.txt_harga.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 511);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Stock: ";
            // 
            // txt_stok
            // 
            this.txt_stok.Location = new System.Drawing.Point(89, 511);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(180, 22);
            this.txt_stok.TabIndex = 15;
            // 
            // btn_addproduct
            // 
            this.btn_addproduct.Location = new System.Drawing.Point(319, 441);
            this.btn_addproduct.Name = "btn_addproduct";
            this.btn_addproduct.Size = new System.Drawing.Size(75, 64);
            this.btn_addproduct.TabIndex = 16;
            this.btn_addproduct.Text = "Add Product";
            this.btn_addproduct.UseVisualStyleBackColor = true;
            this.btn_addproduct.Click += new System.EventHandler(this.btn_addproduct_Click);
            // 
            // btn_editproduct
            // 
            this.btn_editproduct.Location = new System.Drawing.Point(418, 441);
            this.btn_editproduct.Name = "btn_editproduct";
            this.btn_editproduct.Size = new System.Drawing.Size(75, 64);
            this.btn_editproduct.TabIndex = 17;
            this.btn_editproduct.Text = "Edit Product";
            this.btn_editproduct.UseVisualStyleBackColor = true;
            this.btn_editproduct.Click += new System.EventHandler(this.btn_editproduct_Click);
            // 
            // btn_removeproduct
            // 
            this.btn_removeproduct.Location = new System.Drawing.Point(517, 441);
            this.btn_removeproduct.Name = "btn_removeproduct";
            this.btn_removeproduct.Size = new System.Drawing.Size(75, 64);
            this.btn_removeproduct.TabIndex = 18;
            this.btn_removeproduct.Text = "Remove Product";
            this.btn_removeproduct.UseVisualStyleBackColor = true;
            this.btn_removeproduct.Click += new System.EventHandler(this.btn_removeproduct_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(827, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nama: ";
            // 
            // txt_namacategory
            // 
            this.txt_namacategory.Location = new System.Drawing.Point(893, 364);
            this.txt_namacategory.Name = "txt_namacategory";
            this.txt_namacategory.Size = new System.Drawing.Size(213, 22);
            this.txt_namacategory.TabIndex = 20;
            // 
            // btn_addcategory
            // 
            this.btn_addcategory.Location = new System.Drawing.Point(893, 407);
            this.btn_addcategory.Name = "btn_addcategory";
            this.btn_addcategory.Size = new System.Drawing.Size(99, 63);
            this.btn_addcategory.TabIndex = 21;
            this.btn_addcategory.Text = "Add Category";
            this.btn_addcategory.UseVisualStyleBackColor = true;
            this.btn_addcategory.Click += new System.EventHandler(this.btn_addcategory_Click);
            // 
            // btn_removecategory
            // 
            this.btn_removecategory.Location = new System.Drawing.Point(1011, 407);
            this.btn_removecategory.Name = "btn_removecategory";
            this.btn_removecategory.Size = new System.Drawing.Size(107, 63);
            this.btn_removecategory.TabIndex = 22;
            this.btn_removecategory.Text = "Remove Category";
            this.btn_removecategory.UseVisualStyleBackColor = true;
            this.btn_removecategory.Click += new System.EventHandler(this.btn_removecategory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1313, 569);
            this.Controls.Add(this.btn_removecategory);
            this.Controls.Add(this.btn_addcategory);
            this.Controls.Add(this.txt_namacategory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_removeproduct);
            this.Controls.Add(this.btn_editproduct);
            this.Controls.Add(this.btn_addproduct);
            this.Controls.Add(this.txt_stok);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_harga);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_category);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_namaproduk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_category);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cmb_filter);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.btn_All);
            this.Controls.Add(this.dgv_product);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.Button btn_All;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.ComboBox Cmb_filter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_namaproduk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_harga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_stok;
        private System.Windows.Forms.Button btn_addproduct;
        private System.Windows.Forms.Button btn_editproduct;
        private System.Windows.Forms.Button btn_removeproduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_namacategory;
        private System.Windows.Forms.Button btn_addcategory;
        private System.Windows.Forms.Button btn_removecategory;
    }
}

