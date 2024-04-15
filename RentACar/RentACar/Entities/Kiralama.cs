using System;
using System.Collections.Generic;

namespace RentACar.Entities;

public partial class Kiralama
{
    public int Id { get; set; }

    public int ArabaId { get; set; }

    public int MusteriId { get; set; }

    public DateOnly IlkTarih { get; set; }

    public DateOnly SonTarih { get; set; }

    public int GunSayisi { get; set; }

    public decimal Odeme { get; set; }
}
