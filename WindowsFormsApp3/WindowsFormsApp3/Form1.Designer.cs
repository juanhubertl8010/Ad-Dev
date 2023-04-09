namespace WindowsFormsApp3
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
            this.labelnama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelgender = new System.Windows.Forms.Label();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.txt_umur = new System.Windows.Forms.TextBox();
            this.radiobtn_female = new System.Windows.Forms.RadioButton();
            this.radiobtn_male = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radiobtn_blue = new System.Windows.Forms.RadioButton();
            this.radiobtn_red = new System.Windows.Forms.RadioButton();
            this.radiobtn_cyan = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.chck_reading = new System.Windows.Forms.CheckBox();
            this.chck_watchingTV = new System.Windows.Forms.CheckBox();
            this.chck_playingsport = new System.Windows.Forms.CheckBox();
            this.chck_lainnya = new System.Windows.Forms.CheckBox();
            this.txt_lainnya = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelnama
            // 
            this.labelnama.AutoSize = true;
            this.labelnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelnama.Location = new System.Drawing.Point(12, 42);
            this.labelnama.Name = "labelnama";
            this.labelnama.Size = new System.Drawing.Size(63, 20);
            this.labelnama.TabIndex = 0;
            this.labelnama.Text = "Nama: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Age :";
            // 
            // labelgender
            // 
            this.labelgender.AutoSize = true;
            this.labelgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelgender.Location = new System.Drawing.Point(12, 136);
            this.labelgender.Name = "labelgender";
            this.labelgender.Size = new System.Drawing.Size(74, 20);
            this.labelgender.TabIndex = 2;
            this.labelgender.Text = "Gender: ";
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(81, 42);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(146, 22);
            this.txt_nama.TabIndex = 3;
            this.txt_nama.TextChanged += new System.EventHandler(this.txt_nama_TextChanged);
            // 
            // txt_umur
            // 
            this.txt_umur.Location = new System.Drawing.Point(66, 88);
            this.txt_umur.Name = "txt_umur";
            this.txt_umur.Size = new System.Drawing.Size(146, 22);
            this.txt_umur.TabIndex = 4;
            // 
            // radiobtn_female
            // 
            this.radiobtn_female.AutoSize = true;
            this.radiobtn_female.Location = new System.Drawing.Point(7, 12);
            this.radiobtn_female.Name = "radiobtn_female";
            this.radiobtn_female.Size = new System.Drawing.Size(74, 20);
            this.radiobtn_female.TabIndex = 5;
            this.radiobtn_female.TabStop = true;
            this.radiobtn_female.Text = "Female";
            this.radiobtn_female.UseVisualStyleBackColor = true;
            this.radiobtn_female.CheckedChanged += new System.EventHandler(this.radiobtn_female_CheckedChanged);
            // 
            // radiobtn_male
            // 
            this.radiobtn_male.AutoSize = true;
            this.radiobtn_male.Location = new System.Drawing.Point(7, 54);
            this.radiobtn_male.Name = "radiobtn_male";
            this.radiobtn_male.Size = new System.Drawing.Size(58, 20);
            this.radiobtn_male.TabIndex = 6;
            this.radiobtn_male.TabStop = true;
            this.radiobtn_male.Text = "Male";
            this.radiobtn_male.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(6, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Favourite Color: ";
            // 
            // radiobtn_blue
            // 
            this.radiobtn_blue.AutoSize = true;
            this.radiobtn_blue.Location = new System.Drawing.Point(3, 3);
            this.radiobtn_blue.Name = "radiobtn_blue";
            this.radiobtn_blue.Size = new System.Drawing.Size(55, 20);
            this.radiobtn_blue.TabIndex = 8;
            this.radiobtn_blue.TabStop = true;
            this.radiobtn_blue.Text = "Blue";
            this.radiobtn_blue.UseVisualStyleBackColor = true;
            // 
            // radiobtn_red
            // 
            this.radiobtn_red.AutoSize = true;
            this.radiobtn_red.Location = new System.Drawing.Point(4, 29);
            this.radiobtn_red.Name = "radiobtn_red";
            this.radiobtn_red.Size = new System.Drawing.Size(54, 20);
            this.radiobtn_red.TabIndex = 9;
            this.radiobtn_red.TabStop = true;
            this.radiobtn_red.Text = "Red";
            this.radiobtn_red.UseVisualStyleBackColor = true;
            // 
            // radiobtn_cyan
            // 
            this.radiobtn_cyan.AutoSize = true;
            this.radiobtn_cyan.Location = new System.Drawing.Point(6, 55);
            this.radiobtn_cyan.Name = "radiobtn_cyan";
            this.radiobtn_cyan.Size = new System.Drawing.Size(59, 20);
            this.radiobtn_cyan.TabIndex = 10;
            this.radiobtn_cyan.TabStop = true;
            this.radiobtn_cyan.Text = "Cyan";
            this.radiobtn_cyan.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radiobtn_female);
            this.panel1.Controls.Add(this.radiobtn_male);
            this.panel1.Location = new System.Drawing.Point(81, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radiobtn_blue);
            this.panel2.Controls.Add(this.radiobtn_red);
            this.panel2.Controls.Add(this.radiobtn_cyan);
            this.panel2.Location = new System.Drawing.Point(81, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(394, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hobbies: ";
            // 
            // chck_reading
            // 
            this.chck_reading.AutoSize = true;
            this.chck_reading.Location = new System.Drawing.Point(472, 65);
            this.chck_reading.Name = "chck_reading";
            this.chck_reading.Size = new System.Drawing.Size(81, 20);
            this.chck_reading.TabIndex = 14;
            this.chck_reading.Text = "Reading";
            this.chck_reading.UseVisualStyleBackColor = true;
            this.chck_reading.CheckedChanged += new System.EventHandler(this.chck_reading_CheckedChanged);
            // 
            // chck_watchingTV
            // 
            this.chck_watchingTV.AutoSize = true;
            this.chck_watchingTV.Location = new System.Drawing.Point(472, 89);
            this.chck_watchingTV.Name = "chck_watchingTV";
            this.chck_watchingTV.Size = new System.Drawing.Size(106, 20);
            this.chck_watchingTV.TabIndex = 15;
            this.chck_watchingTV.Text = "Watching TV";
            this.chck_watchingTV.UseVisualStyleBackColor = true;
            // 
            // chck_playingsport
            // 
            this.chck_playingsport.AutoSize = true;
            this.chck_playingsport.Location = new System.Drawing.Point(472, 116);
            this.chck_playingsport.Name = "chck_playingsport";
            this.chck_playingsport.Size = new System.Drawing.Size(109, 20);
            this.chck_playingsport.TabIndex = 16;
            this.chck_playingsport.Text = "Playing Sport";
            this.chck_playingsport.UseVisualStyleBackColor = true;
            // 
            // chck_lainnya
            // 
            this.chck_lainnya.AutoSize = true;
            this.chck_lainnya.Location = new System.Drawing.Point(472, 144);
            this.chck_lainnya.Name = "chck_lainnya";
            this.chck_lainnya.Size = new System.Drawing.Size(18, 17);
            this.chck_lainnya.TabIndex = 17;
            this.chck_lainnya.UseVisualStyleBackColor = true;
            // 
            // txt_lainnya
            // 
            this.txt_lainnya.Location = new System.Drawing.Point(496, 139);
            this.txt_lainnya.Name = "txt_lainnya";
            this.txt_lainnya.Size = new System.Drawing.Size(181, 22);
            this.txt_lainnya.TabIndex = 18;
            this.txt_lainnya.TextChanged += new System.EventHandler(this.txt_lainnya_TextChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(545, 244);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 19;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(642, 244);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 20;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_lainnya);
            this.Controls.Add(this.chck_lainnya);
            this.Controls.Add(this.chck_playingsport);
            this.Controls.Add(this.chck_watchingTV);
            this.Controls.Add(this.chck_reading);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_umur);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.labelgender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelnama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelgender;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.TextBox txt_umur;
        private System.Windows.Forms.RadioButton radiobtn_female;
        private System.Windows.Forms.RadioButton radiobtn_male;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radiobtn_blue;
        private System.Windows.Forms.RadioButton radiobtn_red;
        private System.Windows.Forms.RadioButton radiobtn_cyan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chck_reading;
        private System.Windows.Forms.CheckBox chck_watchingTV;
        private System.Windows.Forms.CheckBox chck_playingsport;
        private System.Windows.Forms.CheckBox chck_lainnya;
        private System.Windows.Forms.TextBox txt_lainnya;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_submit;
    }
}

