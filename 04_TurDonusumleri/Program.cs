namespace _04_TurDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region TÜR DÖNÜŞÜMLERİ

            #region ********* BİLİNÇSİZ TÜR DÖNÜŞÜMÜ *********

            // Küçük tipin büyük tipe dönüşmesi
            //int sayi = 12;

            //decimal sayi2 = sayi;




            // Büyük tipin küçük tipe dönüşmesi

            //decimal sayi = 12345678909;
            //int sayi2 = (int)sayi; //Boxing

            //Console.WriteLine(sayi2);



            //byte a = 5;
            //short b = 10;
            //sbyte c = 30;
            //int d = a + b + c;
            //string e = "deneme";
            //char f = 'k';

            //object g= d+  e + f;

            //double k = 12.5f;
            //Console.WriteLine(k);




            //char a = 'k';

            //int b = a; // k harfinin ASCII kodunu gösterir.

            //Console.WriteLine(b);
            #endregion


            #region ******** BİLİNÇLİ TÜR DÖNÜŞÜMÜ **********


            //string sayi = "54";
            //Console.WriteLine(sayi + 10);


            //int sayi2 = Convert.ToInt32(sayi);
            //Console.WriteLine(sayi2+10);


            // 2 Sayı al topla ekrana yaz

            //Console.WriteLine("1.sayıyı giriniz");
            //int s1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2.sayıyı giriniz");
            //int s2 = int.Parse(Console.ReadLine());

            //Console.WriteLine(s1 + s2);



            // INTEGER TO STRING

            //int sayi = 44;
            //string sayi2 = sayi.ToString();
            //string sayi3 = Convert.ToString(sayi);


            #endregion

            DateTime date = new DateTime(2020, 12, 31);
            DateTime dateTime = new DateTime(2020, 12, 31,13,19,54);

            DateTime dateTimeNow = DateTime.Now;

            int year = dateTimeNow.Year;
            int year2 = DateTime.Now.Year;

            Console.WriteLine(dateTimeNow);
            Console.WriteLine(dateTimeNow.Year);
            Console.WriteLine(dateTimeNow.Month);
            Console.WriteLine(dateTimeNow.Day);
            Console.WriteLine(dateTimeNow.Hour);
            Console.WriteLine(dateTimeNow.Minute);
            Console.WriteLine(dateTimeNow.Second);
            Console.WriteLine(dateTimeNow.Date);
            Console.WriteLine(dateTimeNow.DayOfYear);
            Console.WriteLine(dateTimeNow.DayOfWeek);

            #endregion

            Console.WriteLine("Altan emre");


        }
    }
}
