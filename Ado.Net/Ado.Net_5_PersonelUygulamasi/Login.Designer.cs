namespace Ado.Net_5_PersonelUygulamasi
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            txt_sifre = new TextBox();
            label2 = new Label();
            txt_kullaniciAdi = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txt_sifre
            // 
            txt_sifre.Location = new Point(127, 55);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.Size = new Size(209, 23);
            txt_sifre.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 63);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 6;
            label2.Text = "Şifre";
            // 
            // txt_kullaniciAdi
            // 
            txt_kullaniciAdi.Location = new Point(127, 22);
            txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            txt_kullaniciAdi.Size = new Size(209, 23);
            txt_kullaniciAdi.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 30);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 4;
            label1.Text = "Kullanıcı Adı";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txt_kullaniciAdi);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_sifre);
            groupBox1.Location = new Point(216, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(367, 151);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sistem Giriş Bilgileriniz";
            // 
            // button1
            // 
            button1.Location = new Point(128, 96);
            button1.Name = "button1";
            button1.Size = new Size(208, 23);
            button1.TabIndex = 8;
            button1.Text = "Sistem Giriş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 214);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txt_sifre;
        private Label label2;
        private TextBox txt_kullaniciAdi;
        private Label label1;
        private GroupBox groupBox1;
        private Button button1;
    }
}