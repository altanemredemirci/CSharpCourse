using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DAL
{
    internal class UserDAL
    {
        public static int MusteriId;
        private readonly RentacarContext context;

        public UserDAL()
        {
            context = new RentacarContext();
        }

        internal int GirisKontrol(string email, string sifre)
        {
            //AdminKontrolü
            if (email == "altanemre1989@gmail.com")
            {
                Yonetici yonetici = context.Yoneticis.Where(i => i.Email == email && i.Password == sifre).FirstOrDefault();

                if (yonetici != null)
                {
                    //Admin Panel
                    return 100;
                }
                else
                {
                    return 101; //Yönetici Şifre Hatası
                }
            }
            else
            {
                Musteri musteri = context.Musteris.Where(i => i.Email == email && i.Password == sifre).FirstOrDefault();

                if (musteri != null)
                {
                    MusteriId = musteri.Id;
                    //Araba Kiralama
                    return 200;//Giriş Başarılı
                }
                else
                {
                    return 201;//Email veya Şifre hatalı
                }
            }

        }

        internal List<Araba> ArabaListele()
        {
            return context.Arabas.ToList();
        }

        internal Araba ArabaGetir(string plaka)
        {
            return context.Arabas.Find(plaka);
        }        
    }
}
