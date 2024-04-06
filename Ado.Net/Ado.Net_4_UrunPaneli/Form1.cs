using System.Data;
using System.Data.SqlClient;

namespace Ado.Net_4_UrunPaneli
{
    public partial class Form1 : Form
    {
        // Entity Framework =>  DatabaseFirst

        SqlConnection connect = new SqlConnection("Data Source=204-HOCAPC1\\SQLDERS; Initial Catalog=ManavDB; Integrated Security=true");
        public Form1()
        {
            InitializeComponent();
            ProductLoad();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_price.Text))
            {
                MessageBox.Show("Boþ geçilemez");
            }

            Product p = new Product()
            {
                Name = txt_name.Text,
                Price = Convert.ToDouble(txt_price.Text),
                Stock = (int)nmr_stock.Value
            };


            SqlCommand cmd = new SqlCommand("Insert into Product (Name,Price,Stock) values (@ad,@fiyat,@stok)", connect);

            cmd.Parameters.Add("@ad", SqlDbType.VarChar).Value = p.Name;
            cmd.Parameters.Add("@fiyat", SqlDbType.Decimal).Value = p.Price;
            cmd.Parameters.Add("@stok", SqlDbType.Int).Value = p.Stock;


            connect.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Kayýt Baþarýlý");
                txt_name.Text = "";
                txt_price.Clear();
                nmr_stock.Value = 0;

            }
            connect.Close();
            ProductLoad();
        }

        private void ProductLoad()
        {
            lstView.Items.Clear();
            List<Product> products = new List<Product>();

            SqlCommand cmd = new SqlCommand("Select * from Product", connect);

            connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                Product p = new Product()
                {
                    Id = (int)reader[0],
                    Name = reader[1].ToString(),
                    Price = Convert.ToDouble(reader[2]),
                    Stock = (int)reader[3]
                };

                ListViewItem lvi = new ListViewItem();
                lvi.Text = p.Id.ToString();
                lvi.SubItems.Add(p.Name);
                lvi.SubItems.Add(p.Price.ToString());
                lvi.SubItems.Add(p.Stock.ToString());

                lstView.Items.Add(lvi);

                //DatagridView alaný
                products.Add(p);
            }
            dt_products.DataSource = products;
            connect.Close();
        }
        Product databaseProduct = null;
        private void lstView_DoubleClick(object sender, EventArgs e)
        {
            ListView listView = (ListView)sender;
            ListViewItem seciliLvi = listView.SelectedItems[0];
            databaseProduct = GetById(Convert.ToInt32(seciliLvi.Text));

            if (databaseProduct != null)
            {
                nmr_Id.Value = databaseProduct.Id;
                txt_name.Text = databaseProduct.Name;
                txt_price.Text = databaseProduct.Price.ToString();
                nmr_stock.Value = databaseProduct.Stock;
            }
        }

        private Product GetById(int id)
        {
            SqlCommand cmd = new SqlCommand("Select * from Product where Id=@id", connect);

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            Product product = new Product();

            connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                product.Id = reader.GetInt32(0);
                product.Name = reader.GetString(1);
                product.Price = (double)reader.GetDecimal(2);
                product.Stock = reader.GetInt32(3);
            }
            connect.Close();
            return product;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int Id = (int)nmr_Id.Value;

            SqlCommand cmd = new SqlCommand("update Product set Name=@urunAd,Price=@fiyat,Stock=@stok where Id=@Id", connect);

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            cmd.Parameters.Add("@urunAd", SqlDbType.VarChar).Value = txt_name.Text;
            cmd.Parameters.Add("@fiyat", SqlDbType.Decimal).Value = txt_price.Text;
            cmd.Parameters.Add("@stok", SqlDbType.Int).Value = nmr_stock.Value;

            connect.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Güncelleme Baþarýlý");
                txt_name.Text = "";
                txt_price.Clear();
                nmr_stock.Value = 0;

            }
            connect.Close();
            ProductLoad();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (databaseProduct != null)
            {
                SqlCommand cmd = new SqlCommand($"Delete from product where Id={databaseProduct.Id}", connect);

                connect.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Silme Baþarýlý");
                    txt_name.Text = "";
                    txt_price.Clear();
                    nmr_stock.Value = 0;
                }
                connect.Close();
                ProductLoad();
            }
        }
    }
}
