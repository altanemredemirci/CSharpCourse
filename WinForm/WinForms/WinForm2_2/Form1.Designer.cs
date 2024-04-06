namespace WinForm2_2
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
            groupBox1 = new GroupBox();
            progressBar1 = new ProgressBar();
            checkedListBox1 = new CheckedListBox();
            label8 = new Label();
            richTextBox1 = new RichTextBox();
            label7 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            btn_kayit = new Button();
            lst_ogrenciler = new ListBox();
            label6 = new Label();
            dt_dogum = new DateTimePicker();
            cmb_sehir = new ComboBox();
            label5 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label3 = new Label();
            txt_soyad = new TextBox();
            label2 = new Label();
            txt_ad = new TextBox();
            label1 = new Label();
            label9 = new Label();
            numericUpDown1 = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(progressBar1);
            groupBox1.Controls.Add(checkedListBox1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btn_kayit);
            groupBox1.Controls.Add(lst_ogrenciler);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dt_dogum);
            groupBox1.Controls.Add(cmb_sehir);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_soyad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_ad);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(30, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1127, 649);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ÖĞRENCİ KAYIT";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(851, 65);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(259, 23);
            progressBar1.TabIndex = 28;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "C#", "Java", "MsSQL", "Python", "JavaScript", "GO", "Rust", "Ruby" });
            checkedListBox1.Location = new Point(589, 54);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(233, 196);
            checkedListBox1.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(509, 49);
            label8.Name = "label8";
            label8.Size = new Size(67, 21);
            label8.TabIndex = 26;
            label8.Text = "Dersler:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(99, 441);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(239, 96);
            richTextBox1.TabIndex = 25;
            richTextBox1.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 444);
            label7.Name = "label7";
            label7.Size = new Size(66, 21);
            label7.TabIndex = 24;
            label7.Text = "Ön Yazı:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(103, 388);
            maskedTextBox1.Mask = "+AC(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(235, 29);
            maskedTextBox1.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 396);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 22;
            label4.Text = "Telefon:";
            // 
            // button1
            // 
            button1.Location = new Point(362, 261);
            button1.Name = "button1";
            button1.Size = new Size(141, 61);
            button1.TabIndex = 21;
            button1.Text = "Profil Resmi Yükle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(361, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Location = new Point(29, 222);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(309, 100);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hobiler";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(38, 28);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(122, 25);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Kitap Okuma";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(38, 59);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(82, 25);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Sinema";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(188, 28);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(80, 25);
            checkBox3.TabIndex = 10;
            checkBox3.Text = "Tiyatro";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(188, 59);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(76, 25);
            checkBox4.TabIndex = 11;
            checkBox4.Text = "Yüzme";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // btn_kayit
            // 
            btn_kayit.Location = new Point(38, 597);
            btn_kayit.Name = "btn_kayit";
            btn_kayit.Size = new Size(309, 33);
            btn_kayit.TabIndex = 18;
            btn_kayit.Text = "KAYDET";
            btn_kayit.UseVisualStyleBackColor = true;
            btn_kayit.Click += btn_kayit_Click;
            // 
            // lst_ogrenciler
            // 
            lst_ogrenciler.FormattingEnabled = true;
            lst_ogrenciler.ItemHeight = 21;
            lst_ogrenciler.Location = new Point(520, 262);
            lst_ogrenciler.Name = "lst_ogrenciler";
            lst_ogrenciler.Size = new Size(590, 382);
            lst_ogrenciler.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 342);
            label6.Name = "label6";
            label6.Size = new Size(110, 21);
            label6.TabIndex = 15;
            label6.Text = "Doğum Tarihi:";
            // 
            // dt_dogum
            // 
            dt_dogum.Format = DateTimePickerFormat.Short;
            dt_dogum.Location = new Point(138, 336);
            dt_dogum.Name = "dt_dogum";
            dt_dogum.RightToLeft = RightToLeft.No;
            dt_dogum.Size = new Size(200, 29);
            dt_dogum.TabIndex = 14;
            // 
            // cmb_sehir
            // 
            cmb_sehir.FormattingEnabled = true;
            cmb_sehir.Location = new Point(94, 181);
            cmb_sehir.Name = "cmb_sehir";
            cmb_sehir.Size = new Size(244, 29);
            cmb_sehir.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 184);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 12;
            label5.Text = "Şehir:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(174, 143);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 25);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Erkek";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(99, 143);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(69, 25);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Kadın";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 145);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 4;
            label3.Text = "Cinsiyet:";
            // 
            // txt_soyad
            // 
            txt_soyad.Location = new Point(94, 93);
            txt_soyad.Name = "txt_soyad";
            txt_soyad.Size = new Size(244, 29);
            txt_soyad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 96);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 2;
            label2.Text = "Soyisim:";
            // 
            // txt_ad
            // 
            txt_ad.Location = new Point(94, 49);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(244, 29);
            txt_ad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 52);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 0;
            label1.Text = "Isim:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 559);
            label9.Name = "label9";
            label9.Size = new Size(37, 21);
            label9.TabIndex = 29;
            label9.Text = "Yaş:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(100, 559);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(238, 29);
            numericUpDown1.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 723);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label3;
        private TextBox txt_soyad;
        private Label label2;
        private TextBox txt_ad;
        private Label label1;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private ComboBox cmb_sehir;
        private Label label5;
        private Label label6;
        private DateTimePicker dt_dogum;
        private Button btn_kayit;
        private ListBox lst_ogrenciler;
        private GroupBox groupBox2;
        private Button button1;
        private PictureBox pictureBox1;
        private MaskedTextBox maskedTextBox1;
        private Label label4;
        private Label label7;
        private RichTextBox richTextBox1;
        private ProgressBar progressBar1;
        private CheckedListBox checkedListBox1;
        private Label label8;
        private NumericUpDown numericUpDown1;
        private Label label9;
    }
}
