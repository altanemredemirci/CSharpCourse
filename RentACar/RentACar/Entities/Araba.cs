using System;
using System.Collections.Generic;

namespace RentACar.Entities;

public partial class Araba
{
    public int Id { get; set; }

    public string Marka { get; set; } = null!;

    public string Model { get; set; } = null!;

    public int Yıl { get; set; }

    public int MotorHacmi { get; set; }

    public string Renk { get; set; } = null!;

    public string Vites { get; set; } = null!;

    public string Yakıt { get; set; } = null!;

    public string KasaTipi { get; set; } = null!;

    public decimal Fiyat { get; set; }

    public string Plaka { get; set; } = null!;
}
