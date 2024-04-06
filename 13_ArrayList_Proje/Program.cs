using System.Collections;
using System.Collections.Generic;

namespace _13_ArrayList_Proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MANAV OTOMASYONU
            /*
             * Senaryo: Manav hale gidecek. Halden belirli kilolarda meyve,sebze alacak.Almış olduğu ürünleri kendi tezgehınde müşteriye satacak. 
            1-HAL BÖLÜMÜ
                1-meyve mi sebze mi? m/s
                2-5 adet meyve ekrana yazdırılacak
                3-Manav istediği ürüün seçecek.
                4-Kaç kilo diye sorulacak. Halde bir stok olayı yoktur. Manav istediği kadar kiloda ürün alabilir.
                5-Başka bir arzunuz var mı? E/H E=> 1 H=> Manav bölümü geçtik
                    * Aynı ürün iki defa eklenmesin
                    * Aynı üründen birden fazla kez alırsa kilolar toplansın.

            2-MANAV BÖLÜMÜ
                1-meyve mi sebze mi? m/s
                2-Manav müşterinin seçimine göre halden aldığı meyve veya sebzeleri listeleyecek
                3-Müşteri ürün seçtikten sonra kaç kilo diye sorulacak ve alınan kilo kadar satılabilienecek.
                4-Başka bir arzunuz var mı? E/H E=> 1 H=> Müşteri bölümü geçtik
            3-MÜŞTERİ BÖLÜMÜ
                1-Alınan ürünleri yazdır.
             
             */

            #region SERCİHAN
            //    ArrayList sepet = new ArrayList();
            //    ArrayList sepetKilo = new ArrayList();
            //    ArrayList musteriSepet = new ArrayList();
            //    ArrayList musteriSepetKilo = new ArrayList();
            //    ArrayList meyveler = new ArrayList();
            //    ArrayList sebzeler = new ArrayList();
            //    meyveler.Add("elma");
            //    meyveler.Add("armut");
            //    meyveler.Add("portakal");
            //    meyveler.Add("çilek");
            //    meyveler.Add("muz");
            //    sebzeler.Add("pırasa");
            //    sebzeler.Add("marul");
            //    sebzeler.Add("havuç");
            //    sebzeler.Add("patates");
            //    sebzeler.Add("soğan");

            //    while (true) // MÜŞTERİ
            //    {
            //        while (true) // MANAV
            //        {
            //            while (true) // HAL
            //            {
            //                Console.Clear();
            //                Console.WriteLine("Hale Hoşgeldiniz");
            //                Console.WriteLine("Meyve Almak İçin M, Sebze Almak İçin S Yazın.");
            //                string meyveSebzeSecim = Console.ReadLine().ToLower();
            //                if (meyveSebzeSecim == "m")
            //                {
            //                    for (int i = 0; i < meyveler.Count; i++)
            //                    {
            //                        Console.WriteLine(meyveler[i] + " İçin " + (i + 1));
            //                    }
            //                    int meyveSecim = Convert.ToInt32(Console.ReadLine());
            //                    Console.WriteLine("Kaç Kilo " + meyveler[meyveSecim - 1] + " Almak İstiyorsunuz ?");
            //                    int kiloSecim = Convert.ToInt32(Console.ReadLine());
            //                    if (sepet.Contains(meyveler[meyveSecim - 1]))
            //                    {
            //                        int index = sepet.IndexOf(meyveler[meyveSecim - 1]);
            //                        int urunKilosu = (int)sepetKilo[index];
            //                        sepetKilo[index] = urunKilosu + kiloSecim;

            //                        Console.WriteLine("Başka Bir İsteğiniz Var Mı ? (E/H)");
            //                        string arzu = Console.ReadLine().ToLower();
            //                        if (arzu == "e")
            //                        {
            //                            continue;
            //                        }
            //                        else
            //                        {
            //                            break;
            //                        }
            //                    }
            //                    else
            //                    {
            //                        sepet.Add(meyveler[meyveSecim - 1]);
            //                        sepetKilo.Add(kiloSecim);
            //                        Console.WriteLine("Başka Bir İsteğiniz Var Mı ? (E/H)");
            //                        string arzu = Console.ReadLine().ToLower();
            //                        if (arzu == "e")
            //                        {
            //                            continue;
            //                        }
            //                        else
            //                        {
            //                            break;
            //                        }
            //                    }

            //                }
            //                else if (meyveSebzeSecim == "s")
            //                {
            //                    for (int i = 0; i < sebzeler.Count; i++)
            //                    {
            //                        Console.WriteLine(sebzeler[i] + " İçin " + (i + 1));
            //                    }
            //                    int sebzeSecim = Convert.ToInt32(Console.ReadLine());
            //                    Console.WriteLine("Kaç Kilo " + sebzeler[sebzeSecim - 1] + " Almak İstiyorsunuz ?");
            //                    int kiloSecim = Convert.ToInt32(Console.ReadLine());
            //                    if (sepet.Contains(sebzeler[sebzeSecim - 1]))
            //                    {
            //                        int index = sepet.IndexOf(sebzeler[sebzeSecim - 1]);
            //                        int urunKilosu = (int)sepetKilo[index];
            //                        sepetKilo[index] = urunKilosu + kiloSecim;

            //                        Console.WriteLine("Başka Bir İsteğiniz Var Mı ? (E/H)");
            //                        string arzu = Console.ReadLine().ToLower();
            //                        if (arzu == "e")
            //                        {
            //                            continue;
            //                        }
            //                        else
            //                        {
            //                            break;
            //                        }
            //                    }
            //                    else
            //                    {
            //                        sepet.Add(sebzeler[sebzeSecim - 1]);
            //                        sepetKilo.Add(kiloSecim);
            //                        Console.WriteLine("Başka Bir İsteğiniz Var Mı ? (E/H)");
            //                        string arzu = Console.ReadLine().ToLower();
            //                        if (arzu == "e")
            //                        {
            //                            continue;
            //                        }
            //                        else
            //                        {
            //                            break;
            //                        }
            //                    }
            //                }
            //                else
            //                {
            //                    Console.Clear();
            //                    Console.WriteLine("Hatalı Seçim\n");
            //                    continue;
            //                }
            //            } // HAL
            //            while (true)
            //            {
            //                Console.Clear();
            //                Console.WriteLine("Manava Hoşgeldiniz");
            //                Console.WriteLine("Meyve Almak İçin M, Sebze Almak İçin S Yazın.");
            //                string meyveSebzeSecim2 = Console.ReadLine().ToLower();
            //                if (meyveSebzeSecim2 == "m")
            //                {
            //                    for (int i = 0; i < sepet.Count; i++)
            //                    {
            //                        if (meyveler.Contains(sepet[i]))
            //                        {
            //                            Console.WriteLine("Ürün: " + sepet[i] + " Stok: " + sepetKilo[i] + " kg");
            //                        }
            //                        else
            //                        {
            //                            continue;
            //                        }
            //                    }
            //                    Console.WriteLine("Almak İstediğiniz Ürünü Yazın");
            //                    string alUrunManav = Console.ReadLine().ToLower();
            //                    if (sepet.Contains(alUrunManav))
            //                    {
            //                        Console.WriteLine("Kaç Kilo Alacağınızı Yazın");
            //                        int alKilo = Convert.ToInt32(Console.ReadLine());
            //                        int index = sepet.IndexOf(alUrunManav);
            //                        if ((int)sepetKilo[index] >= alKilo)
            //                        {
            //                            Console.WriteLine("Ürün Sepetinize Eklendi");
            //                            musteriSepet.Add(alUrunManav);
            //                            musteriSepetKilo.Add(alKilo);
            //                            int urunAzalt = (int)sepetKilo[index];
            //                            urunAzalt -= alKilo;
            //                            sepetKilo[index] = urunAzalt;
            //                            Console.WriteLine("Başka Bir İsteğiniz Var mı ? (E/H)");
            //                            string arzu = Console.ReadLine().ToLower();
            //                            if (arzu == "e")
            //                            {
            //                                continue;
            //                            }
            //                            else
            //                            {
            //                                break;
            //                            }
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("Stokta Yeterli Ürün Yok");
            //                        }
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Yanlış Ürün Seçimi");
            //                    }
            //                }
            //                else if (meyveSebzeSecim2 == "s")
            //                {
            //                    for (int i = 0; i < sepet.Count; i++)
            //                    {
            //                        if (sebzeler.Contains(sepet[i]))
            //                        {
            //                            Console.WriteLine("Ürün: " + sepet[i] + " Stok: " + sepetKilo[i] + " kg");
            //                        }
            //                        else
            //                        {
            //                            continue;
            //                        }
            //                    }
            //                    Console.WriteLine("Almak İstediğiniz Ürünü Yazın");
            //                    string alUrunManav = Console.ReadLine().ToLower();
            //                    if (sepet.Contains(alUrunManav))
            //                    {
            //                        Console.WriteLine("Kaç Kilo Alacağınızı Yazın");
            //                        int alKilo = Convert.ToInt32(Console.ReadLine());
            //                        int index = sepet.IndexOf(alUrunManav);
            //                        if ((int)sepetKilo[index] >= alKilo)
            //                        {
            //                            Console.WriteLine("Ürün Sepetinize Eklendi");
            //                            musteriSepet.Add(alUrunManav);
            //                            musteriSepetKilo.Add(alKilo);
            //                            int urunAzalt = (int)sepetKilo[index];
            //                            urunAzalt -= alKilo;
            //                            sepetKilo[index] = urunAzalt;
            //                            Console.WriteLine("Başka Bir İsteğiniz Var mı ? (E/H)");
            //                            string arzu = Console.ReadLine().ToLower();
            //                            if (arzu == "e")
            //                            {
            //                                continue;
            //                            }
            //                            else
            //                            {
            //                                break;
            //                            }
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("Stokta Yeterli Ürün Yok");
            //                        }
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Yanlış Ürün Seçimi");
            //                    }
            //                }
            //                else
            //                {
            //                    Console.Clear();
            //                    Console.WriteLine("Yanlış Seçim");
            //                    continue;
            //                }
            //            }
            //        }//MANAV

            //        MusteriYazdir(musteriSepet, musteriSepetKilo);
            //    }  // MÜŞTERİ
            //    static void MusteriYazdir(ArrayList musteriSepet, ArrayList musteriSepetKilo)
            //    {
            //        Console.Clear();
            //        for (int i = 0; i < musteriSepet.Count; i++)
            //        {
            //            Console.WriteLine("Ürün: " + musteriSepet[i] + " Kilo: " + musteriSepetKilo[i]);
            //        }
            //    }
            //}
            #endregion


            #region UĞUR
            //ArrayList toptanciMeyve = new ArrayList() { "ELMA", "ARMUT", "ÇİLEK", "ŞEFTALİ", "MUZ" };
            //ArrayList toptanciSebze = new ArrayList() { "DOMATES", "SALATALIK", "HAVUÇ", "LİMON", "BİBER" };
            //ArrayList manavmeyve = new ArrayList();
            //ArrayList manavsebze = new ArrayList();
            //ArrayList manavkilomeyve = new ArrayList();
            //ArrayList manavkilosebze = new ArrayList();
            //ArrayList musteri = new ArrayList();
            //ArrayList musterikilo = new ArrayList();

            //Console.WriteLine("*************HOŞGELDİNİZ**************\n");


            //while (true)
            //{
            //    while (true)
            //    {
            //        Console.WriteLine("********MEYVE SEBZE HALİNE HOŞGELDİNİZ*********\n");
            //        Console.WriteLine("Meyve için -M- Sebze için -S- ye basınız?");
            //        string halSecim = Console.ReadLine().ToUpper();

            //        if (halSecim == "M")
            //        {
            //            Console.WriteLine("*\n");
            //            foreach (var item in toptanciMeyve)
            //            {
            //                Console.WriteLine(item);
            //            }
            //            Console.WriteLine("\n*");

            //            Console.WriteLine("Hangi üründen almak istersiniz?");
            //            string manavAlisveris = Console.ReadLine().ToUpper();

            //            if (toptanciMeyve.IndexOf(manavAlisveris) >= 0)
            //            {
            //                Console.Write("\nKaç kilo almak istersiniz?");
            //                int alisveriskilo = Convert.ToInt32(Console.ReadLine());

            //                if (manavmeyve.IndexOf(manavAlisveris) >= 0)
            //                {
            //                    manavkilomeyve[manavmeyve.IndexOf(manavAlisveris)] = (int)manavkilomeyve[manavmeyve.IndexOf(manavAlisveris)] + alisveriskilo;

            //                    string cevap = BaskaArzunuz();

            //                    if (cevap == "E")
            //                    {
            //                        continue;


            //                    }
            //                    else if (cevap == "H")
            //                    {
            //                        break;
            //                    }

            //                }

            //                else
            //                {
            //                    manavmeyve.Add(manavAlisveris);
            //                    manavkilomeyve.Add(alisveriskilo);

            //                    string cevap = BaskaArzunuz();

            //                    if (cevap == "E")
            //                    {
            //                        continue;

            //                    }
            //                    else if (cevap == "H")
            //                    {
            //                        break;
            //                    }
            //                }

            //            }
            //            else
            //            {
            //                Console.WriteLine("Maalesef" + manavAlisveris + " tükenmiştir.");
            //                string cevap = BaskaArzunuz();


            //                if (cevap == "E")
            //                {
            //                    continue;


            //                }
            //                else if (cevap == "H")
            //                {
            //                    break;
            //                }
            //            }




            //        }
            //        else if (halSecim == "S")
            //        {
            //            Console.WriteLine("*\n");
            //            foreach (var item in toptanciSebze)
            //            {
            //                Console.WriteLine(item);
            //            }
            //            Console.WriteLine("\n*");

            //            Console.WriteLine("Hangi üründen almak istersiniz?");
            //            string manavAlisveris = Console.ReadLine().ToUpper();


            //            if (toptanciSebze.IndexOf(manavAlisveris) >= 0)
            //            {
            //                Console.Write("\nKaç kilo almak istiyorsunuz ?  >>>=  ");
            //                int alisveriskilo = Convert.ToInt32(Console.ReadLine());

            //                if (manavsebze.IndexOf(manavAlisveris) >= 0)
            //                {
            //                    manavkilosebze[manavsebze.IndexOf(manavAlisveris)] = (int)manavkilosebze[manavsebze.IndexOf(manavAlisveris)] + alisveriskilo;
            //                    string cevap = BaskaArzunuz();

            //                    if (cevap == "E")
            //                    {
            //                        continue;
            //                    }
            //                    else
            //                    {
            //                        break;
            //                    }
            //                }
            //                else
            //                {
            //                    manavsebze.Add(manavAlisveris);
            //                    manavkilosebze.Add(alisveriskilo);

            //                    string cevap = BaskaArzunuz();

            //                    if (cevap == "E")
            //                    {
            //                        continue;


            //                    }
            //                    else if (cevap == "H")
            //                    {
            //                        break;
            //                    }
            //                }

            //            }
            //            else
            //            {
            //                Console.WriteLine("Maalesef" + manavAlisveris + " tükenmiştir.");

            //                string cevap = BaskaArzunuz();
            //                if (cevap == "E")
            //                {
            //                    continue;


            //                }
            //                else if (cevap == "H")
            //                {
            //                    break;
            //                }
            //            }

            //        }

            //    }
            //    while (true)
            //    {
            //        Console.WriteLine("-----------------------------------------------------");
            //        Console.WriteLine("\n********************MANAVA HOŞGELDİNİZ*******************");

            //        Console.WriteLine("Meyve için M Sebze için S ye basınız?");
            //        string manavsecim = Console.ReadLine().ToUpper();

            //        if (manavsecim == "M")
            //        {
            //            Console.WriteLine("*\n");
            //            foreach (var item in manavmeyve)
            //            {
            //                Console.WriteLine(item);
            //            }
            //            Console.WriteLine("*\n");

            //            Console.WriteLine("Hangi üründen almak istersiniz?");
            //            string kiloilemanav = Console.ReadLine().ToUpper();

            //            int istek = manavmeyve.IndexOf(kiloilemanav);

            //            if (istek >= 0)
            //            {
            //                Console.WriteLine("\nKaç kilo almak istiyorsunuz?");
            //                int kilo = Convert.ToInt32(Console.ReadLine());
            //                if (kilo <= (int)manavkilomeyve[istek])
            //                {
            //                    if (musteri.IndexOf(kiloilemanav) >= 0)
            //                    {
            //                        musterikilo[musteri.IndexOf(kiloilemanav)] = (int)musterikilo[musteri.IndexOf(kiloilemanav)] + kilo;
            //                        manavkilomeyve[istek] = (int)manavkilomeyve[istek] - kilo;

            //                        if ((int)manavkilomeyve[istek] == 0)
            //                        {
            //                            manavmeyve.Remove(manavmeyve[istek]);
            //                        }

            //                        string cevap = BaskaArzunuz();

            //                        if (cevap == "E")
            //                        {
            //                            continue;


            //                        }
            //                        else if (cevap == "H")
            //                        {
            //                            break;
            //                        }
            //                    }
            //                    else
            //                    {
            //                        musteri.Add(manavmeyve[istek]);
            //                        musterikilo.Add(kilo);

            //                        manavkilomeyve[istek] = (int)manavkilomeyve[istek] - kilo;
            //                        if ((int)manavkilomeyve[istek] == 0)
            //                        {
            //                            manavmeyve.Remove(manavmeyve[istek]);
            //                        }
            //                        string cevap = BaskaArzunuz();

            //                        if (cevap == "E")
            //                        {
            //                            continue;
            //                        }
            //                        else
            //                        {
            //                            break;
            //                        }
            //                    }
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Maalesef elimizde " + (int)manavkilomeyve[istek] + " Kilo Kaldı");

            //                    string cevap = BaskaArzunuz();

            //                    if (cevap == "E")
            //                    {
            //                        continue;


            //                    }
            //                    else if (cevap == "H")
            //                    {
            //                        break;
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Maalesef ürün tükenmiştir.");

            //                string cevap = BaskaArzunuz();

            //                if (cevap == "E")
            //                {
            //                    continue;


            //                }
            //                else if (cevap == "H")
            //                {
            //                    break;
            //                }
            //            }

            //        }
            //        else if (manavsecim == "S")
            //        {
            //            foreach (var item in manavsebze)
            //            {
            //                Console.WriteLine(item);
            //            }
            //            Console.WriteLine("---------------------------------------------------");
            //            Console.WriteLine("Hangi Üründen amak istiyorsunuz?");
            //            string kiloilemanav = Console.ReadLine().ToUpper();
            //            int istek = manavsebze.IndexOf(kiloilemanav);
            //            if (istek >= 0)
            //            {
            //                Console.WriteLine("\nKaç kilo almak istiyorsunuz?");
            //                int kilo = Convert.ToInt32(Console.ReadLine());
            //                if (kilo <= (int)manavkilosebze[istek])
            //                {
            //                    if (musteri.IndexOf(kiloilemanav) >= 0)
            //                    {
            //                        musterikilo[musteri.IndexOf(kiloilemanav)] = (int)musterikilo[musteri.IndexOf(kiloilemanav)] + kilo;
            //                        manavkilosebze[istek] = (int)manavkilosebze[istek] - kilo;
            //                        if ((int)manavkilosebze[istek] == 0)
            //                        {
            //                            manavsebze.Remove(manavsebze[istek]);
            //                        }
            //                        string cevap = BaskaArzunuz();

            //                        if (cevap == "E")
            //                        {
            //                            continue;


            //                        }
            //                        else if (cevap == "H")
            //                        {
            //                            break;
            //                        }
            //                    }
            //                    else
            //                    {
            //                        musteri.Add(manavsebze[istek]);
            //                        musterikilo.Add(kilo);

            //                        manavkilosebze[istek] = (int)manavkilosebze[istek] - kilo;
            //                        if ((int)manavkilosebze[istek] == 0)
            //                        {
            //                            manavsebze.Remove(manavsebze[istek]);
            //                        }
            //                        string cevap = BaskaArzunuz();

            //                        if (cevap == "E")
            //                        {
            //                            continue;


            //                        }
            //                        else if (cevap == "H")
            //                        {
            //                            break;
            //                        }
            //                    }
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Maalesef elimizde " + (int)manavkilosebze[istek] + " kilo Kaldı");
            //                    string cevap = BaskaArzunuz();

            //                    if (cevap == "E")
            //                    {
            //                        continue;


            //                    }
            //                    else if (cevap == "H")
            //                    {
            //                        break;
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Maalesef ürün tükenmiştir.");
            //                string cevap = BaskaArzunuz();

            //                if (cevap == "E")
            //                {
            //                    continue;


            //                }
            //                else if (cevap == "H")
            //                {
            //                    break;
            //                }
            //            }
            //        }
            //    }
            //    while (true)
            //    {
            //        Console.WriteLine("*\n");
            //        Console.WriteLine("MÜŞTERİ LİSTESİ\n");

            //        for (int i = 0; i < musteri.Count; i++)
            //        {
            //            Console.WriteLine(musteri[i] + "---" + musterikilo[i] + " kilo");
            //        }
            //        break;
            //    }
            //    break;
            //}


            //Console.ReadLine();


            //static string BaskaArzunuz()
            //{

            //    Console.WriteLine("\nBaşka bir arzunuz var mı? Evet E veya Hayır H");
            //    string cevap = Console.ReadLine().ToUpper();


            //    return cevap;
            //}
            #endregion


            #region ALTAN EMRE
            //int ELMA = 0, ARMUT = 0, MUZ = 0, BIBER = 0, PATATES = 0, SOGAN = 0;
            //ArrayList manavMeyve = new ArrayList();
            //ArrayList manavSebze = new ArrayList();
            //ArrayList musteri = new ArrayList();

            //while (true)
            //{
            //    Console.WriteLine("******* HALE HOŞGELDİNİZ ********");
            //    Console.WriteLine("Meyve için M - Sebze için S - Çıkış için Q\nSeçiminiz:");
            //    string secim = Console.ReadLine().ToUpper();

            //    if (secim == "M")
            //    {
            //        Console.WriteLine("1-ELMA\n2-ARMUT\n3-MUZ\nSeçiminiz:");
            //        int halMeyve = Convert.ToInt32(Console.ReadLine());

            //        if (halMeyve == 1)
            //        {
            //            ELMA += Urun.HalUrunAl(manavMeyve, "ELMA");
            //        }
            //        else if (halMeyve == 2)
            //        {
            //            ARMUT += Urun.HalUrunAl(manavMeyve, "ARMUT");
            //        }
            //        else if (halMeyve == 3)
            //        {
            //            MUZ += Urun.HalUrunAl(manavMeyve, "MUZ");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Hatalı Meyve Seçimi!");
            //        }

            //    }
            //    else if (secim == "S")
            //    {
            //        Console.WriteLine("1-BIBER\n2-PATATES\n3-SOGAN\nSeçiminiz:");
            //        int halSebze = Convert.ToInt32(Console.ReadLine());

            //        if (halSebze == 1)
            //        {
            //            BIBER += Urun.HalUrunAl(manavSebze, "BIBER");
            //        }
            //        else if (halSebze == 2)
            //        {
            //            PATATES += Urun.HalUrunAl(manavSebze, "PATATES");
            //        }
            //        else if (halSebze == 3)
            //        {
            //            SOGAN += Urun.HalUrunAl(manavSebze, "SOGAN");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Hatalı Sebze Seçimi!");
            //        }
            //    }
            //    else if (secim == "Q")
            //    {
            //        Console.WriteLine("Yine Bekleriz..");
            //        Thread.Sleep(3000);
            //        Console.Clear();
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı Seçim!");
            //    }

            //    Console.WriteLine("Başka bir arzunuz var mı(E/H)?");
            //    string cevap = Console.ReadLine().ToUpper();

            //    if (cevap != "E") { break; }
            //    Console.Clear();
            //}

            //while (true)
            //{
            //    Console.WriteLine("******* MANAVA HOŞGELDİNİZ ********");
            //    Console.WriteLine("Meyve için M - Sebze için S - Çıkış için Q\nSeçiminiz:");
            //    string secim = Console.ReadLine().ToUpper();

            //    if (secim == "M")
            //    {
            //        foreach (string item in manavMeyve)
            //        {
            //            Console.WriteLine(item);
            //        }

            //        Console.WriteLine("Seçiminiz:");
            //        string manavSecim = Console.ReadLine().ToUpper();

            //        if (!manavMeyve.Contains(manavSecim))
            //        {
            //            Console.WriteLine("Olmayan meyve girişi!!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Kaç kilo istersiniz?");
            //            int kilo = Convert.ToInt32(Console.ReadLine());

            //            if (manavSecim == "ELMA")
            //            {
            //                if (ELMA >= kilo)
            //                {
            //                    ELMA -= kilo;
            //                    musteri.Add(manavSecim);
            //                    Console.WriteLine("Afiyet Olsun.");

            //                    if (ELMA == 0)
            //                    {
            //                        manavMeyve.Remove(manavSecim);
            //                    }
            //                }
            //                else
            //                {
            //                    Console.WriteLine($"Yetersiz kilo. Elimizde {ELMA} kilo ELMA var");
            //                }
            //            }
            //            else if (manavSecim == "ARMUT")
            //            {
            //                if (ARMUT >= kilo)
            //                {
            //                    ARMUT -= kilo;
            //                    musteri.Add(manavSecim);
            //                    Console.WriteLine("Afiyet Olsun.");
            //                    if (ARMUT == 0)
            //                    {
            //                        manavMeyve.Remove(manavSecim);
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine($"Yetersiz kilo. Elimizde {ARMUT} kilo ARMUT var");
            //                    }
            //                }
            //            }
            //            else if (manavSecim == "MUZ")
            //            {
            //                if (MUZ >= kilo)
            //                {
            //                    MUZ -= kilo;
            //                    musteri.Add(manavSecim);
            //                    Console.WriteLine("Afiyet Olsun.");
            //                    if (MUZ == 0)
            //                    {
            //                        manavMeyve.Remove(manavSecim);
            //                    }
            //                }
            //                else
            //                {
            //                    Console.WriteLine($"Yetersiz kilo. Elimizde {MUZ} kilo MUZ var");
            //                }
            //            }
            //        }

            //    }
            //    else if (secim == "S")
            //    {
            //        foreach (string item in manavMeyve)
            //        {
            //            Console.WriteLine(item);
            //        }

            //        Console.WriteLine("Seçiminiz:");
            //        string manavSecim = Console.ReadLine().ToUpper();

            //        if (!manavMeyve.Contains(manavSecim))
            //        {
            //            Console.WriteLine("Olmayan meyve girişi!!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Kaç kilo istersiniz?");
            //            int kilo = Convert.ToInt32(Console.ReadLine());

            //            if (manavSecim == "BIBER")
            //            {
            //                if (BIBER >= kilo)
            //                {
            //                    BIBER -= kilo;
            //                    musteri.Add(manavSecim);

            //                    if (BIBER == 0)
            //                    {
            //                        manavMeyve.Remove(manavSecim);
            //                    }
            //                }
            //                else
            //                {
            //                    Console.WriteLine($"Yetersiz kilo. Elimizde {BIBER} kilo BIBER var");
            //                }
            //            }
            //            else if (manavSecim == "PATATES")
            //            {
            //                if (PATATES >= kilo)
            //                {
            //                    PATATES -= kilo;
            //                    musteri.Add(manavSecim);

            //                    if (PATATES == 0)
            //                    {
            //                        manavMeyve.Remove(manavSecim);
            //                    }
            //                }
            //                else
            //                {
            //                    Console.WriteLine($"Yetersiz kilo. Elimizde {PATATES} kilo PATATES var");
            //                }
            //            }
            //            else if (manavSecim == "SOGAN")
            //            {
            //                if (SOGAN >= kilo)
            //                {
            //                    SOGAN -= kilo;
            //                    musteri.Add(manavSecim);

            //                    if (SOGAN == 0)
            //                    {
            //                        manavMeyve.Remove(manavSecim);
            //                    }
            //                }
            //                else
            //                {
            //                    Console.WriteLine($"Yetersiz kilo. Elimizde {SOGAN} kilo SOGAN var");
            //                }
            //            }
            //        }

            //    }
            //    else if (secim == "Q")
            //    {
            //        Console.WriteLine("Yine Bekleriz..");
            //        Thread.Sleep(3000);
            //        Console.Clear();
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı Seçim!");
            //    }
            //    Console.WriteLine("Başka bir arzunuz var mı(E/H)?");
            //    string cevap = Console.ReadLine().ToUpper();

            //    if (cevap != "E") { break; }
            //    Console.Clear();
            //}

            //foreach (var item in musteri)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            ArrayList manavMeyve = new ArrayList(); //{ELMA,ARMUT}
            ArrayList manavMKilo = new ArrayList();// {10,  45}
            ArrayList manavSebze = new ArrayList();
            ArrayList manavSKilo = new ArrayList();// {10,  45}

            ArrayList musteri = new ArrayList();

            while (true)
            {
                Console.WriteLine("******* HALE HOŞGELDİNİZ ********");
                Console.WriteLine("Meyve için M - Sebze için S - Çıkış için Q\nSeçiminiz:");
                string secim = Console.ReadLine().ToUpper();

                if (secim == "M")
                {
                    Console.WriteLine("1-ELMA\n2-ARMUT\n3-MUZ\nSeçiminiz:");
                    int halMeyve = Convert.ToInt32(Console.ReadLine());

                    if (halMeyve == 1)
                    {
                        Urun.HalUrunAl2(manavMeyve, "ELMA", manavMKilo);
                    }
                    else if (halMeyve == 2)
                    {
                        Urun.HalUrunAl2(manavMeyve, "ARMUT", manavMKilo);
                    }
                    else if (halMeyve == 3)
                    {
                        Urun.HalUrunAl2(manavMeyve, "MUZ", manavMKilo);
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Meyve Seçimi!");
                    }

                }
                else if (secim == "S")
                {
                    Console.WriteLine("1-BIBER\n2-PATATES\n3-SOGAN\nSeçiminiz:");
                    int halMeyve = Convert.ToInt32(Console.ReadLine());

                    if (halMeyve == 1)
                    {
                        Urun.HalUrunAl2(manavSebze, "BIBER", manavSKilo);
                    }
                    else if (halMeyve == 2)
                    {
                        Urun.HalUrunAl2(manavSebze, "PATATES", manavSKilo);
                    }
                    else if (halMeyve == 3)
                    {
                        Urun.HalUrunAl2(manavSebze, "SOGAN", manavSKilo);
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Meyve Seçimi!");
                    }

                }
                else if (secim == "Q")
                {
                    Console.WriteLine("Yine Bekleriz..");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim!");
                }

                Console.WriteLine("Başka bir arzunuz var mı(E/H)?");
                string cevap = Console.ReadLine().ToUpper();

                if (cevap != "E") { break; }
                Console.Clear();
            }

            while (true)
            {
                Console.WriteLine("******* MANAVA HOŞGELDİNİZ ********");
                Console.WriteLine("Meyve için M - Sebze için S - Çıkış için Q\nSeçiminiz:");
                string secim = Console.ReadLine().ToUpper();

                if (secim == "M")
                {
                    foreach (string item in manavMeyve)
                    {
                        Console.WriteLine(item);
                    }

                    Console.WriteLine("Seçiminiz:");
                    string manavSecim = Console.ReadLine().ToUpper();

                    if (!manavMeyve.Contains(manavSecim))
                    {
                        Console.WriteLine("Olmayan meyve girişi!!");
                    }
                    else
                    {
                        Urun.ManavUrunAl(manavMeyve, manavSecim, manavMKilo, musteri);
                    }

                }

                else if (secim == "S")
                {
                    foreach (string item in manavSebze)
                    {
                        Console.WriteLine(item);
                    }

                    Console.WriteLine("Seçiminiz:");
                    string manavSecim = Console.ReadLine().ToUpper();

                    if (!manavSebze.Contains(manavSecim))
                    {
                        Console.WriteLine("Olmayan sebze girişi!!");
                    }
                    else
                    {
                        Urun.ManavUrunAl(manavSebze, manavSecim, manavSKilo, musteri);
                    }

                }
                else if (secim == "Q")
                {
                    Console.WriteLine("Yine Bekleriz..");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim!");
                }
                Console.WriteLine("Başka bir arzunuz var mı(E/H)?");
                string cevap = Console.ReadLine().ToUpper();

                if (cevap != "E") { break; }
                Console.Clear();
            }

            foreach (var item in musteri)
            {
                Console.WriteLine(item);
            }
        }
    }

}
