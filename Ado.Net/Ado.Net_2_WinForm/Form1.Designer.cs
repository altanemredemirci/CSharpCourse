namespace Ado.Net_2_WinForm
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
            label1 = new Label();
            txt_ad = new TextBox();
            label2 = new Label();
            nmr_Id = new NumericUpDown();
            label3 = new Label();
            rch_adres = new RichTextBox();
            btn_kaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)nmr_Id).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(32, 68);
            label1.Name = "label1";
            label1.Size = new Size(32, 21);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // txt_ad
            // 
            txt_ad.Font = new Font("Segoe UI", 12F);
            txt_ad.Location = new Point(85, 65);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(223, 29);
            txt_ad.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(32, 32);
            label2.Name = "label2";
            label2.Size = new Size(26, 21);
            label2.TabIndex = 2;
            label2.Text = "Id:";
            // 
            // nmr_Id
            // 
            nmr_Id.Font = new Font("Segoe UI", 12F);
            nmr_Id.Location = new Point(85, 30);
            nmr_Id.Name = "nmr_Id";
            nmr_Id.Size = new Size(223, 29);
            nmr_Id.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(32, 112);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 4;
            label3.Text = "Adres:";
            // 
            // rch_adres
            // 
            rch_adres.Font = new Font("Segoe UI", 12F);
            rch_adres.Location = new Point(87, 111);
            rch_adres.Name = "rch_adres";
            rch_adres.Size = new Size(221, 96);
            rch_adres.TabIndex = 5;
            rch_adres.Text = "";
            // 
            // btn_kaydet
            // 
            btn_kaydet.Font = new Font("Segoe UI", 12F);
            btn_kaydet.Location = new Point(86, 230);
            btn_kaydet.Name = "btn_kaydet";
            btn_kaydet.Size = new Size(222, 33);
            btn_kaydet.TabIndex = 6;
            btn_kaydet.Text = "KAYDET";
            btn_kaydet.UseVisualStyleBackColor = true;
            btn_kaydet.Click += btn_kaydet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 293);
            Controls.Add(btn_kaydet);
            Controls.Add(rch_adres);
            Controls.Add(label3);
            Controls.Add(nmr_Id);
            Controls.Add(label2);
            Controls.Add(txt_ad);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nmr_Id).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_ad;
        private Label label2;
        private NumericUpDown nmr_Id;
        private Label label3;
        private RichTextBox rch_adres;
        private Button btn_kaydet;
    }
}
