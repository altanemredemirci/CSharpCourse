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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            this.Hide();
            AracEkle aracEkle = new AracEkle();
            aracEkle.Show();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            AracListele aracListele = new AracListele();
            aracListele.Show();
            this.Hide();
        }

        private void btn_musteriListele_Click(object sender, EventArgs e)
        {
            this.Hide();
            MusteriListele musteriListele = new MusteriListele();
            musteriListele.Show();
        }

        private void btn_musteriEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            MusteriEkle musteriEkle = new MusteriEkle();
            musteriEkle.Show();
        }
    }
}
