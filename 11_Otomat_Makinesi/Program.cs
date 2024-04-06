namespace _11_Otomat_Makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 

             Müşteri Daha önceden tanımlanmış bir ürün listesinden bir ürün seçecek. 
            Para girişi yapacak. Girilen para seçilen ürünün fiyatını karşılar ise ürün alındı, aksi durumda para ekle seçeneği ile tekrar para girmesi sağlanacak.

             // Admin => Ürün Ekleyecek, Ürün Güncelleyecek, Ürün Silecek, Fiyat Güncelleyecek
             */

            string[] urunler = new string[5];
            double[] fiyatlar = new double[5];

            urunler[0] = "Kola";
            urunler[1] = "Fanta";
            urunler[2] = "Ayran";
            urunler[3] = "Şalgam";

            fiyatlar[0] = 10;
            fiyatlar[1] = 15;
            fiyatlar[2] = 13;
            fiyatlar[3] = 12;

            while (true)
            {
                for (int i = 0; i < urunler.Length; i++)
                {
                    if (urunler[i] != null)
                    {
                        Console.WriteLine(i + "-" + urunler[i] + ":" + fiyatlar[i]);
                    }
                }

                Console.WriteLine("Ürün Numarası:");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim >= 0 && secim < urunler.Length)
                {
                    double bakiye = 0;
                    while (true)
                    {
                        Console.WriteLine("Para Girişi Yapınız..");
                        bakiye += Convert.ToDouble(Console.ReadLine());

                        if (bakiye >= fiyatlar[secim])
                        {
                            Console.WriteLine("Afiyet Olsun");
                            Console.WriteLine("Para Üstünü Alınız:" + (bakiye - fiyatlar[secim]));
                            Console.WriteLine("Yine Bekleriz.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"İstenilen Ürün Fiyatı:{fiyatlar[secim]}. Bakiyeniz:{bakiye}. Para Eklenecek Mi?(E/H)");
                            string cevap = Console.ReadLine().ToLower();
                            if (cevap == "e")
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Paranız İade Edildi:" + bakiye);                                
                                break;
                            }
                        }
                    }

                }
                else if (secim == 1122)
                {
                    while (true)
                    {
                        Console.WriteLine("1-Ürün Ekle\n2-Ürün Sil\n3-Ürün Güncelle\n4-Ürün Listele\n5-Çıkış\nSeçiminiz:");
                        int adminSecim = Convert.ToInt32(Console.ReadLine());

                        if (adminSecim == 1)
                        {
                            Console.WriteLine("Ürün Adı:");
                            string urunAd = Console.ReadLine();

                            Console.WriteLine("Ürün Fiyatı:");
                            double urunFiyat = Convert.ToDouble(Console.ReadLine());

                            bool bosMu = false;
                            for (int i = 0; i < urunler.Length; i++)
                            {
                                if (urunler[i] == null)
                                {
                                    urunler[i] = urunAd;
                                    fiyatlar[i] = urunFiyat;
                                    bosMu = true;
                                    break;
                                }
                            }

                            if (bosMu == false)
                            {
                                Array.Resize(ref urunler, urunler.Length + 1);
                                Array.Resize(ref fiyatlar, fiyatlar.Length + 1);

                                urunler[urunler.Length - 1] = urunAd;
                                fiyatlar[fiyatlar.Length - 1] = urunFiyat;
                            }


                            #region 2.Yol SERCİHAN

                            //for (int i = 0; i < urunler.Length; i++)
                            //{
                            //    if (urunler[i] == null)
                            //    {
                            //        urunler[i] = urunAd;
                            //        fiyatlar[i] = urunFiyat;                                   
                            //    }
                            //    else if (i == urunler.Length - 1)
                            //    {
                            //        Array.Resize(ref urunler, urunler.Length + 1);
                            //        Array.Resize(ref fiyatlar, fiyatlar.Length + 1);

                            //        urunler[urunler.Length - 1] = urunAd;
                            //        fiyatlar[fiyatlar.Length - 1] = urunFiyat;
                            //    }
                            //}
                            #endregion
                            Console.Clear();
                        }
                        else if (adminSecim == 2) 
                        {
                            for (int i = 0; i < urunler.Length; i++)
                            {
                                Console.WriteLine(i + "-" + urunler[i] + ":" + fiyatlar[i]);
                            }
                            Console.WriteLine("Silinecek Ürün Numarası:");
                            int silinecekUrun = Convert.ToInt32(Console.ReadLine());

                            if(silinecekUrun>=0 && silinecekUrun < urunler.Length)
                            {
                                Array.Clear(urunler, silinecekUrun, 1);
                                Array.Clear(fiyatlar, silinecekUrun, 1);
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Ürün Seçimi!");
                            }

                        }
                        else if (adminSecim == 3) 
                        {
                            for (int i = 0; i < urunler.Length; i++)
                            {
                                Console.WriteLine(i + "-" + urunler[i] + ":" + fiyatlar[i]);
                            }
                            Console.WriteLine("Güncellenecek Ürün Numarası:");
                            int guncellenecekUrun = Convert.ToInt32(Console.ReadLine());

                            if (guncellenecekUrun >= 0 && guncellenecekUrun < urunler.Length)
                            {
                                Console.WriteLine("Ürün Adı:");
                                string urunAd = Console.ReadLine();

                                Console.WriteLine("Ürün Fiyatı:");
                                double urunFiyat = Convert.ToDouble(Console.ReadLine());

                                urunler[guncellenecekUrun] = urunAd;
                                fiyatlar[guncellenecekUrun] = urunFiyat;

                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Ürün Seçimi!");
                            }
                        }
                        else if (adminSecim == 4)
                        {
                            for (int i = 0; i < urunler.Length; i++)
                            {
                                Console.WriteLine(i + "-" + urunler[i] + ":" + fiyatlar[i]);
                            }
                        }
                        else if (adminSecim == 5) { Console.Clear(); break; }

                        else
                        {
                            Console.WriteLine("Hatalı Seçim!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı Ürün Seçimi!");
                }
            }
           


        }
    }
}
