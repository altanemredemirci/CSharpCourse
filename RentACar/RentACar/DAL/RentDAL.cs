using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DAL
{
    internal class RentDAL
    {
        private readonly RentacarContext context;

        public RentDAL()
        {
            context = new RentacarContext();
        }

        internal int AracKirala(Kiralama kiralama)
        {
            context.Kiralamas.Add(kiralama);
            return context.SaveChanges();
        }
    }
}
