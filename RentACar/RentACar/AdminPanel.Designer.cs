namespace RentACar
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            btn_ekle = new Button();
            btn_listele = new Button();
            btn_musteriListele = new Button();
            btn_kiralama = new Button();
            btn_musteriEkle = new Button();
            SuspendLayout();
            // 
            // btn_ekle
            // 
            btn_ekle.BackColor = SystemColors.ActiveCaption;
            btn_ekle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_ekle.ForeColor = SystemColors.ButtonHighlight;
            btn_ekle.Location = new Point(18, 36);
            btn_ekle.Name = "btn_ekle";
            btn_ekle.Size = new Size(142, 43);
            btn_ekle.TabIndex = 0;
            btn_ekle.Text = "ARAÇ EKLE";
            btn_ekle.UseVisualStyleBackColor = false;
            btn_ekle.Click += btn_ekle_Click;
            // 
            // btn_listele
            // 
            btn_listele.BackColor = SystemColors.ActiveCaption;
            btn_listele.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_listele.ForeColor = SystemColors.ButtonHighlight;
            btn_listele.Location = new Point(18, 115);
            btn_listele.Name = "btn_listele";
            btn_listele.Size = new Size(142, 43);
            btn_listele.TabIndex = 1;
            btn_listele.Text = "ARAÇ LİSTESİ";
            btn_listele.UseVisualStyleBackColor = false;
            btn_listele.Click += btn_listele_Click;
            // 
            // btn_musteriListele
            // 
            btn_musteriListele.BackColor = SystemColors.ActiveCaption;
            btn_musteriListele.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_musteriListele.ForeColor = SystemColors.ButtonHighlight;
            btn_musteriListele.Location = new Point(193, 115);
            btn_musteriListele.Name = "btn_musteriListele";
            btn_musteriListele.Size = new Size(142, 43);
            btn_musteriListele.TabIndex = 2;
            btn_musteriListele.Text = "MÜŞTERİ LİSTESİ";
            btn_musteriListele.UseVisualStyleBackColor = false;
            btn_musteriListele.Click += btn_musteriListele_Click;
            // 
            // btn_kiralama
            // 
            btn_kiralama.BackColor = SystemColors.ActiveCaption;
            btn_kiralama.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_kiralama.ForeColor = SystemColors.ButtonHighlight;
            btn_kiralama.Location = new Point(18, 263);
            btn_kiralama.Name = "btn_kiralama";
            btn_kiralama.Size = new Size(142, 61);
            btn_kiralama.TabIndex = 3;
            btn_kiralama.Text = "KİRALAMA DURUMU";
            btn_kiralama.UseVisualStyleBackColor = false;
            // 
            // btn_musteriEkle
            // 
            btn_musteriEkle.BackColor = SystemColors.ActiveCaption;
            btn_musteriEkle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_musteriEkle.ForeColor = SystemColors.ButtonHighlight;
            btn_musteriEkle.Location = new Point(193, 36);
            btn_musteriEkle.Name = "btn_musteriEkle";
            btn_musteriEkle.Size = new Size(142, 43);
            btn_musteriEkle.TabIndex = 4;
            btn_musteriEkle.Text = "MÜŞTERİ EKLE";
            btn_musteriEkle.UseVisualStyleBackColor = false;
            btn_musteriEkle.Click += btn_musteriEkle_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_musteriEkle);
            Controls.Add(btn_kiralama);
            Controls.Add(btn_musteriListele);
            Controls.Add(btn_listele);
            Controls.Add(btn_ekle);
            Name = "AdminPanel";
            Text = "AdminPanel";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_ekle;
        private Button btn_listele;
        private Button btn_musteriListele;
        private Button btn_kiralama;
        private Button btn_musteriEkle;
    }
}