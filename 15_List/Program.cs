using System.Collections;

namespace _15_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TANIM
            //int[] sayilar = new int[10]; // Veritipi ve uzunluk vermek zorunludur.

            //ArrayList sayilarList = new ArrayList(); // Karışık veri tutulduğu için kullanımı kısıtlı.

            //List<string> sayiListesi = new List<string>(); // Veritipi vermek zorunludur.

            //Eleman Ekleme
            //sayiListesi.Add("Altan");

            //Eleman Silme
            //sayiListesi.Remove("Altan");

            //Eleman Silme
            //sayiListesi.RemoveAt(0); // Olmayan index silinemez.HATA!

            //Console.WriteLine(sayiListesi.Capacity);

            //Eleman GÜNCELLEME
            //sayiListesi[3] = "Emre";


            //List<string> isimler = new List<string>();
            //isimler.Add("Ali");
            //isimler.Add("Zehra");
            //isimler.Add("Ahmet");
            //isimler.Add("Mehmet");
            //isimler.Add("Kemal");
            //isimler.Add("Kemalettin");
            //isimler.Add("Kenan");

            //int aranaIndex = isimler.BinarySearch("Ahmet"); //arananIndex:1
            //int aranaIndex2 = isimler.BinarySearch("Zehra");

            //Console.WriteLine("ilkIndex: " + aranaIndex + "ikinciIndex: " + aranaIndex2);
            #endregion


            List<Product> products = new List<Product>();

            //Bir class'tan instance(örneklem) alma işlemi
            //Object: Tanımlı olduğu classdaki özellikleri barındıran örnek.

            //INSTANCE
            //Product p = new Product();
            //p.Ad = "ELMA";
            //p.Kilo = 10;
            //p.Fiyat = 15.5;
            //p.Stok = 100;

            //products.Add(p);

            //Product p2 = new Product();
            //p2.Ad = "ARMUT";
            //p2.Kilo = 20;
            //p2.Fiyat = 25.5;
            //p2.Stok = 100;

            //products.Add(p2);


            //foreach (Product item in products)
            //{
            //    Console.WriteLine(item.Ad);
            //}


            //List<Product> hal = new List<Product>()
            //{ 
            //    new Product(){Ad="ELMA",Fiyat=15.5,Stok=100,Tip="M"},
            //    new Product(){Ad="ARMUT",Fiyat=15.5,Stok=100,Tip="M"},
            //    new Product(){Ad="MUZ",Fiyat=15.5,Stok=100,Tip="M"},
            //    new Product(){Ad="BİBER",Fiyat=15.5,Stok=100,Tip="S"},
            //    new Product(){Ad="PATLICAN",Fiyat=15.5,Stok=100,Tip="S"}
            //};

            //List<Product> manav = new List<Product>();


            //Console.WriteLine("Meyve M sebze S");
            //string secim = Console.ReadLine();
            //int i = 0;
            //foreach (Product product in hal)
            //{
            //    if (product.Tip == "S")
            //    {
            //        Console.WriteLine(i + "-" + product.Ad + ":" + product.Fiyat + " - " + product.Stok);
            //    }

            //    i++;
            //}

            //Console.WriteLine("Seçtiğiniz ürün numarası:");
            //int secimIndex = Convert.ToInt32(Console.ReadLine());

            //if (secimIndex > hal.Count)
            //{
            //    Console.WriteLine("Hatalı seçim");
            //}
            //else
            //{
            //    Product halUrun = hal[secimIndex];


            //    Console.WriteLine("Kaç kilo istersiniz:");
            //    int kilo = Convert.ToInt32(Console.ReadLine());

            //    if (halUrun.Stok >= kilo)
            //    {
            //        halUrun.Stok -= kilo;

            //        Product manavUrun = new Product();
            //        manavUrun.Ad = halUrun.Ad;
            //        manavUrun.Stok = kilo;
            //        manavUrun.Tip = halUrun.Tip;
            //        manavUrun.Fiyat = halUrun.Fiyat *1.15;

            //        manav.Add(manavUrun);
            //    }
            //}



            #region Örnek

            //Kullanıcı Kayıt - Giriş Paneli
            // Kullanıcı => Id,Username,Password,Name,Surname
            // Register => Id,Name,Surname,Username,Password,RePassword
            // Login => Username,Password 


            List<User> users = new List<User>();


            while (true)
            {
                Console.WriteLine("Register-1\nLogin-2");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                {
                    int result = User.Register(users);

                    if (result == 1)
                    {
                        Console.WriteLine("Kayıt Başarılı");
                    }
                    else if (result == -100)
                    {
                        Console.WriteLine("Şifreleriniz Uyuşmuyor.");
                    }
                    else
                    {
                        Console.WriteLine("Bilinmeyen bir hata oluştu.");
                    }
                }
                else if (secim == 2)
                {
                    Console.WriteLine("Username:");
                    string username = Console.ReadLine();
                    Console.WriteLine("Password:");
                    string pass = Console.ReadLine();
                    User user = User.Login(username, pass, users);

                    if (user == null)
                    {
                        Console.WriteLine("Giriş Bilgileriniz Hatalı!!");
                    }
                    else
                    {
                        Console.WriteLine("Giriş Başarılı");
                        Console.WriteLine(user.Name + " " + user.Surname);
                    }

                }
            }
           




            #endregion

        }
    }
}
