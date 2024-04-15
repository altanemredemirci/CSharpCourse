using RentACar.BLL;
using RentACar.DAL;
using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class KiralamaEkranı : Form
    {
        UserManager userManager;
        Kiralama kiralama;
        RentManager rentManager;
        public KiralamaEkranı()
        {
            InitializeComponent();
            userManager = new UserManager();
            dt_aracListesi.DataSource = userManager.ArabaListele();
            kiralama = new Kiralama();
            rentManager = new RentManager();
        }

        private void date_bitis_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan GunFarki = date_bitis.Value.Subtract(date_basla.Value);
            kiralama.GunSayisi = GunFarki.Days + 1;
            kiralama.Odeme = Convert.ToDecimal(kiralama.GunSayisi * Convert.ToDouble(araba.Fiyat));
            txt_odeme.Text = kiralama.Odeme.ToString();
        }
        Araba araba;
        private void dt_aracListesi_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            string plaka = dataGridView.SelectedRows[0].Cells[10].Value.ToString();

            araba = userManager.ArabaGetir(plaka);
        }

        private void btn_kirala_Click(object sender, EventArgs e)
        {
            kiralama.IlkTarih = DateOnly.FromDateTime(date_basla.Value);
            kiralama.SonTarih = DateOnly.FromDateTime(date_bitis.Value);
            kiralama.ArabaId = araba.Id;
            kiralama.MusteriId = UserDAL.MusteriId;

            if (rentManager.AracKirala(kiralama) > 0)
            {
                MessageBox.Show("Araç Kiralandı");
            }
        }
    }
}
