namespace KutuphaneOtomasyonu
{
    partial class KitapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvKitaplar = new DataGridView();
            btnKitapKaydet = new Button();
            cmbRaflar = new ComboBox();
            txtYazar = new TextBox();
            txtBarkod = new TextBox();
            txtStokAdedi = new TextBox();
            txtKitapAdi = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnKapat = new Button();
            btnKitapGuncelle = new Button();
            btnKitapSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).BeginInit();
            SuspendLayout();
            // 
            // dgvKitaplar
            // 
            dgvKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitaplar.Location = new Point(398, 73);
            dgvKitaplar.Name = "dgvKitaplar";
            dgvKitaplar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKitaplar.Size = new Size(294, 319);
            dgvKitaplar.TabIndex = 29;
            dgvKitaplar.CellClick += dgvKitaplar_CellClick;
            // 
            // btnKitapKaydet
            // 
            btnKitapKaydet.BackColor = Color.FromArgb(192, 0, 192);
            btnKitapKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKitapKaydet.Location = new Point(226, 309);
            btnKitapKaydet.Name = "btnKitapKaydet";
            btnKitapKaydet.Size = new Size(144, 43);
            btnKitapKaydet.TabIndex = 28;
            btnKitapKaydet.Text = "Kitap Kaydet";
            btnKitapKaydet.UseVisualStyleBackColor = false;
            btnKitapKaydet.Click += btnKitapKaydet_Click_1;
            // 
            // cmbRaflar
            // 
            cmbRaflar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRaflar.FormattingEnabled = true;
            cmbRaflar.Location = new Point(248, 263);
            cmbRaflar.Name = "cmbRaflar";
            cmbRaflar.Size = new Size(121, 23);
            cmbRaflar.TabIndex = 27;
            // 
            // txtYazar
            // 
            txtYazar.Location = new Point(247, 141);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(122, 23);
            txtYazar.TabIndex = 26;
            // 
            // txtBarkod
            // 
            txtBarkod.Location = new Point(247, 180);
            txtBarkod.Name = "txtBarkod";
            txtBarkod.Size = new Size(122, 23);
            txtBarkod.TabIndex = 25;
            // 
            // txtStokAdedi
            // 
            txtStokAdedi.Location = new Point(247, 218);
            txtStokAdedi.Name = "txtStokAdedi";
            txtStokAdedi.Size = new Size(122, 23);
            txtStokAdedi.TabIndex = 24;
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(247, 98);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(122, 23);
            txtKitapAdi.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(117, 263);
            label7.Name = "label7";
            label7.Size = new Size(116, 21);
            label7.TabIndex = 22;
            label7.Text = "Bulunduğu Raf:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(183, 139);
            label6.Name = "label6";
            label6.Size = new Size(50, 21);
            label6.TabIndex = 21;
            label6.Text = "Yazar:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(171, 180);
            label5.Name = "label5";
            label5.Size = new Size(62, 21);
            label5.TabIndex = 20;
            label5.Text = "Barkod:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(146, 218);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 19;
            label4.Text = "Stok Adedi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(158, 98);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 18;
            label3.Text = "Kitap Adı:";
            // 
            // btnKapat
            // 
            btnKapat.BackColor = Color.Red;
            btnKapat.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKapat.ForeColor = SystemColors.ButtonHighlight;
            btnKapat.Location = new Point(634, 12);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(154, 32);
            btnKapat.TabIndex = 31;
            btnKapat.Text = "Geri Dön";
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            // 
            // btnKitapGuncelle
            // 
            btnKitapGuncelle.BackColor = Color.FromArgb(192, 0, 192);
            btnKitapGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKitapGuncelle.Location = new Point(226, 374);
            btnKitapGuncelle.Name = "btnKitapGuncelle";
            btnKitapGuncelle.Size = new Size(144, 43);
            btnKitapGuncelle.TabIndex = 32;
            btnKitapGuncelle.Text = "Kitap Güncelle";
            btnKitapGuncelle.UseVisualStyleBackColor = false;
            btnKitapGuncelle.Click += btnKitapGuncelle_Click;
            // 
            // btnKitapSil
            // 
            btnKitapSil.BackColor = Color.FromArgb(192, 0, 192);
            btnKitapSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKitapSil.Location = new Point(225, 436);
            btnKitapSil.Name = "btnKitapSil";
            btnKitapSil.Size = new Size(144, 43);
            btnKitapSil.TabIndex = 33;
            btnKitapSil.Text = "Kitapı Sil";
            btnKitapSil.UseVisualStyleBackColor = false;
            btnKitapSil.Click += btnKitapSil_Click;
            // 
            // KitapForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnKapat;
            ClientSize = new Size(800, 533);
            Controls.Add(btnKitapSil);
            Controls.Add(btnKitapGuncelle);
            Controls.Add(btnKapat);
            Controls.Add(dgvKitaplar);
            Controls.Add(btnKitapKaydet);
            Controls.Add(cmbRaflar);
            Controls.Add(txtYazar);
            Controls.Add(txtBarkod);
            Controls.Add(txtStokAdedi);
            Controls.Add(txtKitapAdi);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "KitapForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KitapForm";
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKitaplar;
        private Button btnKitapKaydet;
        private ComboBox cmbRaflar;
        private TextBox txtYazar;
        private TextBox txtBarkod;
        private TextBox txtStokAdedi;
        private TextBox txtKitapAdi;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnKapat;
        private Button btnKitapGuncelle;
        private Button btnKitapSil;
    }
}