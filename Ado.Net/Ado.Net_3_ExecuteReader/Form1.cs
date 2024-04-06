using System.Data.SqlClient;

namespace Ado.Net_3_ExecuteReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            SqlConnection connect = new SqlConnection("Data Source=204-HOCAPC1\\SQLDERS; Initial Catalog=OkulDB; Integrated Security=true");

            SqlCommand command = new SqlCommand("Select * from Ogrenci", connect);

            connect.Open();
            SqlDataReader reader = command.ExecuteReader();

            //ListBox Loader
            //while (reader.Read()) // Her read edildiðinde bir satýr kayýt okur.
            //{
            //    int Id = reader.GetInt32(0);
            //    string ad = reader.GetString(1);
            //    string adres = reader.GetString(2);

            //    lst_ogrenciler.Items.Add(Id + " " + ad + " " + adres);

            //}

            //DataGridView Loader
            List<Ogrenci> ogrencis = new List<Ogrenci>();
            while (reader.Read()) // Her read edildiðinde bir satýr kayýt okur.
            {
                Ogrenci ogr = new Ogrenci();
                ogr.Id = (int)reader[0];
                ogr.Name = reader[1].ToString();
                ogr.Address = reader[2].ToString();

                ogrencis.Add(ogr);                
            }
            dt_ogrenciler.DataSource = ogrencis;


            connect.Close();
        }
    }
}
