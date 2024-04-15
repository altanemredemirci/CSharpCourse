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
    public partial class MusteriEkle : Form
    {
        AdminManager adminManager;
        int result;
        public MusteriEkle()
        {
            InitializeComponent();
            adminManager = new AdminManager();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
        }

        private void btn_musteriekle_Click(object sender, EventArgs e)
        {
            result = adminManager.MusteriEkle(txt_isim.Text,txt_soyisim.Text,Convert.ToInt64(msk_tc.Text),rch_adres.Text,(int)nmr_bakiye.Value,txt_ehliyet.Text, msk_telefon.Text,txt_email.Text);

            if (Hata.Hatalar.ContainsKey(result))
            {
                MessageBox.Show(Hata.Hatalar[result]);

                if (result == 203)
                {
                    txt_isim.Text = "";
                    txt_soyisim.Text = "";
                    msk_tc.Text = "";
                    rch_adres.Text = "";
                    nmr_bakiye.Value = nmr_bakiye.Minimum;
                    txt_ehliyet.Text = "";
                    msk_telefon.Text = "";
                    txt_email.Text = "";
                }
            }
        }
    }
}
