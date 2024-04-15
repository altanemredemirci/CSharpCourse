using RentACar.DAL;
using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BLL
{
    internal class AdminManager
    {
        AdminDAL adminDAL;

        public AdminManager()
        {
            adminDAL = new AdminDAL();
        }

        internal int ArabaEkle(string marka,string model,int yil,string plaka,string renk,int fiyat,string vites,string kasa,string yakit,int motor)
        {
            if(    string.IsNullOrEmpty(marka) 
                || string.IsNullOrEmpty(model)
                || string.IsNullOrEmpty(plaka)
                || string.IsNullOrEmpty(renk)
                || string.IsNullOrEmpty(vites)
                || string.IsNullOrEmpty(kasa)
                || string.IsNullOrEmpty(yakit))
            {
                return 202;
            }


            if (adminDAL.PlakaKontrol(plaka))
            {
                return 301;
            }

            Araba araba = new Araba()
            {
                Marka = marka,
                Model = model,
                Yıl = yil,
                Plaka = plaka,
                Renk = renk,
                Fiyat = fiyat,
                Vites = vites,
                KasaTipi = kasa,
                Yakıt = yakit,
                MotorHacmi=motor
            };

            return adminDAL.ArabaEkle(araba);
        }

        internal List<Araba> ArabaListele()
        {
            return adminDAL.ArabaListele();
        }

        internal List<Musteri> MusteriListele()
        {
            return adminDAL.MusteriListele();
        }

        internal int MusteriEkle(string ad,string soyad,long tc,string adres,int bakiye,string ehliyet,string telefon,string email)
        {
            if (string.IsNullOrEmpty(ad)
             || string.IsNullOrEmpty(soyad)
             || string.IsNullOrEmpty(adres)
             || string.IsNullOrEmpty(ehliyet)
             || string.IsNullOrEmpty(email)
             || string.IsNullOrEmpty(telefon))
            {
                return 202;
            }

            if (adminDAL.EmailKontrol(email))
                return 204;
            if (adminDAL.TCKontrol(tc))
                return 205;
            if (adminDAL.TelefonKontrol(email))
                return 206;

            Musteri musteri = new Musteri();
            musteri.Surname = soyad;
            musteri.Name = ad;
            musteri.Adres = adres;
            musteri.Email = email;
            musteri.Telefon = telefon;
            musteri.EhliyetNo = ehliyet;
            musteri.Bakiye = bakiye;
            musteri.Tc = tc;
            musteri.Password = tc.ToString();

            return adminDAL.MusteriEkle(musteri);

        }
    }
}
