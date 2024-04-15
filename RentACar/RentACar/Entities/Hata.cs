using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Entities
{
    internal class Hata
    {
       public static SortedList<int, string> Hatalar = new SortedList<int, string>()
        {
            {100,"Yönetici Giriş Başarılı"},
            {101,"Yönetici Şifre Hatası"},
            {200,"Müşteri Giriş Başarılı"},
            {201,"Müşteri Giriş Bilgileri Hatalı"},            
            {202,"Alanlar Boş Geçilemez"},
            {203,"Müşteri Ekleme Başarılı"},
            {204,"Aynı Email Kayıtlı"},
            {205,"Aynı TC Kayıtlı"},
            {206,"Aynı Telefon Numarası Kayıtlı"},
            {300,"Araba Ekleme Başarılı"},
            {301,"Aynı Plaka Kayıtlı"}
        };
    }
}
