namespace RentACar
{
    partial class MusteriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriEkle));
            txt_isim = new TextBox();
            label2 = new Label();
            txt_soyisim = new TextBox();
            label1 = new Label();
            label3 = new Label();
            msk_tc = new MaskedTextBox();
            label4 = new Label();
            rch_adres = new RichTextBox();
            label5 = new Label();
            nmr_bakiye = new NumericUpDown();
            txt_ehliyet = new TextBox();
            label6 = new Label();
            label7 = new Label();
            msk_telefon = new MaskedTextBox();
            txt_email = new TextBox();
            label8 = new Label();
            btn_back = new Button();
            btn_musteriekle = new Button();
            ((System.ComponentModel.ISupportInitialize)nmr_bakiye).BeginInit();
            SuspendLayout();
            // 
            // txt_isim
            // 
            txt_isim.Location = new Point(83, 29);
            txt_isim.Name = "txt_isim";
            txt_isim.Size = new Size(211, 23);
            txt_isim.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(14, 30);
            label2.Name = "label2";
            label2.Size = new Size(40, 21);
            label2.TabIndex = 4;
            label2.Text = "İsim";
            // 
            // txt_soyisim
            // 
            txt_soyisim.Location = new Point(83, 68);
            txt_soyisim.Name = "txt_soyisim";
            txt_soyisim.Size = new Size(211, 23);
            txt_soyisim.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(14, 69);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 6;
            label1.Text = "Soyisim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(14, 106);
            label3.Name = "label3";
            label3.Size = new Size(28, 21);
            label3.TabIndex = 8;
            label3.Text = "TC";
            // 
            // msk_tc
            // 
            msk_tc.Location = new Point(83, 108);
            msk_tc.Mask = "00000000000";
            msk_tc.Name = "msk_tc";
            msk_tc.Size = new Size(211, 23);
            msk_tc.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(14, 147);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 10;
            label4.Text = "Adres";
            // 
            // rch_adres
            // 
            rch_adres.Location = new Point(83, 152);
            rch_adres.Name = "rch_adres";
            rch_adres.Size = new Size(211, 96);
            rch_adres.TabIndex = 11;
            rch_adres.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(327, 150);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 12;
            label5.Text = "Bakiye";
            // 
            // nmr_bakiye
            // 
            nmr_bakiye.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            nmr_bakiye.Location = new Point(395, 150);
            nmr_bakiye.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nmr_bakiye.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            nmr_bakiye.Name = "nmr_bakiye";
            nmr_bakiye.Size = new Size(212, 23);
            nmr_bakiye.TabIndex = 13;
            nmr_bakiye.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // txt_ehliyet
            // 
            txt_ehliyet.Location = new Point(394, 32);
            txt_ehliyet.Name = "txt_ehliyet";
            txt_ehliyet.Size = new Size(211, 23);
            txt_ehliyet.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(325, 33);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 14;
            label6.Text = "Ehliyet";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(325, 72);
            label7.Name = "label7";
            label7.Size = new Size(64, 21);
            label7.TabIndex = 16;
            label7.Text = "Telefon";
            // 
            // msk_telefon
            // 
            msk_telefon.Location = new Point(395, 68);
            msk_telefon.Mask = "00000000000";
            msk_telefon.Name = "msk_telefon";
            msk_telefon.Size = new Size(211, 23);
            msk_telefon.TabIndex = 17;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(394, 108);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(211, 23);
            txt_email.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(325, 109);
            label8.Name = "label8";
            label8.Size = new Size(48, 21);
            label8.TabIndex = 18;
            label8.Text = "Email";
            // 
            // btn_back
            // 
            btn_back.BackColor = SystemColors.ActiveCaption;
            btn_back.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_back.ForeColor = SystemColors.ButtonHighlight;
            btn_back.Location = new Point(13, 411);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(56, 29);
            btn_back.TabIndex = 22;
            btn_back.Text = "GERİ";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_musteriekle
            // 
            btn_musteriekle.BackColor = SystemColors.ActiveCaption;
            btn_musteriekle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_musteriekle.ForeColor = SystemColors.ButtonHighlight;
            btn_musteriekle.Location = new Point(327, 203);
            btn_musteriekle.Name = "btn_musteriekle";
            btn_musteriekle.Size = new Size(158, 45);
            btn_musteriekle.TabIndex = 21;
            btn_musteriekle.Text = "MÜŞTERİ KAYDET";
            btn_musteriekle.UseVisualStyleBackColor = false;
            btn_musteriekle.Click += btn_musteriekle_Click;
            // 
            // MusteriEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_back);
            Controls.Add(btn_musteriekle);
            Controls.Add(txt_email);
            Controls.Add(label8);
            Controls.Add(msk_telefon);
            Controls.Add(label7);
            Controls.Add(txt_ehliyet);
            Controls.Add(label6);
            Controls.Add(nmr_bakiye);
            Controls.Add(label5);
            Controls.Add(rch_adres);
            Controls.Add(label4);
            Controls.Add(msk_tc);
            Controls.Add(label3);
            Controls.Add(txt_soyisim);
            Controls.Add(label1);
            Controls.Add(txt_isim);
            Controls.Add(label2);
            Name = "MusteriEkle";
            Text = "MusteriEkle";
            ((System.ComponentModel.ISupportInitialize)nmr_bakiye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_isim;
        private Label label2;
        private TextBox txt_soyisim;
        private Label label1;
        private Label label3;
        private MaskedTextBox msk_tc;
        private Label label4;
        private RichTextBox rch_adres;
        private Label label5;
        private NumericUpDown nmr_bakiye;
        private TextBox txt_ehliyet;
        private Label label6;
        private Label label7;
        private MaskedTextBox msk_telefon;
        private TextBox txt_email;
        private Label label8;
        private Button btn_back;
        private Button btn_musteriekle;
    }
}