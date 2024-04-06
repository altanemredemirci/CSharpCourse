using Ado.Net_5_PersonelUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Net_5_PersonelUygulamasi.DAL
{
    internal class DataAccessLayer
    {
        SqlConnection connect;
        SqlCommand cmd;
        SqlDataReader reader;
        int sonuc = 0;
        public DataAccessLayer()
        {
            connect = new SqlConnection("Data Source=204-HOCAPC1\\SQLDERS; Initial Catalog=PERSONELUYGULAMASI2024; Integrated Security=true");
            cmd = new SqlCommand();
        }

        public void BaglantiAyarla()
        {
            if(connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();
                Console.WriteLine("OK");
            }
            else
            {
                connect.Close();
            }
        }

        internal int SistemGirisKontrol(SistemKullanici S)
        {
           
            try
            {
                cmd = new SqlCommand($"Select * from SistemKullanici where KullaniciAdi='{S.KullaniciAdi}' and Sifre='{S.Sifre}'", connect);

                BaglantiAyarla();
                reader = cmd.ExecuteReader();
            }
            catch (Exception)
            {

                throw;
            }           

            if (reader.Read())
            {
                sonuc= 1;               
            }
            BaglantiAyarla();
            return sonuc;
        }

        internal int PersonelKayit(Personel P)
        {
            cmd = new SqlCommand($"Insert into personel (Isim,Soyisim,email,telefon) values('{P.Isim}','{P.Soyisim}','{P.Email}','{P.Telefon}')", connect);

           BaglantiAyarla();
            sonuc = cmd.ExecuteNonQuery();
            BaglantiAyarla();
            return sonuc;

        }

        internal bool UniqueEmailPhone(string email, string telefon)
        {
            cmd = new SqlCommand($"Select * from Personel where Email='{email}' or Telefon='{telefon}'", connect);

            BaglantiAyarla();

            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                BaglantiAyarla();
                return true;
            }
            else
            {
                BaglantiAyarla();
                return false;
            }

        }
    }
}
