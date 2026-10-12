using System;
using System.Collections.Generic;
using System.Text;

namespace KutuphaneOtomasyonu.Models
{
    public class Kitap
    {
        public int Id { get; set; }
        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public string Barkod { get; set; }
        public int StokAdedi { get; set; }


        // Raf ile bağlantı kuran alanlar:
        public int RafId { get; set; }
        public Raf Raf { get; set; }


    }
}
