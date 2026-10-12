using System;
using System.Collections.Generic;
using System.Text;

namespace KutuphaneOtomasyonu.Models
{
    public class Emanet
    {
        public int Id { get; set; }
        public int KitapId { get; set; }
        public Kitap Kitap { get; set; }
        public int UyeId { get; set; }
        public Uye Uye { get; set; }
        public DateTime AlisTarihi { get; set; } = DateTime.Now;
        public DateTime? TeslimTarihi { get; set; }
        public bool TeslimEdildiMi { get; set; } = false;
    }
}
