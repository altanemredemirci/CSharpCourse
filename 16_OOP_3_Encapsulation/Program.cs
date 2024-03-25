namespace _16_OOP_3_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Musteri> musteris = new List<Musteri>();

            //Musteri m = new Musteri();

            //Console.WriteLine("TC:");
            //m._TC = Convert.ToInt64(Console.ReadLine());//value
            ////m.IBAN = "TR12345678909";
            //m.FullName = "Altan Emre";
            //m.Id = 2;

            //Console.WriteLine(m._TC);


            ////KAYNAK
            //musteris.Add(m);



            // Universite Öğrencilerinin Final ve Vize sınav notlarını öğrenciden alalım. %60 final %40 vize üzerinden ortalama hesaplayarak ekrana yazdırınız. Vize - Final 0-100 aralığı ENCAPSULATION ile kontrol edilecek 


            Ogrenci ogrenci = new Ogrenci();
            ogrenci.VizeNotu = 10;
            ogrenci.FinalNotu = -90;

            Console.WriteLine(ogrenci.OrtalamaHesapla());

        }
    }

    class Musteri
    {
        public int Id;
        public string FullName;
        private long TC;
        private string IBAN;

        public long _TC
        {
            get { return TC; } //readonly
            set
            {
                if(value>=10000000000 && value<100000000000)
                {
                    TC = value;
                }
                else
                {
                    TC = 00000000000;
                }

            }
        }

    }
}
