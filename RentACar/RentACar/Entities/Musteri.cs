using System;
using System.Collections.Generic;

namespace RentACar.Entities;

public partial class Musteri
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public long Tc { get; set; }

    public string Adres { get; set; } = null!;

    public decimal Bakiye { get; set; }

    public string EhliyetNo { get; set; } = null!;

    public string Telefon { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;
}
