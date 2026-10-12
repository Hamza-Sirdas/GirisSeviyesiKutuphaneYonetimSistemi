using System;
using System.Collections.Generic;
using System.Text;

namespace KutuphaneOtomasyonu.Models
{
    public class Uye
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public DateTime KayitTarihi { get; set; } = DateTime.Now;
    }
}
