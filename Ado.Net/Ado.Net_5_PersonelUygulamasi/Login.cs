using Ado.Net_5_PersonelUygulamasi.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado.Net_5_PersonelUygulamasi
{
    public partial class Login : Form
    {
        BusinessLayer BLL;
        public Login()
        {
            InitializeComponent();
            BLL = new BusinessLayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = BLL.SistemGirisKontrol(txt_kullaniciAdi.Text, txt_sifre.Text);
            if(result==-100)
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız");
            }
            else if (result == 0)
            {
                MessageBox.Show("Giriş bilgileriniz hatalı!");
            }
            else
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }

        }
    }
}
