using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Musteriler
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
    }
}
