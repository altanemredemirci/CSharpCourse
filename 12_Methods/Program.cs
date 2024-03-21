using _12_Methods_1;

namespace _12_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* *********** METOTLAR ************
             
             Belirli bir işlemi bir başlık altında tanımlayarak, ihtiyaç duyulduğunda tanımlanan başlık ile çağırıp kullandığımız yazılım yapılarıdır.
            Metotlar sayesinde tanımlı işlemi ne zaman istersek metot ismini yazarak çağırabilir ve işlemi yapmasını sağlarız.
            Clean Code yazmak için en önemli yapılardandır. Kodlamanın okunabilirliğini muazzam arttırır.

            Metotlaarı () işaretleri tanımlar.  
            Metotlar iç içe tanımlanmazlar. SOLID prensipleri =>  Single

            Metotlar çağrılmadıkları sürece çalışmazlar.
            
            Metotlar 2'ye ayrılır.
                * Değer Döndürmeyen Metotlar (void)
                    *parametreli,parametresiz
                * Değer Döndüren Metotlar (return)
                    *parametreli,parametresiz    
            

            ****** DEGER DONDURMEYEN METOTLAR *******

            *** METOT TANIMLAMA
            
            static void MetotAd(optional params)
            {
                //Metot işlem kodları
            }

            *** METOT KULLANIMI
            
            MetotAd(params)

             */

            #region Tanım
            //Console.WriteLine("---------");
            //Console.WriteLine("---------");
            //Console.WriteLine("---------");
            //Console.WriteLine("---------");

            ////Toplama();
            ////Toplama();
            ////Toplama();
            ////Toplama();



            //Console.WriteLine("1.Sayı:");
            //int s1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.Sayı:");
            //int s2 = Convert.ToInt32(Console.ReadLine());

            //ToplamaParametreli(s1, s2);
            #endregion

            #region 1 Örnek Kullanıcıdan 2 sayı bir işlem alınız ve alınan sayılara istenilen işlemi uygulayarak ekran yazdıran metot
            //#region Buse
            //Console.WriteLine("1.sayıyı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.sayıyı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Toplama-1\nÇıkarma-2\nÇarpma-3\nBölme-4");
            //int secim = Convert.ToInt32(Console.ReadLine());

            //if (secim == 1)
            //{
            //    Toplama(sayi1, sayi2);
            //}
            //else if (secim == 2)
            //{
            //    Cikarma(sayi1, sayi2);
            //}
            //else if (secim == 3)
            //{
            //    Carpma(sayi1, sayi2);
            //}
            //else if (secim == 4)
            //{
            //    Bolme(sayi1, sayi2);
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı seçim");
            //}
            //#endregion




            #endregion

            Matemetik.Toplama(1,2);

            Matemetik.
        }

        #region Tanım
        //Parametresiz Metot
        //static void Toplama()
        //{
        //    Console.WriteLine("1.Sayı:");
        //    int s1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("2.Sayı:");
        //    int s2 = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Toplam:" + (s1 + s2));
        //}

        //Parametreli Metot
        /// <summary>
        /// Bu verilen 2 int değeri toplar
        /// </summary>
        /// <param name="sayi1">toplanacak 1.sayı</param>
        /// <param name="sayi2">toplanacak 2.sayı</param>

        //static void ToplamaParametreli(int sayi1, int sayi2)
        //{
        //    Console.WriteLine("Toplam:" + (sayi1 + sayi2));
        //}
        #endregion

        #region 1.Örnek
        #region  Buse
        //static void Toplama(int sayi1, int sayi2)
        //{
        //    Console.WriteLine("Toplam:" + (sayi1 + sayi2));
        //}
        //static void Cikarma(int sayi1, int sayi2)
        //{
        //    Console.WriteLine("Fark:" + (sayi1 - sayi2));
        //}
        //static void Carpma(int sayi1, int sayi2)
        //{
        //    Console.WriteLine("Carpim:" + (sayi1 * sayi2));
        //}
        //static void Bolme(int sayi1, int sayi2)
        //{
        //    Console.WriteLine("Bölüm:" + (sayi1 / sayi2));
        //}
        #endregion       


        #endregion



    }

}
