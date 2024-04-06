using Ado.Net_5_PersonelUygulamasi.DAL;
using Ado.Net_5_PersonelUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Net_5_PersonelUygulamasi.BLL
{
    internal class BusinessLayer
    {
        DataAccessLayer DAL;

        public BusinessLayer()
        {
            DAL = new DataAccessLayer();
        }

        internal int SistemGirisKontrol(string kullaniciAdi, string sifre)
        {
            if(string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                return -100;
            }

            SistemKullanici sistemKullanici = new SistemKullanici();
            sistemKullanici.KullaniciAdi = kullaniciAdi;
            sistemKullanici.Sifre = sifre;

            return DAL.SistemGirisKontrol(sistemKullanici);
        }

        internal int PersonelKayit(string Isim,string Soyisim,string Email,string Telefon)
        {
            if(string.IsNullOrEmpty(Isim) || string.IsNullOrEmpty(Soyisim) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Telefon))
            {
                return -100;
            }

            //Unique Email

            bool uniqueEmail = DAL.UniqueEmailPhone(Email,Telefon) ;
            if (uniqueEmail)
            {
                return -101;
            }
            Personel P = new Personel();
            P.Soyisim = Soyisim;
            P.Isim = Isim;
            P.Email = Email;
            P.Telefon = Telefon;

            return DAL.PersonelKayit(P);
        }
    }
}
