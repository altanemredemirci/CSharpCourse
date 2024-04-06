using Ado.Net_5_PersonelUygulamasi.BLL;

namespace Ado.Net_5_PersonelUygulamasi
{
    public partial class Form1 : Form
    {
        BusinessLayer BLL;
        int sonuc;
        public Form1()
        {
            InitializeComponent();
            BLL = new BusinessLayer();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            sonuc = BLL.PersonelKayit(txt_isim.Text, txt_soyisim.Text, txt_email.Text, txt_telefon.Text);
            if (sonuc == -100)
            {
                MessageBox.Show("L�tfen bo� alan b�rakmay�n�z");
            }
            else if (sonuc == -101)
            {
                MessageBox.Show("Email ve telefon numaras� kullan�l�yor!");
            }
            else if (sonuc == 1)
            {
                MessageBox.Show("Kay�t Ba�ar�l�");

            }
            else
            {
                MessageBox.Show("Bilinmeyen bir hata olu�tu. L�tfen sistem y�neticiniz ile g����n�z..");

            }
        }
    }
}
