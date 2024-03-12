namespace _07_While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /* LOOPS => 
                * While
                * For
                * Do While
                * Foreach
             
            Belirli bir iş tanımlayan kod bloklarını tekrar tekrar yazmaktan bizi kurtartır.


                
             
             */

            // 1-10 arasındaki sayıları ekran yazdırınız

            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);

            //int i = 1;

            //while (i < 21)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            #region 200 den başlayarak 0 a kadar olan ve 3'ün katı olan sayıları ekrana yazdırınız.

            //int i = 200;

            //while (i >= 0)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i--;
            //}

            #endregion


            #region 1 ile 5 arasındaki sayıların toplamını ekrana yazdırınız

            //int i = 1;

            //int toplam = 0;

            //while (i < 6)
            //{
            //    toplam = toplam + i;
            //    i++;
            //}

            #endregion


            #region 0 den başlayarak 200 a kadar olan ve 7'ün katı olan sayıların toplamını yazdırınız.
            //int i = 0;
            //int toplam = 0;

            //while (i < 200)
            //{
            //    if (i % 7 == 0)
            //    {
            //        toplam = toplam + i;                  
            //    }
            //    i++;
            //}

            //Console.WriteLine(toplam);
            #endregion


            #region Kullanıcıdan alınan başlangıç ve bitiş değerleri arasındaki sayıların çarpımını ekrana yazdırınız.

            Console.WriteLine("Lütfen bir baslangic değeri giriniz.");
            int baslangic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen bir bitis değeri giriniz.");
            int bitis = Convert.ToInt32(Console.ReadLine());

            if (baslangic > bitis)
            {
                int a = baslangic;
                baslangic = bitis;
                bitis = a;
            }

            int carpim = 1;

            while (baslangic < bitis)

            {
                carpim = carpim * baslangic;
                baslangic++;


            }
            Console.WriteLine("Baslangıc ve bitiş değerleri arasındaki sayıların carpimi:"+(carpim));


            #endregion
        }
    }
}
