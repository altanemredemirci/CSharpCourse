using System.Data.SqlClient;

namespace Ado.Net_2_ExecuteNonQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connect = new SqlConnection("Data Source=204-HOCAPC1\\SQLDERS; Initial Catalog=OkulDB; Integrated Security=true");
           

            SqlCommand cmd = new SqlCommand("Insert into Ogrenci (Id,name,address) values(3,'Cengiz','Aymatov')",connect);

            connect.Open();
            int result = cmd.ExecuteNonQuery(); // Insert,Update,Delete işlemleri için kullanılır.

            if (result > 0)
            {
                Console.WriteLine("Kayıt Başarılı");
            }
            else
            {
                Console.WriteLine("Kayıt Başarısız!!");
            }

            connect.Close();
            Console.WriteLine("Bağlantı Kapatıldı");
        }
    }
}
