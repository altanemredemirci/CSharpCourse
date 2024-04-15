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
    public partial class MusteriListele : Form
    {
        AdminManager adminManager;
        public MusteriListele()
        {
            InitializeComponent();
            adminManager = new AdminManager();
            dt_musteriListesi.DataSource = adminManager.MusteriListele();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
        }
    }
}
