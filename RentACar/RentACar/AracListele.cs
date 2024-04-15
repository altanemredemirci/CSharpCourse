using RentACar.BLL;
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
    public partial class AracListele : Form
    {
        AdminManager adminManager;
        public AracListele()
        {
            InitializeComponent();
            adminManager = new AdminManager();
            dt_aracListesi.DataSource = adminManager.ArabaListele();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
        }
    }
}
