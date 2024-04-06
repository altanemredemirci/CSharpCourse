namespace _16_OOP_6_Polymorphism_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

            Tekstil    : Ad,Fiyat,KumasTuru,Beden,UreticiFirma - KDVUygula(%20)
            CepTelefonu: Ad,Fiyat,Ozellikler,Marka - KDVUygula(%120)
            Ekmek      : Ad,Fiyat,EkmekTuru,Gramaj - KDVUygula(%20)

            Nesne ozelliklerini Contructor method ile alın.

            Sepet : Alınan urunleri bir listeye kaydetsin, Toplamtutarı söylesin

             */

            Sepet s = new Sepet();

            Ekmek ekmek = new Ekmek("Çavdar", 400, "Uno", 70);
            CepTelefonu cepTelefonu = new CepTelefonu("Bluetooth,5G", "Huawei", "Plite20", 20000);

            s.Ekle(ekmek);
            s.Ekle(ekmek);
            s.Ekle(cepTelefonu);

            Console.WriteLine(s.ToplamTutar());
        }
    }

    class Urun
    {
        public string Ad { get; set; }
        public double Fiyat { get; set; }

        public Urun(string ad, double fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
        }

        public virtual double KDVUygula()
        {
            return Fiyat * 1.2;
        }
    }

    class Tekstil : Urun
    {
        public string KumasTuru { get; set; }
        public int Beden { get; set; }
        public string UreticiFirma { get; set; }

        public Tekstil(string kumasTuru,int beden, string ureticiFirma,string ad, double fiyat):base(ad,fiyat)
        {
            KumasTuru = kumasTuru;
            Beden = beden;
            UreticiFirma = ureticiFirma;
        }
    }

    class Ekmek : Urun
    {
        public string Turu { get; set; }
        public int Gramaj { get; set; }

        public Ekmek(string turu,int gramaj,string ad, double fiyat):base(ad,fiyat)
        {
            Turu = turu;
            Gramaj = gramaj;
        }
    }

    class CepTelefonu : Urun
    {
        public string Ozellikleri { get; set; }
        public string Marka { get; set; }

        public CepTelefonu(string ozellikleri,string marka,string ad, double fiyat):base(ad,fiyat)
        {
            Ozellikleri = ozellikleri;
            Marka = marka;
        }

        public override double KDVUygula()
        {
            return Fiyat * 2.2;
        }
    }

    class Sepet
    {
        private List<Urun> urunler = new List<Urun>();

        public double ToplamTutar()
        {
            double toplamfiyat = 0;
            foreach (Urun item in urunler)
            {
                toplamfiyat += item.Fiyat;
            }

            return toplamfiyat;
        }

        public void Ekle(Urun urun)
        {
            urunler.Add(urun);
        }
    }
}
