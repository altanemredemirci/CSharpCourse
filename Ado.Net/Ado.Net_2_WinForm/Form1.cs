using System.Data;
using System.Data.SqlClient;

namespace Ado.Net_2_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("Data Source=204-HOCAPC1\\SQLDERS; Initial Catalog=OkulDB; Integrated Security=true");//Windows Authentication

            SqlCommand cmd = new SqlCommand("Insert into Ogrenci (Name,Address) values(@Ad,@Adres)",connect);

            cmd.Parameters.Add("@Ad", SqlDbType.VarChar).Value = txt_ad.Text;
            cmd.Parameters.Add("@Adres", SqlDbType.VarChar).Value = rch_adres.Text;

            connect.Open();
            int EKS = cmd.ExecuteNonQuery();
            if (EKS > 0)
                MessageBox.Show("Kayýt Baþarýlý");
            connect.Close();
        }
    }
}
