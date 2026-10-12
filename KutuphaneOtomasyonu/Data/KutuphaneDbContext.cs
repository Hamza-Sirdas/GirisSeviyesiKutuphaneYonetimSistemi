using Microsoft.EntityFrameworkCore;
using KutuphaneOtomasyonu.Models;

namespace KutuphaneOtomasyonu.Data
{
    public class KutuphaneDbContext : DbContext
    {
        public DbSet<Raf> Raflar { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<Emanet> Emanetler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=VICTUS\\SQLEXPRESS;Database=KutuphaneDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

    }
}
