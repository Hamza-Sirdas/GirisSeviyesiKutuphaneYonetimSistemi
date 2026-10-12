using System;
using System.Linq;
using System.Windows.Forms;
using KutuphaneOtomasyonu.Data;
using KutuphaneOtomasyonu.Models;

namespace KutuphaneOtomasyonu
{
    public partial class UyeForm : Form
    {

        public UyeForm()
        {
            InitializeComponent();
            UyeleriListele();
        }

        private void UyeleriListele()
        {
            using (var db = new KutuphaneDbContext())
            {
                var uyeListesi = db.Uyeler.Select(u => new
                {
                    u.Id,
                    u.AdSoyad,
                    u.Telefon,
                    u.KayitTarihi
                }).ToList();

                dgvUyeler.DataSource = uyeListesi;
            }
        }
        private void btnUyeKaydet_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUyeAdSoyad.Text) || string.IsNullOrWhiteSpace(txtUyeTelefon.Text))
            {
                MessageBox.Show("Lütfen üyenin adını, soyadını ve telefon numarasını giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new KutuphaneDbContext())
            {
                Uye yeniUye = new Uye
                {
                    AdSoyad = txtUyeAdSoyad.Text.Trim(),
                    Telefon = txtUyeTelefon.Text.Trim()
                };

                db.Uyeler.Add(yeniUye);
                db.SaveChanges();
            }

            MessageBox.Show("Üye başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtUyeAdSoyad.Clear();
            txtUyeTelefon.Clear();
            UyeleriListele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int secilenUyeId = 0;
        private void dgvUyeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Güvenlik Kilidi (Guard):
            if (e.RowIndex < 0) return;

            var seciliSatir = dgvUyeler.Rows[e.RowIndex];

            // 1. Kimliği hafızaya at:
            if (seciliSatir.Cells["Id"]?.Value != null)
            {
                secilenUyeId = Convert.ToInt32(seciliSatir.Cells["Id"].Value);
            }

            // 2. Kutuları doldur:
            txtUyeAdSoyad.Text = seciliSatir.Cells["AdSoyad"]?.Value?.ToString() ?? "";
            txtUyeTelefon.Text = seciliSatir.Cells["Telefon"]?.Value?.ToString() ?? "";
        }

        private void btnUyeGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenUyeId == 0)
            {
                MessageBox.Show("Lütfen önce tablodan güncellenecek bir üyeyi seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUyeAdSoyad.Text) || string.IsNullOrWhiteSpace(txtUyeTelefon.Text))
            {
                MessageBox.Show("Ad Soyad ve Telefon alanları boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new KutuphaneDbContext())
            {
                var guncellenecekUye = db.Uyeler.Find(secilenUyeId);

                if (guncellenecekUye != null)
                {
                    guncellenecekUye.AdSoyad = txtUyeAdSoyad.Text.Trim();
                    guncellenecekUye.Telefon = txtUyeTelefon.Text.Trim();
                    // KayitTarihi'ne dokunmuyoruz; üyenin ilk kayıt zamanı korunmalı!

                    db.SaveChanges();

                    MessageBox.Show("Üye bilgileri başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            KutulariTemizle();
            UyeleriListele();
        }
        private void KutulariTemizle()
        {
            txtUyeAdSoyad.Clear();
            txtUyeTelefon.Clear();
            secilenUyeId = 0;
        }
    }
}