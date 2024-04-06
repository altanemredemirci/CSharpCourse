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
               
            1-Database kurulum ve tablo oluþturma
            2-Form alanlarý tasarlandý.
            3-DAL ve BLL klasörlerini açtýk
            4-DAL altýnda DataAccessLayer classý açýldý.
            5-DataAccess.cs içinde SqlConnectionString yazýldý.
            6-BLL altýnda BusinessLayer classý açýldý.
            7-Form - BusinessLayer - DataAccessLayer arasýndaki baðlantý CONSTRUCTOR metot sayesinde yapýldý. 
            8-DataAccess.cs içinde Baglantýyý kontrol etmek için BaglantiKontrol() yazýldý.
            9-SistemKullanici giriþ kontrolü için DAL içine SistemGirisKontrol() yazýldý.
            10-DAL alanýnda SistemGirisKontrol() metodunu çaðýrmasý için ayný isimde Business altýna bir method tanýmlandý.
            11-Form alanýnda yapýlan Giris iþlemini Database'e iletmesi için BLL altýndaki SistemGirisKontrol() çaðýrdým.


             
             */

        }
    }
}