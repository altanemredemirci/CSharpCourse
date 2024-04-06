using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Net_5_PersonelUygulamasi.Entities
{
    internal class SistemKullanici
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
