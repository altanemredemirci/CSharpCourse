using RentACar.DAL;
using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BLL
{
    internal class UserManager
    {
        UserDAL userDAL;
        public UserManager()
        {
            userDAL = new UserDAL();
        }

        internal int GirisKontrol(string email, string sifre)
        {
            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(sifre))
            {
                return 202;
            }
            return userDAL.GirisKontrol(email, sifre);
        }
     
        internal List<Araba> ArabaListele()
        {
            return userDAL.ArabaListele();
        }

        internal Araba ArabaGetir(string plaka)
        {
            return userDAL.ArabaGetir(plaka);
        }
    }
}
