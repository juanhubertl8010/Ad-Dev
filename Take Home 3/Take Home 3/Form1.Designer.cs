namespace Take_Home_3
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
            this.lbl_nama = new System.Windows.Forms.Label();
            this.label_umur = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.txt_Nama = new System.Windows.Forms.TextBox();
            this.txt_umur = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_phonenumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_nama.Location = new System.Drawing.Point(7, 36);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(126, 39);
            this.lbl_nama.TabIndex = 0;
            this.lbl_nama.Text = "Nama :";
            // 
            // label_umur
            // 
            this.label_umur.AutoSize = true;
            this.label_umur.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label_umur.Location = new System.Drawing.Point(12, 93);
            this.label_umur.Name = "label_umur";
            this.label_umur.Size = new System.Drawing.Size(96, 39);
            this.label_umur.TabIndex = 1;
            this.label_umur.Text = "Age: ";
            this.label_umur.Click += new System.EventHandler(this.label_umur_Click);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label_email.Location = new System.Drawing.Point(12, 146);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(121, 39);
            this.label_email.TabIndex = 2;
            this.label_email.Text = "Email: ";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label_phone.Location = new System.Drawing.Point(12, 204);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(264, 39);
            this.label_phone.TabIndex = 3;
            this.label_phone.Text = "Phone Number :";
            // 
            // txt_Nama
            // 
            this.txt_Nama.Location = new System.Drawing.Point(139, 51);
            this.txt_Nama.Name = "txt_Nama";
            this.txt_Nama.Size = new System.Drawing.Size(330, 22);
            this.txt_Nama.TabIndex = 4;
            // 
            // txt_umur
            // 
            this.txt_umur.Location = new System.Drawing.Point(114, 108);
            this.txt_umur.Name = "txt_umur";
            this.txt_umur.Size = new System.Drawing.Size(365, 22);
            this.txt_umur.TabIndex = 5;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(139, 161);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(340, 22);
            this.txt_email.TabIndex = 6;
            // 
            // txt_phonenumber
            // 
            this.txt_phonenumber.Location = new System.Drawing.Point(295, 219);
            this.txt_phonenumber.Name = "txt_phonenumber";
            this.txt_phonenumber.Size = new System.Drawing.Size(206, 22);
            this.txt_phonenumber.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_clear);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(494, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 60);
            this.button2.TabIndex = 9;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_submit);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_phonenumber);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_umur);
            this.Controls.Add(this.txt_Nama);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_umur);
            this.Controls.Add(this.lbl_nama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.Label label_umur;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.TextBox txt_Nama;
        private System.Windows.Forms.TextBox txt_umur;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_phonenumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

