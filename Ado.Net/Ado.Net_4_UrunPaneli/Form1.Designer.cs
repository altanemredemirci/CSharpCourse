namespace Ado.Net_4_UrunPaneli
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
            txt_name = new TextBox();
            nmr_Id = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            txt_price = new TextBox();
            label4 = new Label();
            nmr_stock = new NumericUpDown();
            btn_Save = new Button();
            dt_products = new DataGridView();
            lstView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btn_update = new Button();
            btn_Delete = new Button();
            ((System.ComponentModel.ISupportInitialize)nmr_Id).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmr_stock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dt_products).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 77);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(112, 116);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(209, 23);
            txt_name.TabIndex = 1;
            // 
            // nmr_Id
            // 
            nmr_Id.Enabled = false;
            nmr_Id.Location = new Point(112, 75);
            nmr_Id.Name = "nmr_Id";
            nmr_Id.ReadOnly = true;
            nmr_Id.Size = new Size(209, 23);
            nmr_Id.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 119);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Ürün Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 157);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Ürün Fiyatı:";
            // 
            // txt_price
            // 
            txt_price.Location = new Point(112, 154);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(209, 23);
            txt_price.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 197);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 7;
            label4.Text = "Ürün Fiyatı:";
            // 
            // nmr_stock
            // 
            nmr_stock.Location = new Point(113, 195);
            nmr_stock.Name = "nmr_stock";
            nmr_stock.Size = new Size(209, 23);
            nmr_stock.TabIndex = 8;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(429, 77);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(208, 33);
            btn_Save.TabIndex = 9;
            btn_Save.Text = "Kaydet";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // dt_products
            // 
            dt_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt_products.Location = new Point(12, 282);
            dt_products.Name = "dt_products";
            dt_products.Size = new Size(411, 188);
            dt_products.TabIndex = 10;
            // 
            // lstView
            // 
            lstView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lstView.FullRowSelect = true;
            lstView.GridLines = true;
            lstView.Location = new Point(429, 282);
            lstView.Name = "lstView";
            lstView.Size = new Size(425, 188);
            lstView.TabIndex = 11;
            lstView.UseCompatibleStateImageBehavior = false;
            lstView.View = View.Details;
            lstView.DoubleClick += lstView_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Price";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Stock";
            // 
            // btn_update
            // 
            btn_update.Location = new Point(429, 116);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(208, 32);
            btn_update.TabIndex = 12;
            btn_update.Text = "Güncelle";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(429, 157);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(208, 32);
            btn_Delete.TabIndex = 13;
            btn_Delete.Text = "Sil";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 602);
            Controls.Add(btn_Delete);
            Controls.Add(btn_update);
            Controls.Add(lstView);
            Controls.Add(dt_products);
            Controls.Add(btn_Save);
            Controls.Add(nmr_stock);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_price);
            Controls.Add(label2);
            Controls.Add(nmr_Id);
            Controls.Add(txt_name);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nmr_Id).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmr_stock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dt_products).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_name;
        private NumericUpDown nmr_Id;
        private Label label2;
        private Label label3;
        private TextBox txt_price;
        private Label label4;
        private NumericUpDown nmr_stock;
        private Button btn_Save;
        private DataGridView dt_products;
        private ListView lstView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btn_update;
        private Button btn_Delete;
    }
}
