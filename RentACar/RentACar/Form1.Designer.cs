namespace RentACar
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
            txt_user = new TextBox();
            txt_pass = new TextBox();
            label2 = new Label();
            btn_login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Email Adres:";
            // 
            // txt_user
            // 
            txt_user.Font = new Font("Segoe UI", 11.25F);
            txt_user.Location = new Point(109, 20);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(216, 27);
            txt_user.TabIndex = 1;
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI", 11.25F);
            txt_pass.Location = new Point(109, 60);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(216, 27);
            txt_pass.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 2;
            label2.Text = "Şifre:";
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.ActiveCaption;
            btn_login.Font = new Font("Segoe UI", 11.25F);
            btn_login.ForeColor = SystemColors.ButtonHighlight;
            btn_login.Location = new Point(107, 104);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(218, 28);
            btn_login.TabIndex = 4;
            btn_login.Text = "GİRİŞ YAP";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 153);
            Controls.Add(btn_login);
            Controls.Add(txt_pass);
            Controls.Add(label2);
            Controls.Add(txt_user);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_user;
        private TextBox txt_pass;
        private Label label2;
        private Button btn_login;
    }
}
