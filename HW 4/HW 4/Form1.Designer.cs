namespace HW_4
{
    partial class MainWindow
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
            this.btn_openNextForm = new System.Windows.Forms.Button();
            this.label_nama = new System.Windows.Forms.Label();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.Label_myfavartist = new System.Windows.Forms.Label();
            this.Txt_MyFavArtist = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.Chck_agreement = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_openNextForm
            // 
            this.btn_openNextForm.Enabled = false;
            this.btn_openNextForm.Location = new System.Drawing.Point(652, 415);
            this.btn_openNextForm.Name = "btn_openNextForm";
            this.btn_openNextForm.Size = new System.Drawing.Size(136, 23);
            this.btn_openNextForm.TabIndex = 0;
            this.btn_openNextForm.Text = "Open Next Form";
            this.btn_openNextForm.UseVisualStyleBackColor = true;
            this.btn_openNextForm.Click += new System.EventHandler(this.btn_openNextForm_Click);
            // 
            // label_nama
            // 
            this.label_nama.AutoSize = true;
            this.label_nama.Location = new System.Drawing.Point(13, 25);
            this.label_nama.Name = "label_nama";
            this.label_nama.Size = new System.Drawing.Size(53, 16);
            this.label_nama.TabIndex = 1;
            this.label_nama.Text = "Nama : ";
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(72, 22);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(227, 22);
            this.txt_nama.TabIndex = 2;
            this.txt_nama.TextChanged += new System.EventHandler(this.txt_nama_TextChanged);
            // 
            // Label_myfavartist
            // 
            this.Label_myfavartist.AutoSize = true;
            this.Label_myfavartist.Location = new System.Drawing.Point(12, 61);
            this.Label_myfavartist.Name = "Label_myfavartist";
            this.Label_myfavartist.Size = new System.Drawing.Size(122, 16);
            this.Label_myfavartist.TabIndex = 3;
            this.Label_myfavartist.Text = "My Favourite Artist: ";
            // 
            // Txt_MyFavArtist
            // 
            this.Txt_MyFavArtist.Location = new System.Drawing.Point(151, 61);
            this.Txt_MyFavArtist.Name = "Txt_MyFavArtist";
            this.Txt_MyFavArtist.Size = new System.Drawing.Size(184, 22);
            this.Txt_MyFavArtist.TabIndex = 4;
            // 
            // btn_submit
            // 
            this.btn_submit.Enabled = false;
            this.btn_submit.Location = new System.Drawing.Point(249, 149);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 5;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // Chck_agreement
            // 
            this.Chck_agreement.AutoSize = true;
            this.Chck_agreement.Location = new System.Drawing.Point(16, 107);
            this.Chck_agreement.Name = "Chck_agreement";
            this.Chck_agreement.Size = new System.Drawing.Size(235, 20);
            this.Chck_agreement.TabIndex = 6;
            this.Chck_agreement.Text = "All of the content I put above is true!";
            this.Chck_agreement.UseVisualStyleBackColor = true;
            this.Chck_agreement.CheckedChanged += new System.EventHandler(this.Chck_agreement_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Chck_agreement);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.Txt_MyFavArtist);
            this.Controls.Add(this.Label_myfavartist);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.label_nama);
            this.Controls.Add(this.btn_openNextForm);
            this.Name = "MainWindow";
            this.Text = "Main Window Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_openNextForm;
        private System.Windows.Forms.Label label_nama;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.Label Label_myfavartist;
        private System.Windows.Forms.TextBox Txt_MyFavArtist;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.CheckBox Chck_agreement;
    }
}

