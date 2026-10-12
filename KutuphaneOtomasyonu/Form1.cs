using System;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRafIslemi_Click(object sender, EventArgs e)
        {

            this.Hide();
            RafForm form = new RafForm();
            form.ShowDialog();
            this.Show();
        }

        private void btnKitapIslemleri_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            KitapForm form = new KitapForm();
            form.ShowDialog();
            this.Show();
        }

        private void btnUyeIslemleri_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UyeForm form = new UyeForm();
            form.ShowDialog();
            this.Show();
        }

        private void btnEmanetIslemleri_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmanetForm form = new EmanetForm();
            form.ShowDialog();
            this.Show();
        }

 

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Programı kapatmak istediğinize emin misiniz?","Çıkış Onayı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);


            if (onay == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


    }
}