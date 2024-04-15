namespace RentACar
{
    partial class AracEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracEkle));
            label1 = new Label();
            cmb_marka = new ComboBox();
            label2 = new Label();
            txt_model = new TextBox();
            label3 = new Label();
            nmr_yil = new NumericUpDown();
            cmb_renk = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            msk_fiyat = new MaskedTextBox();
            cmb_vites = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            msk_plaka = new MaskedTextBox();
            cmb_kasa = new ComboBox();
            label8 = new Label();
            cmb_yakit = new ComboBox();
            label9 = new Label();
            btn_ekle = new Button();
            btn_back = new Button();
            msk_motor = new MaskedTextBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)nmr_yil).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(17, 19);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 0;
            label1.Text = "Marka";
            // 
            // cmb_marka
            // 
            cmb_marka.FlatStyle = FlatStyle.System;
            cmb_marka.FormattingEnabled = true;
            cmb_marka.Items.AddRange(new object[] { "BMW", "Mercedes", "Reanult", "FIAT", "AUDI" });
            cmb_marka.Location = new Point(78, 19);
            cmb_marka.Name = "cmb_marka";
            cmb_marka.Size = new Size(211, 23);
            cmb_marka.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(17, 53);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 2;
            label2.Text = "Model";
            // 
            // txt_model
            // 
            txt_model.Location = new Point(78, 55);
            txt_model.Name = "txt_model";
            txt_model.Size = new Size(211, 23);
            txt_model.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(17, 93);
            label3.Name = "label3";
            label3.Size = new Size(27, 21);
            label3.TabIndex = 4;
            label3.Text = "Yıl";
            // 
            // nmr_yil
            // 
            nmr_yil.Location = new Point(78, 93);
            nmr_yil.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            nmr_yil.Minimum = new decimal(new int[] { 2018, 0, 0, 0 });
            nmr_yil.Name = "nmr_yil";
            nmr_yil.Size = new Size(214, 23);
            nmr_yil.TabIndex = 5;
            nmr_yil.Value = new decimal(new int[] { 2018, 0, 0, 0 });
            // 
            // cmb_renk
            // 
            cmb_renk.FlatStyle = FlatStyle.System;
            cmb_renk.FormattingEnabled = true;
            cmb_renk.Items.AddRange(new object[] { "Beyaz", "Siyah", "Kırmızı", "Sarı", "Mavi", "Füme", "Bej" });
            cmb_renk.Location = new Point(78, 132);
            cmb_renk.Name = "cmb_renk";
            cmb_renk.Size = new Size(211, 23);
            cmb_renk.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(17, 132);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 6;
            label4.Text = "Renk";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(17, 172);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 8;
            label5.Text = "Fiyat";
            // 
            // msk_fiyat
            // 
            msk_fiyat.Location = new Point(78, 170);
            msk_fiyat.Mask = "00000";
            msk_fiyat.Name = "msk_fiyat";
            msk_fiyat.Size = new Size(211, 23);
            msk_fiyat.TabIndex = 10;
            msk_fiyat.ValidatingType = typeof(int);
            // 
            // cmb_vites
            // 
            cmb_vites.FlatStyle = FlatStyle.System;
            cmb_vites.FormattingEnabled = true;
            cmb_vites.Items.AddRange(new object[] { "Otomatik", "Yarı Otomatik", "Manuel" });
            cmb_vites.Location = new Point(376, 21);
            cmb_vites.Name = "cmb_vites";
            cmb_vites.Size = new Size(211, 23);
            cmb_vites.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(315, 21);
            label6.Name = "label6";
            label6.Size = new Size(46, 21);
            label6.TabIndex = 11;
            label6.Text = "Vites";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(315, 59);
            label7.Name = "label7";
            label7.Size = new Size(47, 21);
            label7.TabIndex = 13;
            label7.Text = "Plaka";
            // 
            // msk_plaka
            // 
            msk_plaka.Location = new Point(376, 61);
            msk_plaka.Mask = "00aaa00";
            msk_plaka.Name = "msk_plaka";
            msk_plaka.Size = new Size(211, 23);
            msk_plaka.TabIndex = 14;
            // 
            // cmb_kasa
            // 
            cmb_kasa.FlatStyle = FlatStyle.System;
            cmb_kasa.FormattingEnabled = true;
            cmb_kasa.Items.AddRange(new object[] { "Sedan", "SUV", "Jeep", "Hatchback" });
            cmb_kasa.Location = new Point(376, 100);
            cmb_kasa.Name = "cmb_kasa";
            cmb_kasa.Size = new Size(211, 23);
            cmb_kasa.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(315, 100);
            label8.Name = "label8";
            label8.Size = new Size(43, 21);
            label8.TabIndex = 15;
            label8.Text = "Kasa";
            // 
            // cmb_yakit
            // 
            cmb_yakit.FlatStyle = FlatStyle.System;
            cmb_yakit.FormattingEnabled = true;
            cmb_yakit.Items.AddRange(new object[] { "Diesel", "Benzin", "Hybrid", "Elektrik" });
            cmb_yakit.Location = new Point(376, 140);
            cmb_yakit.Name = "cmb_yakit";
            cmb_yakit.Size = new Size(211, 23);
            cmb_yakit.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(315, 140);
            label9.Name = "label9";
            label9.Size = new Size(44, 21);
            label9.TabIndex = 17;
            label9.Text = "Yakıt";
            // 
            // btn_ekle
            // 
            btn_ekle.BackColor = SystemColors.ActiveCaption;
            btn_ekle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_ekle.ForeColor = SystemColors.ButtonHighlight;
            btn_ekle.Location = new Point(265, 215);
            btn_ekle.Name = "btn_ekle";
            btn_ekle.Size = new Size(127, 45);
            btn_ekle.TabIndex = 19;
            btn_ekle.Text = "ARAÇ KAYDET";
            btn_ekle.UseVisualStyleBackColor = false;
            btn_ekle.Click += btn_ekle_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = SystemColors.ActiveCaption;
            btn_back.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_back.ForeColor = SystemColors.ButtonHighlight;
            btn_back.Location = new Point(5, 409);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(56, 29);
            btn_back.TabIndex = 20;
            btn_back.Text = "GERİ";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // msk_motor
            // 
            msk_motor.Location = new Point(376, 174);
            msk_motor.Mask = "0000";
            msk_motor.Name = "msk_motor";
            msk_motor.Size = new Size(211, 23);
            msk_motor.TabIndex = 22;
            msk_motor.ValidatingType = typeof(int);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(315, 176);
            label10.Name = "label10";
            label10.Size = new Size(57, 21);
            label10.TabIndex = 21;
            label10.Text = "Motor";
            // 
            // AracEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(msk_motor);
            Controls.Add(label10);
            Controls.Add(btn_back);
            Controls.Add(btn_ekle);
            Controls.Add(cmb_yakit);
            Controls.Add(label9);
            Controls.Add(cmb_kasa);
            Controls.Add(label8);
            Controls.Add(msk_plaka);
            Controls.Add(label7);
            Controls.Add(cmb_vites);
            Controls.Add(label6);
            Controls.Add(msk_fiyat);
            Controls.Add(label5);
            Controls.Add(cmb_renk);
            Controls.Add(label4);
            Controls.Add(nmr_yil);
            Controls.Add(label3);
            Controls.Add(txt_model);
            Controls.Add(label2);
            Controls.Add(cmb_marka);
            Controls.Add(label1);
            Name = "AracEkle";
            Text = "AracEkle";
            ((System.ComponentModel.ISupportInitialize)nmr_yil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmb_marka;
        private Label label2;
        private TextBox txt_model;
        private Label label3;
        private NumericUpDown nmr_yil;
        private ComboBox cmb_renk;
        private Label label4;
        private Label label5;
        private MaskedTextBox msk_fiyat;
        private ComboBox cmb_vites;
        private Label label6;
        private Label label7;
        private MaskedTextBox msk_plaka;
        private ComboBox cmb_kasa;
        private Label label8;
        private ComboBox cmb_yakit;
        private Label label9;
        private Button btn_ekle;
        private Button btn_back;
        private MaskedTextBox msk_motor;
        private Label label10;
    }
}