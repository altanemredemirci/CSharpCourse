namespace Ado.Net_5_PersonelUygulamasi
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());

            /*
               
            1-Database kurulum ve tablo olu�turma
            2-Form alanlar� tasarland�.
            3-DAL ve BLL klas�rlerini a�t�k
            4-DAL alt�nda DataAccessLayer class� a��ld�.
            5-DataAccess.cs i�inde SqlConnectionString yaz�ld�.
            6-BLL alt�nda BusinessLayer class� a��ld�.
            7-Form - BusinessLayer - DataAccessLayer aras�ndaki ba�lant� CONSTRUCTOR metot sayesinde yap�ld�. 
            8-DataAccess.cs i�inde Baglant�y� kontrol etmek i�in BaglantiKontrol() yaz�ld�.
            9-SistemKullanici giri� kontrol� i�in DAL i�ine SistemGirisKontrol() yaz�ld�.
            10-DAL alan�nda SistemGirisKontrol() metodunu �a��rmas� i�in ayn� isimde Business alt�na bir method tan�mland�.
            11-Form alan�nda yap�lan Giris i�lemini Database'e iletmesi i�in BLL alt�ndaki SistemGirisKontrol() �a��rd�m.


             
             */

        }
    }
}