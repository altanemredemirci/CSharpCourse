using RentACar.BLL;
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
    public partial class AracEkle : Form
    {
        AdminManager adminManager;
        int result;
        public AracEkle()
        {
            InitializeComponent();
            adminManager = new AdminManager();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            result = adminManager.ArabaEkle(cmb_marka.Text, txt_model.Text, (int)nmr_yil.Value, msk_plaka.Text, cmb_renk.Text, Convert.ToInt32(msk_fiyat.Text), cmb_vites.Text, cmb_kasa.Text, cmb_yakit.Text,Convert.ToInt32(msk_motor.Text));

            if (Hata.Hatalar.ContainsKey(result))
            {
                MessageBox.Show(Hata.Hatalar[result]);

                if (result == 300)
                {
                    cmb_marka.Text = "";
                    txt_model.Text = "";
                    nmr_yil.Value = nmr_yil.Minimum;
                    msk_plaka.Text = "";
                    cmb_renk.Text = "";
                    msk_fiyat.Text = "";
                    cmb_vites.Text = "";
                    cmb_kasa.Text = "";
                    cmb_yakit.Text = "";
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
        }
    }
}
