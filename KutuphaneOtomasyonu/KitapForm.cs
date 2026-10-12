using System;
using System.Linq;
using System.Windows.Forms;
using KutuphaneOtomasyonu.Data;
using KutuphaneOtomasyonu.Models;

namespace KutuphaneOtomasyonu
{
    public partial class KitapForm : Form
    {
        private int secilenKitapId = 0;
        public KitapForm()
        {
            InitializeComponent();
            RaflariComboBoxaDoldur();
            KitaplariListele();
        }

        private void RaflariComboBoxaDoldur()
        {
            using (var db = new KutuphaneDbContext())
            {
                var raflar = db.Raflar.ToList();
                cmbRaflar.DataSource = raflar;
                cmbRaflar.DisplayMember = "RafKodu";
                cmbRaflar.ValueMember = "Id";
            }
        }

        private void KitaplariListele()
        {
            using (var db = new KutuphaneDbContext())
            {
                var kitapListesi = db.Kitaplar.Select(k => new
                {
                    k.Id,
                    k.KitapAdi,
                    k.Yazar,
                    k.Barkod,
                    k.StokAdedi,
                    RafKodu = k.Raf.RafKodu,
                    k.RafId
                }).ToList();

                dgvKitaplar.DataSource = kitapListesi;
            }
        }

        private void btnKitapKaydet_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKitapAdi.Text) || cmbRaflar.SelectedValue == null)
            {
                MessageBox.Show("Lütfen kitap adını girin ve bir raf seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStokAdedi.Text, out int stokAdedi))
            {
                MessageBox.Show("Stok adedine geçerli bir sayı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new KutuphaneDbContext())
            {
                Kitap yeniKitap = new Kitap
                {
                    KitapAdi = txtKitapAdi.Text.Trim(),
                    Yazar = txtYazar.Text.Trim(),
                    Barkod = txtBarkod.Text.Trim(),
                    StokAdedi = stokAdedi,
                    RafId = (int)cmbRaflar.SelectedValue
                };

                db.Kitaplar.Add(yeniKitap);
                db.SaveChanges();
            }

            MessageBox.Show("Kitap başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            KutulariTemizle();
            KitaplariListele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var seciliSatir = dgvKitaplar.Rows[e.RowIndex];

            secilenKitapId = (int)seciliSatir.Cells["Id"].Value;

            txtKitapAdi.Text = seciliSatir.Cells["KitapAdi"].Value.ToString();
            txtYazar.Text = seciliSatir.Cells["Yazar"].Value.ToString();
            txtBarkod.Text = seciliSatir.Cells["Barkod"].Value.ToString();
            txtStokAdedi.Text = seciliSatir.Cells["StokAdedi"].Value.ToString();

            cmbRaflar.SelectedValue = (int)seciliSatir.Cells["RafId"].Value;
        }

        private void btnKitapGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenKitapId == 0)
            {
                MessageBox.Show("Lütfen önce tablodan güncellenecek bir kitaba tıklayın!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtKitapAdi.Text) || cmbRaflar.SelectedValue == null)
            {
                MessageBox.Show("Kitap adı veya raf alanı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStokAdedi.Text, out int stokAdedi))
            {
                MessageBox.Show("Stok adedine geçerli bir sayı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new KutuphaneDbContext())
            {

                var guncellenecekKitap = db.Kitaplar.Find(secilenKitapId);

                if (guncellenecekKitap != null)
                {
                    guncellenecekKitap.KitapAdi = txtKitapAdi.Text.Trim();
                    guncellenecekKitap.Yazar = txtYazar.Text.Trim();
                    guncellenecekKitap.Barkod = txtBarkod.Text.Trim();
                    guncellenecekKitap.StokAdedi = stokAdedi;
                    guncellenecekKitap.RafId = (int)cmbRaflar.SelectedValue;

                    // EF Core değişiklikleri algılayıp SQL'e UPDATE komutu atar:
                    db.SaveChanges();

                    MessageBox.Show("Kitap başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            KutulariTemizle();
            KitaplariListele();
        }

        private void KutulariTemizle()
        {
            txtKitapAdi.Clear();
            txtYazar.Clear();
            txtBarkod.Clear();
            txtStokAdedi.Clear();
            secilenKitapId = 0; 
        }
    }
}