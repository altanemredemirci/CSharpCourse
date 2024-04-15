namespace RentACar
{
    partial class MusteriListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriListele));
            dt_musteriListesi = new DataGridView();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)dt_musteriListesi).BeginInit();
            SuspendLayout();
            // 
            // dt_musteriListesi
            // 
            dt_musteriListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt_musteriListesi.Location = new Point(12, 28);
            dt_musteriListesi.Name = "dt_musteriListesi";
            dt_musteriListesi.Size = new Size(621, 187);
            dt_musteriListesi.TabIndex = 1;
            // 
            // btn_back
            // 
            btn_back.BackColor = SystemColors.ActiveCaption;
            btn_back.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_back.ForeColor = SystemColors.ButtonHighlight;
            btn_back.Location = new Point(12, 409);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(56, 29);
            btn_back.TabIndex = 22;
            btn_back.Text = "GERİ";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // MusteriListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_back);
            Controls.Add(dt_musteriListesi);
            Name = "MusteriListele";
            Text = "MusteriListele";
            ((System.ComponentModel.ISupportInitialize)dt_musteriListesi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dt_musteriListesi;
        private Button btn_back;
    }
}