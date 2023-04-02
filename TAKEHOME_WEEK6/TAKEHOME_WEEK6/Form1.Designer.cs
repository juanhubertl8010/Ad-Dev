namespace TAKEHOME_WEEK6
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
            this.bt_all = new System.Windows.Forms.Button();
            this.bt_filter = new System.Windows.Forms.Button();
            this.cb_filter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.dgv_category = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.tb_stock = new System.Windows.Forms.TextBox();
            this.tb_harga = new System.Windows.Forms.TextBox();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.bt_addproduct = new System.Windows.Forms.Button();
            this.bt_editproduct = new System.Windows.Forms.Button();
            this.bt_removeproduct = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_namacategory = new System.Windows.Forms.TextBox();
            this.bt_addcategory = new System.Windows.Forms.Button();
            this.bt_removecategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_all
            // 
            this.bt_all.Location = new System.Drawing.Point(113, 24);
            this.bt_all.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_all.Name = "bt_all";
            this.bt_all.Size = new System.Drawing.Size(113, 31);
            this.bt_all.TabIndex = 0;
            this.bt_all.Text = "ALL";
            this.bt_all.UseVisualStyleBackColor = true;
            this.bt_all.Click += new System.EventHandler(this.bt_all_Click);
            // 
            // bt_filter
            // 
            this.bt_filter.Location = new System.Drawing.Point(231, 24);
            this.bt_filter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_filter.Name = "bt_filter";
            this.bt_filter.Size = new System.Drawing.Size(119, 32);
            this.bt_filter.TabIndex = 1;
            this.bt_filter.Text = "FILTER";
            this.bt_filter.UseVisualStyleBackColor = true;
            this.bt_filter.Click += new System.EventHandler(this.bt_filter_Click);
            // 
            // cb_filter
            // 
            this.cb_filter.Enabled = false;
            this.cb_filter.FormattingEnabled = true;
            this.cb_filter.Location = new System.Drawing.Point(365, 30);
            this.cb_filter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Size = new System.Drawing.Size(147, 24);
            this.cb_filter.TabIndex = 2;
            this.cb_filter.SelectedIndexChanged += new System.EventHandler(this.cb_filter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "PRODUCT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "CATEGORY";
            // 
            // dgv_product
            // 
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Location = new System.Drawing.Point(19, 66);
            this.dgv_product.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.RowHeadersWidth = 82;
            this.dgv_product.RowTemplate.Height = 33;
            this.dgv_product.Size = new System.Drawing.Size(491, 180);
            this.dgv_product.TabIndex = 5;
            this.dgv_product.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_product_CellMouseClick);
            // 
            // dgv_category
            // 
            this.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_category.Location = new System.Drawing.Point(539, 66);
            this.dgv_category.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_category.Name = "dgv_category";
            this.dgv_category.RowHeadersWidth = 82;
            this.dgv_category.RowTemplate.Height = 33;
            this.dgv_category.Size = new System.Drawing.Size(279, 180);
            this.dgv_category.TabIndex = 6;
            this.dgv_category.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_category_CellMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 301);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "DETAIL :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 332);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "NAMA :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 360);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "CATEGORY :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 389);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "HARGA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 420);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "STOCK :";
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(126, 328);
            this.tb_nama.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(93, 22);
            this.tb_nama.TabIndex = 13;
            // 
            // tb_stock
            // 
            this.tb_stock.Location = new System.Drawing.Point(126, 419);
            this.tb_stock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_stock.Name = "tb_stock";
            this.tb_stock.Size = new System.Drawing.Size(93, 22);
            this.tb_stock.TabIndex = 14;
            // 
            // tb_harga
            // 
            this.tb_harga.Location = new System.Drawing.Point(127, 390);
            this.tb_harga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_harga.Name = "tb_harga";
            this.tb_harga.Size = new System.Drawing.Size(92, 22);
            this.tb_harga.TabIndex = 15;
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(126, 358);
            this.cb_category.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(93, 24);
            this.cb_category.TabIndex = 16;
            this.cb_category.SelectedIndexChanged += new System.EventHandler(this.cb_category_SelectedIndexChanged);
            // 
            // bt_addproduct
            // 
            this.bt_addproduct.Location = new System.Drawing.Point(254, 314);
            this.bt_addproduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_addproduct.Name = "bt_addproduct";
            this.bt_addproduct.Size = new System.Drawing.Size(106, 42);
            this.bt_addproduct.TabIndex = 17;
            this.bt_addproduct.Text = "ADD PRODUCT";
            this.bt_addproduct.UseVisualStyleBackColor = true;
            this.bt_addproduct.Click += new System.EventHandler(this.bt_addproduct_Click);
            // 
            // bt_editproduct
            // 
            this.bt_editproduct.Location = new System.Drawing.Point(254, 360);
            this.bt_editproduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_editproduct.Name = "bt_editproduct";
            this.bt_editproduct.Size = new System.Drawing.Size(106, 42);
            this.bt_editproduct.TabIndex = 18;
            this.bt_editproduct.Text = "EDIT PRODUCT";
            this.bt_editproduct.UseVisualStyleBackColor = true;
            this.bt_editproduct.Click += new System.EventHandler(this.bt_editproduct_Click);
            // 
            // bt_removeproduct
            // 
            this.bt_removeproduct.Location = new System.Drawing.Point(254, 409);
            this.bt_removeproduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_removeproduct.Name = "bt_removeproduct";
            this.bt_removeproduct.Size = new System.Drawing.Size(106, 38);
            this.bt_removeproduct.TabIndex = 19;
            this.bt_removeproduct.Text = "REMOVE PRODUCT";
            this.bt_removeproduct.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(473, 304);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "NAMA :";
            // 
            // tb_namacategory
            // 
            this.tb_namacategory.Location = new System.Drawing.Point(539, 304);
            this.tb_namacategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_namacategory.Name = "tb_namacategory";
            this.tb_namacategory.Size = new System.Drawing.Size(153, 22);
            this.tb_namacategory.TabIndex = 21;
            // 
            // bt_addcategory
            // 
            this.bt_addcategory.Location = new System.Drawing.Point(477, 350);
            this.bt_addcategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_addcategory.Name = "bt_addcategory";
            this.bt_addcategory.Size = new System.Drawing.Size(112, 41);
            this.bt_addcategory.TabIndex = 22;
            this.bt_addcategory.Text = "ADD CATEGORY";
            this.bt_addcategory.UseVisualStyleBackColor = true;
            this.bt_addcategory.Click += new System.EventHandler(this.bt_addcategory_Click);
            // 
            // bt_removecategory
            // 
            this.bt_removecategory.Location = new System.Drawing.Point(593, 353);
            this.bt_removecategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_removecategory.Name = "bt_removecategory";
            this.bt_removecategory.Size = new System.Drawing.Size(106, 38);
            this.bt_removecategory.TabIndex = 23;
            this.bt_removecategory.Text = "REMOVE CATEGORY";
            this.bt_removecategory.UseVisualStyleBackColor = true;
            this.bt_removecategory.Click += new System.EventHandler(this.bt_removecategory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(875, 554);
            this.Controls.Add(this.bt_removecategory);
            this.Controls.Add(this.bt_addcategory);
            this.Controls.Add(this.tb_namacategory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bt_removeproduct);
            this.Controls.Add(this.bt_editproduct);
            this.Controls.Add(this.bt_addproduct);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.tb_harga);
            this.Controls.Add(this.tb_stock);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_category);
            this.Controls.Add(this.dgv_product);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_filter);
            this.Controls.Add(this.bt_filter);
            this.Controls.Add(this.bt_all);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_all;
        private System.Windows.Forms.Button bt_filter;
        private System.Windows.Forms.ComboBox cb_filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.DataGridView dgv_category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.TextBox tb_stock;
        private System.Windows.Forms.TextBox tb_harga;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Button bt_addproduct;
        private System.Windows.Forms.Button bt_editproduct;
        private System.Windows.Forms.Button bt_removeproduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_namacategory;
        private System.Windows.Forms.Button bt_addcategory;
        private System.Windows.Forms.Button bt_removecategory;
    }
}

