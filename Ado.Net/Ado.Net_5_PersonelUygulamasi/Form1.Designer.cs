namespace Ado.Net_5_PersonelUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lst_personellerim = new ListBox();
            groupBox1 = new GroupBox();
            btn_kayit = new Button();
            txt_telefon = new TextBox();
            label4 = new Label();
            txt_email = new TextBox();
            label3 = new Label();
            txt_soyisim = new TextBox();
            label2 = new Label();
            txt_isim = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btn_sil = new Button();
            btn_guncelle = new Button();
            txt_ytelefon = new TextBox();
            label5 = new Label();
            txt_yemail = new TextBox();
            label6 = new Label();
            txt_ysoyisim = new TextBox();
            label7 = new Label();
            txt_yisim = new TextBox();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lst_personellerim
            // 
            lst_personellerim.FormattingEnabled = true;
            lst_personellerim.ItemHeight = 15;
            lst_personellerim.Location = new Point(23, 12);
            lst_personellerim.Name = "lst_personellerim";
            lst_personellerim.Size = new Size(274, 514);
            lst_personellerim.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_kayit);
            groupBox1.Controls.Add(txt_telefon);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_email);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_soyisim);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_isim);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(343, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(490, 233);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Personel EKLE";
            // 
            // btn_kayit
            // 
            btn_kayit.Location = new Point(123, 182);
            btn_kayit.Name = "btn_kayit";
            btn_kayit.Size = new Size(338, 23);
            btn_kayit.TabIndex = 8;
            btn_kayit.Text = "Yeni Personel EKLE";
            btn_kayit.UseVisualStyleBackColor = true;
            btn_kayit.Click += btn_kayit_Click;
            // 
            // txt_telefon
            // 
            txt_telefon.Location = new Point(122, 144);
            txt_telefon.Name = "txt_telefon";
            txt_telefon.Size = new Size(339, 23);
            txt_telefon.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 147);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 6;
            label4.Text = "Telefon Numarası";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(122, 105);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(339, 23);
            txt_email.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 113);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 4;
            label3.Text = "Email Adres";
            // 
            // txt_soyisim
            // 
            txt_soyisim.Location = new Point(122, 67);
            txt_soyisim.Name = "txt_soyisim";
            txt_soyisim.Size = new Size(339, 23);
            txt_soyisim.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 75);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 2;
            label2.Text = "Soyisim";
            // 
            // txt_isim
            // 
            txt_isim.Location = new Point(122, 34);
            txt_isim.Name = "txt_isim";
            txt_isim.Size = new Size(339, 23);
            txt_isim.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 40);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "İsim";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_sil);
            groupBox2.Controls.Add(btn_guncelle);
            groupBox2.Controls.Add(txt_ytelefon);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txt_yemail);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txt_ysoyisim);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txt_yisim);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(343, 262);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(490, 242);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personel GÜNCELLE";
            // 
            // btn_sil
            // 
            btn_sil.Location = new Point(123, 210);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(338, 23);
            btn_sil.TabIndex = 9;
            btn_sil.Text = "Sil";
            btn_sil.UseVisualStyleBackColor = true;
            // 
            // btn_guncelle
            // 
            btn_guncelle.Location = new Point(123, 182);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(338, 23);
            btn_guncelle.TabIndex = 8;
            btn_guncelle.Text = "Güncelle";
            btn_guncelle.UseVisualStyleBackColor = true;
            // 
            // txt_ytelefon
            // 
            txt_ytelefon.Location = new Point(122, 144);
            txt_ytelefon.Name = "txt_ytelefon";
            txt_ytelefon.Size = new Size(339, 23);
            txt_ytelefon.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 147);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 6;
            label5.Text = "Telefon Numarası";
            // 
            // txt_yemail
            // 
            txt_yemail.Location = new Point(122, 105);
            txt_yemail.Name = "txt_yemail";
            txt_yemail.Size = new Size(339, 23);
            txt_yemail.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 113);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 4;
            label6.Text = "Email Adres";
            // 
            // txt_ysoyisim
            // 
            txt_ysoyisim.Location = new Point(122, 67);
            txt_ysoyisim.Name = "txt_ysoyisim";
            txt_ysoyisim.Size = new Size(339, 23);
            txt_ysoyisim.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 75);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 2;
            label7.Text = "Soyisim";
            // 
            // txt_yisim
            // 
            txt_yisim.Location = new Point(122, 34);
            txt_yisim.Name = "txt_yisim";
            txt_yisim.Size = new Size(339, 23);
            txt_yisim.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 40);
            label8.Name = "label8";
            label8.Size = new Size(29, 15);
            label8.TabIndex = 0;
            label8.Text = "İsim";
            // 
            // button1
            // 
            button1.Location = new Point(343, 505);
            button1.Name = "button1";
            button1.Size = new Size(238, 23);
            button1.TabIndex = 10;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(587, 505);
            button2.Name = "button2";
            button2.Size = new Size(245, 23);
            button2.TabIndex = 11;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 653);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lst_personellerim);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lst_personellerim;
        private GroupBox groupBox1;
        private Button btn_kayit;
        private TextBox txt_telefon;
        private Label label4;
        private TextBox txt_email;
        private Label label3;
        private TextBox txt_soyisim;
        private Label label2;
        private TextBox txt_isim;
        private Label label1;
        private GroupBox groupBox2;
        private Button btn_sil;
        private Button btn_guncelle;
        private TextBox txt_ytelefon;
        private Label label5;
        private TextBox txt_yemail;
        private Label label6;
        private TextBox txt_ysoyisim;
        private Label label7;
        private TextBox txt_yisim;
        private Label label8;
        private Button button1;
        private Button button2;
    }
}
