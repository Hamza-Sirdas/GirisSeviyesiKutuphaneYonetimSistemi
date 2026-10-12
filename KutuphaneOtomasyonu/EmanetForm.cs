using System;
using System.Linq;
using System.Windows.Forms;
using KutuphaneOtomasyonu.Data;
using KutuphaneOtomasyonu.Models;

namespace KutuphaneOtomasyonu
{
    public partial class EmanetForm : Form
    {
        public EmanetForm()
        {
            InitializeComponent();
            EmanetKitaplariDoldur();
            EmanetUyeleriDoldur();
            EmanetleriListele();
        }

        private void EmanetKitaplariDoldur()
        {
            using (var db = new KutuphaneDbContext())
            {
                var musaitKitaplar = db.Kitaplar
                    .Where(k => k.StokAdedi > 0)
                    .Select(k => new
                    {
                        k.Id,
                        GorunenMetin = k.KitapAdi + " (Kalan Stok: " + k.StokAdedi + ")"
                    }).ToList();

                cmbEmanetKitaplar.DataSource = musaitKitaplar;
                cmbEmanetKitaplar.DisplayMember = "GorunenMetin";
                cmbEmanetKitaplar.ValueMember = "Id";
            }
        }

        private void EmanetUyeleriDoldur()
        {
            using (var db = new KutuphaneDbContext())
            {
                var uyeler = db.Uyeler.ToList();
                cmbEmanetUyeler.DataSource = uyeler;
                cmbEmanetUyeler.DisplayMember = "AdSoyad";
                cmbEmanetUyeler.ValueMember = "Id";
            }
        }

        private void EmanetleriListele()
        {
            using (var db = new KutuphaneDbContext())
            {
                var emanetListesi = db.Emanetler
                    .Where(e => e.TeslimEdildiMi == false)
                    .Select(e => new
                    {
                        e.Id,
                        KitapAdi = e.Kitap.KitapAdi,
                        UyeAdi = e.Uye.AdSoyad,
                        e.AlisTarihi
                    }).ToList();

                dgvEmanetler.DataSource = emanetListesi;
            }
        }
        private void btnOduncVer_Click_1(object sender, EventArgs e)
        {
            if (cmbEmanetKitaplar.SelectedValue == null || cmbEmanetUyeler.SelectedValue == null)
            {
                MessageBox.Show("Lütfen hem kitap hem de üye seçimi yapınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int secilenKitapId = (int)cmbEmanetKitaplar.SelectedValue;
            int secilenUyeId = (int)cmbEmanetUyeler.SelectedValue;

            using (var db = new KutuphaneDbContext())
            {
                var kitap = db.Kitaplar.Find(secilenKitapId);

                if (kitap == null || kitap.StokAdedi <= 0)
                {
                    MessageBox.Show("Bu kitap stokta kalmamıştır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Emanet yeniEmanet = new Emanet
                {
                    KitapId = secilenKitapId,
                    UyeId = secilenUyeId,
                    AlisTarihi = DateTime.Now,
                    TeslimEdildiMi = false
                };

                db.Emanetler.Add(yeniEmanet);
                kitap.StokAdedi -= 1;
                db.SaveChanges();
            }

            MessageBox.Show("Kitap başarıyla ödünç verildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            EmanetleriListele();
            EmanetKitaplariDoldur();
        }

        private void btnIadeAl_Click_1(object sender, EventArgs e)
        {
            if (dgvEmanetler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen iade edilecek kitabı tablodan seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int secilenEmanetId = (int)dgvEmanetler.CurrentRow.Cells["Id"].Value;

            using (var db = new KutuphaneDbContext())
            {
                var emanet = db.Emanetler.Find(secilenEmanetId);

                if (emanet != null)
                {
                    emanet.TeslimEdildiMi = true;
                    emanet.TeslimTarihi = DateTime.Now;

                    var kitap = db.Kitaplar.Find(emanet.KitapId);
                    if (kitap != null)
                    {
                        kitap.StokAdedi += 1;
                    }

                    db.SaveChanges();
                }
            }

            MessageBox.Show("Kitap iade alındı ve stok güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            EmanetleriListele();
            EmanetKitaplariDoldur();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}