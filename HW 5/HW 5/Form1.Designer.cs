namespace HW_5
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_choosecontry = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_team = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_addteam = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_country = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_nameee = new System.Windows.Forms.TextBox();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_position = new System.Windows.Forms.TextBox();
            this.btn_addplayer = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soccer Team List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Country";
            // 
            // cmb_choosecontry
            // 
            this.cmb_choosecontry.FormattingEnabled = true;
            this.cmb_choosecontry.Items.AddRange(new object[] {
            "England",
            "Spain"});
            this.cmb_choosecontry.Location = new System.Drawing.Point(111, 76);
            this.cmb_choosecontry.Name = "cmb_choosecontry";
            this.cmb_choosecontry.Size = new System.Drawing.Size(154, 24);
            this.cmb_choosecontry.TabIndex = 2;
            this.cmb_choosecontry.SelectedIndexChanged += new System.EventHandler(this.cmb_choosecontry_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Choose Team";
            // 
            // cmb_team
            // 
            this.cmb_team.FormattingEnabled = true;
            this.cmb_team.Location = new System.Drawing.Point(111, 112);
            this.cmb_team.Name = "cmb_team";
            this.cmb_team.Size = new System.Drawing.Size(154, 24);
            this.cmb_team.TabIndex = 4;
            this.cmb_team.SelectedIndexChanged += new System.EventHandler(this.cmb_team_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adding Team";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Team Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Team Country";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Team City";
            // 
            // btn_addteam
            // 
            this.btn_addteam.Location = new System.Drawing.Point(377, 181);
            this.btn_addteam.Name = "btn_addteam";
            this.btn_addteam.Size = new System.Drawing.Size(75, 23);
            this.btn_addteam.TabIndex = 9;
            this.btn_addteam.Text = "Add";
            this.btn_addteam.UseVisualStyleBackColor = true;
            this.btn_addteam.Click += new System.EventHandler(this.btn_addteam_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(368, 76);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(135, 22);
            this.txt_name.TabIndex = 10;
            // 
            // txt_country
            // 
            this.txt_country.Location = new System.Drawing.Point(368, 112);
            this.txt_country.Name = "txt_country";
            this.txt_country.Size = new System.Drawing.Size(135, 22);
            this.txt_country.TabIndex = 11;
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(368, 145);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(135, 22);
            this.txt_city.TabIndex = 12;
            this.txt_city.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(656, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Adding Player";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(567, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Player Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(556, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Player Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(556, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Player Position";
            // 
            // txt_nameee
            // 
            this.txt_nameee.Location = new System.Drawing.Point(659, 84);
            this.txt_nameee.Name = "txt_nameee";
            this.txt_nameee.Size = new System.Drawing.Size(143, 22);
            this.txt_nameee.TabIndex = 17;
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(659, 117);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(143, 22);
            this.txt_number.TabIndex = 18;
            // 
            // txt_position
            // 
            this.txt_position.Location = new System.Drawing.Point(659, 148);
            this.txt_position.Name = "txt_position";
            this.txt_position.Size = new System.Drawing.Size(143, 22);
            this.txt_position.TabIndex = 19;
            // 
            // btn_addplayer
            // 
            this.btn_addplayer.Location = new System.Drawing.Point(684, 181);
            this.btn_addplayer.Name = "btn_addplayer";
            this.btn_addplayer.Size = new System.Drawing.Size(75, 23);
            this.btn_addplayer.TabIndex = 20;
            this.btn_addplayer.Text = "Add";
            this.btn_addplayer.UseVisualStyleBackColor = true;
            this.btn_addplayer.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(42, 239);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(240, 100);
            this.listBox1.TabIndex = 21;
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(57, 354);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 22;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_addplayer);
            this.Controls.Add(this.txt_position);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.txt_nameee);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.txt_country);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_addteam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_team);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_choosecontry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_choosecontry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_team;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_addteam;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_country;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_nameee;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.TextBox txt_position;
        private System.Windows.Forms.Button btn_addplayer;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_remove;
    }
}

