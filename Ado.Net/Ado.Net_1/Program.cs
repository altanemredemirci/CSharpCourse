using System.Data.SqlClient;

namespace Ado.Net_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ADO.NET 
             
             C# ile MSSQL arasında iletişim kurmamızı yani sql komutlarını .net tarafında yazıp sql e gönderip çalışmamızı sağlar.

            1-ConnectionString

             */

            SqlConnection connect = new SqlConnection("Data Source=204-HOCAPC1\\SQLDERS; Initial Catalog=OkulDB; Integrated Security=true");
            connect.Open();
            Console.WriteLine("Bağlantı Yapıldı");
            connect.Close();
            Console.WriteLine("Bağlantı Kapatıldı");
        }
    }
}
