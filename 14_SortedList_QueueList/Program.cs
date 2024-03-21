using System.Collections;

namespace _14_SortedList_QueueList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SortedList sozluk = new SortedList() {
            //    {"Bugun","Today"},
            //    {"Yarin","Tommorrow"},
            //    {"Hava","Wheather" },
            //    {"Gokyuzu","Sky" },
            //    {"Karli","Snowy" },
            //    {"Gunesli","Sunny" },
            //    {"Bulutlu","Cloudy" },
            //    {"Acik","Clear" },
            //    {"Kapali","Cloudy" },
            //    {"Mahmut",1 },
            //    {"Kamil",2 },
            //    //{3,"HATA" } // HATA Verir. Key tipleri aynı olmalıdır.
            //};

            //Console.WriteLine(sozluk["Bugun"]);

            //sozluk["Gunes"] = "Sun";


            //foreach (var item in sozluk)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Sadece KEYS");
            //foreach (var item in sozluk.Keys)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Sadece VALUES");
            //foreach (var item in sozluk.Values)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (DictionaryEntry item in sozluk)
            //{
            //    Console.Write(item.Key);
            //    Console.WriteLine(item.Value);
            //}

            //sozluk.Remove("Sun"); // key verilmelidir.
            //sozluk.RemoveAt(0); // key verilmelidir.


            //sozluk["Gunes"] = "Sun"; // Aynı key ikinci defa eklenemez.

            //foreach (var item in sozluk)
            //{
            //    Console.WriteLine(item);
            //}

            #region Dictionary Example
            /*

         sözlük uygulaması istenmektedir.Tr - Eng
         sözlük = { "siyah":"black",,,,}
            kullanıcı 4 girene kadar sorulur.
             1 - Arama
             2 - Çıkarma
             3 - Listeleme
             4 - Çıkış

        Kullanıcı 1'e basarsa ->
            - Aranacak olan kelimeyi giriniz:
                -Bu kelime dizide varsa eng karşılığı yazılır.
            -Yoksa uygulamanın gelişmesine yardımcı olmak ister msiniz(E-H):
                -E ise bu kelimenin karşılığı istenir ve sözlüğe eklenir
                -H ise bişey yapılmaz
        Kullanıcı 2'ye basarsa ->
            - Çıkarılmak istenen kelime :
            -Kelime sözlükte varsa çıkartılır
            - Yoksa uyarı verilir.
        Kullanıcı 3'e basarsa ->
            - Tum key value lar listelenir
            -KEY->VALUE
        Kullanıcı 4'e basarsa ->
            - Döngü sonlanır.
*/

            //SortedList sozluk = new SortedList()
            //{
            //    {"siyah","black"},
            //    {"mavi","blue" }
            //};

            //while (true)
            //{
            //    Console.WriteLine("1-Arama\n2-Çıkarma\n3-Listeleme\n4-Çıkış");
            //    int secim = Convert.ToInt32(Console.ReadLine());

            //    if (secim == 1) 
            //    {
            //        Console.WriteLine("Arana Kelime:");
            //        string kelime = Console.ReadLine();

            //        if (sozluk.Contains(kelime))
            //        {
            //            Console.WriteLine(kelime+":"+sozluk[kelime]);
            //        }
            //        else
            //        {
            //            Console.WriteLine("kelime bulunamadı. Geliştirmeye yardım etmek için siz eklemek ister misiniz?");
            //            string cevap = Console.ReadLine().ToUpper();

            //            if (cevap == "E")
            //            {
            //                Console.WriteLine("İngilizce karşılığı:");
            //                sozluk[kelime] = Console.ReadLine();
            //            }
            //            else
            //            {
            //                Console.WriteLine("Sen bilirsin!!");
            //            }
            //        }

            //    }
            //    else if (secim == 2) 
            //    {
            //        Console.WriteLine("Çıkarılacak Kelime:");
            //        string kelime = Console.ReadLine();

            //        if (sozluk.ContainsKey(kelime))
            //        {
            //            sozluk.Remove(kelime);
            //            Console.WriteLine("İşlem başarılı");
            //        }
            //        else
            //        {
            //            Console.WriteLine(kelime+" zaten mevcut değil..");
            //        }

            //    }
            //    else if (secim == 3) 
            //    {
            //        foreach (DictionaryEntry item in sozluk)
            //        {
            //            Console.WriteLine(item.Key+"=>"+item.Value);
            //        }
            //    }
            //    else if (secim == 4) 
            //    {
            //        break;
            //    }
            //    else  { Console.WriteLine("Hatalı Tuşlama"); }
            //}


            #endregion


            //string metin = "aLTAN";

            //metin=metin.BasharfBuyut();
            //Console.WriteLine(metin);


            Queue kuyruk = new Queue();
            kuyruk.Enqueue(10);
            kuyruk.Enqueue(20);
            kuyruk.Enqueue(30);
            kuyruk.Enqueue(40);
            kuyruk.Enqueue("50");

            //Console.WriteLine(kuyruk.Peek());
            //Console.WriteLine(kuyruk.Peek());
            //Console.WriteLine(kuyruk.Peek());



            int sayi = (int)kuyruk.Dequeue();
            int sayi2 = (int)kuyruk.Dequeue();

            foreach (var item in kuyruk)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(sayi);

        }
    }

   
}
