namespace KutuphaneOtomasyonu
{
    partial class RafForm
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
            txtRafKodu = new TextBox();
            txtAciklama = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnRafKaydet = new Button();
            dgvRaflar = new DataGridView();
            btnKapat = new Button();
            btnRafGuncelle = new Button();
            btnRafSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRaflar).BeginInit();
            SuspendLayout();
            // 
            // txtRafKodu
            // 
            txtRafKodu.Location = new Point(279, 159);
            txtRafKodu.Name = "txtRafKodu";
            txtRafKodu.Size = new Size(100, 23);
            txtRafKodu.TabIndex = 0;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(279, 200);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(100, 23);
            txtAciklama.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(182, 161);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 2;
            label1.Text = "Raf Kodu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(110, 202);
            label2.Name = "label2";
            label2.Size = new Size(148, 21);
            label2.TabIndex = 5;
            label2.Text = "Açıklama / Kategori:";
            // 
            // btnRafKaydet
            // 
            btnRafKaydet.BackColor = SystemColors.ActiveCaption;
            btnRafKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRafKaydet.ForeColor = SystemColors.ActiveCaptionText;
            btnRafKaydet.Location = new Point(255, 249);
            btnRafKaydet.Name = "btnRafKaydet";
            btnRafKaydet.Size = new Size(124, 39);
            btnRafKaydet.TabIndex = 6;
            btnRafKaydet.Text = "Rafı Kaydet";
            btnRafKaydet.UseVisualStyleBackColor = false;
            btnRafKaydet.Click += btnRafKaydet_Click_1;
            // 
            // dgvRaflar
            // 
            dgvRaflar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRaflar.Location = new Point(416, 84);
            dgvRaflar.Name = "dgvRaflar";
            dgvRaflar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRaflar.Size = new Size(275, 291);
            dgvRaflar.TabIndex = 7;
            dgvRaflar.CellClick += dgvRaflar_CellClick_1;
            // 
            // btnKapat
            // 
            btnKapat.BackColor = Color.LightCoral;
            btnKapat.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKapat.Location = new Point(634, 12);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(154, 32);
            btnKapat.TabIndex = 31;
            btnKapat.Text = "Geri Dön";
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            // 
            // btnRafGuncelle
            // 
            btnRafGuncelle.BackColor = SystemColors.ActiveCaption;
            btnRafGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRafGuncelle.ForeColor = SystemColors.ActiveCaptionText;
            btnRafGuncelle.Location = new Point(255, 304);
            btnRafGuncelle.Name = "btnRafGuncelle";
            btnRafGuncelle.Size = new Size(124, 39);
            btnRafGuncelle.TabIndex = 32;
            btnRafGuncelle.Text = "Raf Güncelle";
            btnRafGuncelle.UseVisualStyleBackColor = false;
            btnRafGuncelle.Click += btnRafGuncelle_Click_1;
            // 
            // btnRafSil
            // 
            btnRafSil.BackColor = SystemColors.ActiveCaption;
            btnRafSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRafSil.ForeColor = SystemColors.ActiveCaptionText;
            btnRafSil.Location = new Point(255, 358);
            btnRafSil.Name = "btnRafSil";
            btnRafSil.Size = new Size(124, 39);
            btnRafSil.TabIndex = 33;
            btnRafSil.Text = " Rafı Sil";
            btnRafSil.UseVisualStyleBackColor = false;
            btnRafSil.Click += btnRafSil_Click;
            // 
            // RafForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnKapat;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRafSil);
            Controls.Add(btnRafGuncelle);
            Controls.Add(btnKapat);
            Controls.Add(dgvRaflar);
            Controls.Add(btnRafKaydet);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAciklama);
            Controls.Add(txtRafKodu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RafForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RafForm";
            ((System.ComponentModel.ISupportInitialize)dgvRaflar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRafKodu;
        private TextBox txtAciklama;
        private Label label1;
        private Label label2;
        private Button btnRafKaydet;
        private DataGridView dgvRaflar;
        private Button btnKapat;
        private Button btnRafGuncelle;
        private Button btnRafSil;
    }
}