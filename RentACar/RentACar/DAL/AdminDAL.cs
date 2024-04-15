using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DAL
{
    internal class AdminDAL
    {
        private readonly RentacarContext context;
        public AdminDAL()
        {
            context = new RentacarContext();
        }

        internal int ArabaEkle(Araba araba)
        {
            context.Arabas.Add(araba);
            context.SaveChanges();

            return 300;
        }

        internal bool PlakaKontrol(string plaka)
        {
            Araba araba = context.Arabas.FirstOrDefault(i => i.Plaka == plaka);
            if (araba == null)
            {
                return false;
            }
            return true;
        }

        internal List<Araba> ArabaListele()
        {
            return context.Arabas.ToList();
        }

        internal List<Musteri> MusteriListele()
        {
            return context.Musteris.ToList();
        }

        internal int MusteriEkle(Musteri musteri)
        {
            context.Musteris.Add(musteri);
            context.SaveChanges();

            return 203;
        }

        internal bool EmailKontrol(string email)
        {
            Musteri musteri = context.Musteris.FirstOrDefault(i => i.Email == email);
            if (musteri == null)
            {
                return false;
            }
            return true;
        }
        internal bool TCKontrol(long tc)
        {
            Musteri musteri = context.Musteris.FirstOrDefault(i => i.Tc == tc);
            if (musteri == null)
            {
                return false;
            }
            return true;
        }
        internal bool TelefonKontrol(string telefon)
        {
            Musteri musteri = context.Musteris.FirstOrDefault(i => i.Telefon == telefon);
            if (musteri == null)
            {
                return false;
            }
            return true;
        }
    }
}
