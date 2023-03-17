namespace HW_4
{
    partial class Form2
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
            this.label_pickbackcolor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdio_yellow = new System.Windows.Forms.RadioButton();
            this.rdio_Cyan = new System.Windows.Forms.RadioButton();
            this.rdio_green = new System.Windows.Forms.RadioButton();
            this.rdio_blue = new System.Windows.Forms.RadioButton();
            this.rdio_red = new System.Windows.Forms.RadioButton();
            this.label_PickTextColor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdio_White = new System.Windows.Forms.RadioButton();
            this.rdio_grey = new System.Windows.Forms.RadioButton();
            this.rdio_black = new System.Windows.Forms.RadioButton();
            this.lbl_Hi = new System.Windows.Forms.Label();
            this.chck_agree2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button_magic = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_pickbackcolor
            // 
            this.label_pickbackcolor.AutoSize = true;
            this.label_pickbackcolor.Location = new System.Drawing.Point(9, 64);
            this.label_pickbackcolor.Name = "label_pickbackcolor";
            this.label_pickbackcolor.Size = new System.Drawing.Size(240, 16);
            this.label_pickbackcolor.TabIndex = 0;
            this.label_pickbackcolor.Text = "Pick Your Favourite Background Color: ";
            this.label_pickbackcolor.Click += new System.EventHandler(this.label_pickbackcolor_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdio_yellow);
            this.panel1.Controls.Add(this.rdio_Cyan);
            this.panel1.Controls.Add(this.rdio_green);
            this.panel1.Controls.Add(this.rdio_blue);
            this.panel1.Controls.Add(this.rdio_red);
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 159);
            this.panel1.TabIndex = 1;
            // 
            // rdio_yellow
            // 
            this.rdio_yellow.AutoSize = true;
            this.rdio_yellow.Location = new System.Drawing.Point(1, 5);
            this.rdio_yellow.Name = "rdio_yellow";
            this.rdio_yellow.Size = new System.Drawing.Size(68, 20);
            this.rdio_yellow.TabIndex = 5;
            this.rdio_yellow.Text = "Yellow";
            this.rdio_yellow.UseVisualStyleBackColor = true;
            this.rdio_yellow.CheckedChanged += new System.EventHandler(this.rdio_yellow_CheckedChanged_1);
            // 
            // rdio_Cyan
            // 
            this.rdio_Cyan.AutoSize = true;
            this.rdio_Cyan.Location = new System.Drawing.Point(4, 112);
            this.rdio_Cyan.Name = "rdio_Cyan";
            this.rdio_Cyan.Size = new System.Drawing.Size(59, 20);
            this.rdio_Cyan.TabIndex = 4;
            this.rdio_Cyan.Text = "Cyan";
            this.rdio_Cyan.UseVisualStyleBackColor = true;
            this.rdio_Cyan.CheckedChanged += new System.EventHandler(this.rdio_Cyan_CheckedChanged);
            // 
            // rdio_green
            // 
            this.rdio_green.AutoSize = true;
            this.rdio_green.Location = new System.Drawing.Point(4, 85);
            this.rdio_green.Name = "rdio_green";
            this.rdio_green.Size = new System.Drawing.Size(65, 20);
            this.rdio_green.TabIndex = 3;
            this.rdio_green.Text = "Green";
            this.rdio_green.UseVisualStyleBackColor = true;
            this.rdio_green.CheckedChanged += new System.EventHandler(this.rdio_green_CheckedChanged);
            // 
            // rdio_blue
            // 
            this.rdio_blue.AutoSize = true;
            this.rdio_blue.Location = new System.Drawing.Point(4, 58);
            this.rdio_blue.Name = "rdio_blue";
            this.rdio_blue.Size = new System.Drawing.Size(55, 20);
            this.rdio_blue.TabIndex = 2;
            this.rdio_blue.Text = "Blue";
            this.rdio_blue.UseVisualStyleBackColor = true;
            this.rdio_blue.CheckedChanged += new System.EventHandler(this.rdio_blue_CheckedChanged);
            // 
            // rdio_red
            // 
            this.rdio_red.AutoSize = true;
            this.rdio_red.Location = new System.Drawing.Point(4, 31);
            this.rdio_red.Name = "rdio_red";
            this.rdio_red.Size = new System.Drawing.Size(54, 20);
            this.rdio_red.TabIndex = 1;
            this.rdio_red.Text = "Red";
            this.rdio_red.UseVisualStyleBackColor = true;
            this.rdio_red.CheckedChanged += new System.EventHandler(this.rdio_red_CheckedChanged);
            // 
            // label_PickTextColor
            // 
            this.label_PickTextColor.AutoSize = true;
            this.label_PickTextColor.Location = new System.Drawing.Point(349, 64);
            this.label_PickTextColor.Name = "label_PickTextColor";
            this.label_PickTextColor.Size = new System.Drawing.Size(100, 16);
            this.label_PickTextColor.TabIndex = 2;
            this.label_PickTextColor.Text = "Pick Text Color:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdio_White);
            this.panel2.Controls.Add(this.rdio_grey);
            this.panel2.Controls.Add(this.rdio_black);
            this.panel2.Location = new System.Drawing.Point(352, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 3;
            // 
            // rdio_White
            // 
            this.rdio_White.AutoSize = true;
            this.rdio_White.Location = new System.Drawing.Point(4, 57);
            this.rdio_White.Name = "rdio_White";
            this.rdio_White.Size = new System.Drawing.Size(62, 20);
            this.rdio_White.TabIndex = 2;
            this.rdio_White.Text = "White";
            this.rdio_White.UseVisualStyleBackColor = true;
            this.rdio_White.CheckedChanged += new System.EventHandler(this.rdio_White_CheckedChanged);
            // 
            // rdio_grey
            // 
            this.rdio_grey.AutoSize = true;
            this.rdio_grey.Location = new System.Drawing.Point(4, 30);
            this.rdio_grey.Name = "rdio_grey";
            this.rdio_grey.Size = new System.Drawing.Size(57, 20);
            this.rdio_grey.TabIndex = 1;
            this.rdio_grey.Text = "Grey";
            this.rdio_grey.UseVisualStyleBackColor = true;
            this.rdio_grey.CheckedChanged += new System.EventHandler(this.rdio_grey_CheckedChanged);
            // 
            // rdio_black
            // 
            this.rdio_black.AutoSize = true;
            this.rdio_black.Location = new System.Drawing.Point(3, 3);
            this.rdio_black.Name = "rdio_black";
            this.rdio_black.Size = new System.Drawing.Size(62, 20);
            this.rdio_black.TabIndex = 0;
            this.rdio_black.Text = "Black";
            this.rdio_black.UseVisualStyleBackColor = true;
            this.rdio_black.CheckedChanged += new System.EventHandler(this.rdio_black_CheckedChanged);
            // 
            // lbl_Hi
            // 
            this.lbl_Hi.AutoSize = true;
            this.lbl_Hi.Location = new System.Drawing.Point(16, 13);
            this.lbl_Hi.Name = "lbl_Hi";
            this.lbl_Hi.Size = new System.Drawing.Size(44, 16);
            this.lbl_Hi.TabIndex = 4;
            this.lbl_Hi.Text = "label1";
            this.lbl_Hi.TextChanged += new System.EventHandler(this.lbl_Hi_TextChanged);
            // 
            // chck_agree2
            // 
            this.chck_agree2.AutoSize = true;
            this.chck_agree2.Location = new System.Drawing.Point(19, 276);
            this.chck_agree2.Name = "chck_agree2";
            this.chck_agree2.Size = new System.Drawing.Size(231, 20);
            this.chck_agree2.TabIndex = 5;
            this.chck_agree2.Text = "I agree to the Terms of Agreement";
            this.chck_agree2.UseVisualStyleBackColor = true;
            this.chck_agree2.CheckedChanged += new System.EventHandler(this.chck_agree2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 302);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(238, 20);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "All the choice I pick above are True";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button_magic
            // 
            this.button_magic.Enabled = false;
            this.button_magic.Location = new System.Drawing.Point(545, 372);
            this.button_magic.Name = "button_magic";
            this.button_magic.Size = new System.Drawing.Size(75, 23);
            this.button_magic.TabIndex = 7;
            this.button_magic.Text = "Magic";
            this.button_magic.UseVisualStyleBackColor = true;
            this.button_magic.Click += new System.EventHandler(this.button_magic_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_magic);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.chck_agree2);
            this.Controls.Add(this.lbl_Hi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_PickTextColor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_pickbackcolor);
            this.Name = "Form2";
            this.Text = "Second Window Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_pickbackcolor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdio_Cyan;
        private System.Windows.Forms.RadioButton rdio_green;
        private System.Windows.Forms.RadioButton rdio_blue;
        private System.Windows.Forms.RadioButton rdio_red;
        private System.Windows.Forms.Label label_PickTextColor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdio_White;
        private System.Windows.Forms.RadioButton rdio_grey;
        private System.Windows.Forms.RadioButton rdio_black;
        private System.Windows.Forms.Label lbl_Hi;
        private System.Windows.Forms.CheckBox chck_agree2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button_magic;
        private System.Windows.Forms.RadioButton rdio_yellow;
    }
}