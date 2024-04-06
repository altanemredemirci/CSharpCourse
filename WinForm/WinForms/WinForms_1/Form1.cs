namespace WinForms_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_username.Text;
            string sifre = txt_password.Text;

            MessageBox.Show(kullaniciAdi);
            MessageBox.Show(sifre);
        }
    }
}
