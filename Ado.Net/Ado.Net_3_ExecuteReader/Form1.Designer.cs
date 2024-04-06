namespace Ado.Net_3_ExecuteReader
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
            dt_ogrenciler = new DataGridView();
            lst_ogrenciler = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dt_ogrenciler).BeginInit();
            SuspendLayout();
            // 
            // dt_ogrenciler
            // 
            dt_ogrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt_ogrenciler.Location = new Point(56, 73);
            dt_ogrenciler.Name = "dt_ogrenciler";
            dt_ogrenciler.Size = new Size(675, 295);
            dt_ogrenciler.TabIndex = 0;
            // 
            // lst_ogrenciler
            // 
            lst_ogrenciler.FormattingEnabled = true;
            lst_ogrenciler.ItemHeight = 15;
            lst_ogrenciler.Location = new Point(749, 73);
            lst_ogrenciler.Name = "lst_ogrenciler";
            lst_ogrenciler.Size = new Size(253, 289);
            lst_ogrenciler.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 469);
            Controls.Add(lst_ogrenciler);
            Controls.Add(dt_ogrenciler);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dt_ogrenciler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dt_ogrenciler;
        private ListBox lst_ogrenciler;
    }
}
