using RentACar.DAL;
using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BLL
{
    internal class RentManager
    {
        private readonly RentDAL rentDAL;

        public RentManager()
        {
            rentDAL = new RentDAL();
        }

        internal int AracKirala(Kiralama kiralama)
        {
            return rentDAL.AracKirala(kiralama);
        }
    }
}
