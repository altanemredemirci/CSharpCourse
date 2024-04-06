using System.Diagnostics;
using WinForms_2;

namespace WinForm2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SehirDoldur();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.google.com");
        }

        private void SehirDoldur()
        {
            List<Sehir> sehirler = new List<Sehir>()
            {
                new Sehir(){Id=1,Ad="Adana"},
                new Sehir(){Id=2,Ad="Adýyaman"},
                new Sehir(){Id=3,Ad="Afyon"},
                new Sehir(){Id=4,Ad="Aðrý"}
            };

            cmb_sehir.DataSource = sehirler;
            cmb_sehir.ValueMember = "Ad";
            cmb_sehir.SelectedValue = "Id";
            cmb_sehir.SelectedIndex = 0;
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            //string ad = txt_ad.Text;
            //string soyad = txt_soyad.Text;
            //string cinsiyet = radioButton1.Checked == true ? radioButton1.Text : radioButton2.Text;
            //string sehir = cmb_sehir.Text;
            //string hobiler = "";
            //string dogumtarihi = dt_dogum.Text;

            //if (checkBox1.Checked)
            //    hobiler += checkBox1.Text + " ";
            //if (checkBox2.Checked)
            //    hobiler += checkBox2.Text + " ";
            //if (checkBox3.Checked)
            //    hobiler += checkBox3.Text + " ";
            //if (checkBox4.Checked)
            //    hobiler += checkBox4.Text + " ";


            //foreach (Control item in groupBox2.Controls)
            //{
            //    if (((CheckBox)item).Checked)
            //    {
            //        hobiler += item.Text + " ";
            //    }
            //}

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = txt_ad.Text;
            ogrenci.Soyad = txt_soyad.Text;
            ogrenci.Cinsiyet = radioButton1.Checked == true ? radioButton1.Text : radioButton2.Text;
            ogrenci.DogumTarihi = dt_dogum.Text;
            ogrenci.Sehir = cmb_sehir.Text;
            foreach (Control item in groupBox2.Controls)
            {
                if (((CheckBox)item).Checked)
                {
                    ogrenci.Hobiler += item.Text + " ";
                }
            }

            lst_ogrenciler.Items.Add(ogrenci.Ad + " " + ogrenci.Soyad + " " + ogrenci.Cinsiyet + " " + ogrenci.Sehir + " " + ogrenci.Hobiler + " " + ogrenci.DogumTarihi);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyasý |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            dosya.Title = "Resim Seçiniz";
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            pictureBox1.ImageLocation = DosyaYolu;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value = i;
                progressBar1.Update();
            }
        }
    }
}
