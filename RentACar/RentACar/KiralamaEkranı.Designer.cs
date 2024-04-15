namespace RentACar
{
    partial class KiralamaEkranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiralamaEkranı));
            dt_aracListesi = new DataGridView();
            date_basla = new DateTimePicker();
            date_bitis = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            txt_odeme = new TextBox();
            btn_kirala = new Button();
            ((System.ComponentModel.ISupportInitialize)dt_aracListesi).BeginInit();
            SuspendLayout();
            // 
            // dt_aracListesi
            // 
            dt_aracListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt_aracListesi.Location = new Point(24, 26);
            dt_aracListesi.Name = "dt_aracListesi";
            dt_aracListesi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dt_aracListesi.Size = new Size(621, 187);
            dt_aracListesi.TabIndex = 2;
            dt_aracListesi.DoubleClick += dt_aracListesi_DoubleClick;
            // 
            // date_basla
            // 
            date_basla.Location = new Point(24, 257);
            date_basla.Name = "date_basla";
            date_basla.Size = new Size(200, 23);
            date_basla.TabIndex = 3;
            // 
            // date_bitis
            // 
            date_bitis.Location = new Point(270, 257);
            date_bitis.Name = "date_bitis";
            date_bitis.Size = new Size(200, 23);
            date_bitis.TabIndex = 4;
            date_bitis.ValueChanged += date_bitis_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(24, 233);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 5;
            label1.Text = "Başlangıç tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(270, 233);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 6;
            label2.Text = "Bitiş tarihi";
            // 
            // txt_odeme
            // 
            txt_odeme.Location = new Point(201, 296);
            txt_odeme.Name = "txt_odeme";
            txt_odeme.ReadOnly = true;
            txt_odeme.Size = new Size(100, 23);
            txt_odeme.TabIndex = 7;
            // 
            // btn_kirala
            // 
            btn_kirala.BackColor = SystemColors.ActiveCaption;
            btn_kirala.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_kirala.ForeColor = SystemColors.ButtonHighlight;
            btn_kirala.Location = new Point(164, 325);
            btn_kirala.Name = "btn_kirala";
            btn_kirala.Size = new Size(168, 31);
            btn_kirala.TabIndex = 20;
            btn_kirala.Text = "ARACI KİRALA";
            btn_kirala.UseVisualStyleBackColor = false;
            btn_kirala.Click += btn_kirala_Click;
            // 
            // KiralamaEkranı
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_kirala);
            Controls.Add(txt_odeme);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(date_bitis);
            Controls.Add(date_basla);
            Controls.Add(dt_aracListesi);
            Name = "KiralamaEkranı";
            Text = "Kiralama";
            ((System.ComponentModel.ISupportInitialize)dt_aracListesi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dt_aracListesi;
        private DateTimePicker date_basla;
        private DateTimePicker date_bitis;
        private Label label1;
        private Label label2;
        private TextBox txt_odeme;
        private Button btn_kirala;
    }
}