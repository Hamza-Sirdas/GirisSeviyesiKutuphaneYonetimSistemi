using System;
using System.Linq;
using System.Windows.Forms;
using KutuphaneOtomasyonu.Data;
using KutuphaneOtomasyonu.Models;

namespace KutuphaneOtomasyonu
{
    public partial class RafForm : Form
    {
        private int secilenRafId = 0;

        public RafForm()
        {
            InitializeComponent();
            RaflariListele();
        }

        private void RaflariListele()
        {
            using (var db = new KutuphaneDbContext())
            {
                // Kitaplar navigation property'sini listeye dahil etmeden temiz bir projeksiyon alıyoruz:
                var rafListesi = db.Raflar.Select(r => new
                {
                    r.Id,
                    r.RafKodu,
                    r.Aciklama
                }).ToList();

                dgvRaflar.DataSource = rafListesi;
            }
        }

        private void btnRafKaydet_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtRafKodu.Text))
            {
                MessageBox.Show("Lütfen bir raf kodu giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new KutuphaneDbContext())
            {
                var yeniRaf = new Raf
                {
                    RafKodu = txtRafKodu.Text.Trim(),
                    Aciklama = txtAciklama.Text.Trim()
                };

                db.Raflar.Add(yeniRaf);
                db.SaveChanges();
            }

            MessageBox.Show("Raf başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            KutulariTemizle();
            RaflariListele();
        }

   


        private void KutulariTemizle()
        {
            txtRafKodu.Clear();
            txtAciklama.Clear();
            secilenRafId = 0;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRafGuncelle_Click_1(object sender, EventArgs e)
        {
            if (secilenRafId == 0)
            {
                MessageBox.Show("Lütfen önce tablodan güncellenecek rafı seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRafKodu.Text))
            {
                MessageBox.Show("Raf kodu alanı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new KutuphaneDbContext())
            {
                var guncellenecekRaf = db.Raflar.Find(secilenRafId);

                if (guncellenecekRaf != null)
                {
                    guncellenecekRaf.RafKodu = txtRafKodu.Text.Trim();
                    guncellenecekRaf.Aciklama = txtAciklama.Text.Trim();

                    db.SaveChanges();

                    MessageBox.Show("Raf başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            KutulariTemizle();
            RaflariListele();
        }

        private void dgvRaflar_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var seciliSatir = dgvRaflar.Rows[e.RowIndex];

            if (seciliSatir.Cells["Id"]?.Value != null)
            {
                secilenRafId = Convert.ToInt32(seciliSatir.Cells["Id"].Value);
            }

            txtRafKodu.Text = seciliSatir.Cells["RafKodu"]?.Value?.ToString() ?? "";
            txtAciklama.Text = seciliSatir.Cells["Aciklama"]?.Value?.ToString() ?? "";
        }

        private void btnRafSil_Click(object sender, EventArgs e)
        {
            if (secilenRafId == 0)
            {
                MessageBox.Show("Lütfen önce tablodan silinecek bir raf seçiniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new KutuphaneDbContext())
            {

                bool buRaftaKitapVarMi = db.Kitaplar.Any(k => k.RafId == secilenRafId);

                if (buRaftaKitapVarMi)
                {
                    MessageBox.Show("Bu rafa ait kayıtlı kitaplar bulunmaktadır! Rafı silemezsiniz.\n\nLütfen önce bu raftaki kitapları başka rafa taşıyın veya silin.",
                                    "İşlem Engellendi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop);
                    return;
                }


                DialogResult onay = MessageBox.Show("Bu rafı kalıcı olarak silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (onay == DialogResult.Yes)
                {
                    var silinecekRaf = db.Raflar.Find(secilenRafId);

                    if (silinecekRaf != null)
                    {
                        db.Raflar.Remove(silinecekRaf);
                        db.SaveChanges();

                        MessageBox.Show("Raf başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


            }
            KutulariTemizle();
            RaflariListele();
        }

      
    }
}