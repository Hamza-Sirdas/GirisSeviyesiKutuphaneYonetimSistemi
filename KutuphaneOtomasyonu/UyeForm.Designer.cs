namespace KutuphaneOtomasyonu
{
    partial class UyeForm
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
            dgvUyeler = new DataGridView();
            btnUyeKaydet = new Button();
            txtUyeTelefon = new TextBox();
            txtUyeAdSoyad = new TextBox();
            label9 = new Label();
            label8 = new Label();
            btnKapat = new Button();
            btnUyeGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).BeginInit();
            SuspendLayout();
            // 
            // dgvUyeler
            // 
            dgvUyeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUyeler.Location = new Point(398, 84);
            dgvUyeler.Name = "dgvUyeler";
            dgvUyeler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUyeler.Size = new Size(275, 282);
            dgvUyeler.TabIndex = 29;
            dgvUyeler.CellClick += dgvUyeler_CellClick;
            // 
            // btnUyeKaydet
            // 
            btnUyeKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUyeKaydet.Location = new Point(250, 208);
            btnUyeKaydet.Name = "btnUyeKaydet";
            btnUyeKaydet.Size = new Size(109, 39);
            btnUyeKaydet.TabIndex = 28;
            btnUyeKaydet.Text = "Üye Kaydet";
            btnUyeKaydet.UseVisualStyleBackColor = true;
            btnUyeKaydet.Click += btnUyeKaydet_Click_1;
            // 
            // txtUyeTelefon
            // 
            txtUyeTelefon.Location = new Point(250, 158);
            txtUyeTelefon.Name = "txtUyeTelefon";
            txtUyeTelefon.Size = new Size(100, 23);
            txtUyeTelefon.TabIndex = 27;
            // 
            // txtUyeAdSoyad
            // 
            txtUyeAdSoyad.Location = new Point(250, 118);
            txtUyeAdSoyad.Name = "txtUyeAdSoyad";
            txtUyeAdSoyad.Size = new Size(100, 23);
            txtUyeAdSoyad.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(175, 154);
            label9.Name = "label9";
            label9.Size = new Size(62, 21);
            label9.TabIndex = 25;
            label9.Text = "Telefon:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(127, 118);
            label8.Name = "label8";
            label8.Size = new Size(110, 21);
            label8.TabIndex = 24;
            label8.Text = "Üye Ad Soyad:";
            // 
            // btnKapat
            // 
            btnKapat.BackColor = Color.LightCoral;
            btnKapat.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKapat.Location = new Point(634, 12);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(154, 32);
            btnKapat.TabIndex = 30;
            btnKapat.Text = "Geri Dön";
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            // 
            // btnUyeGuncelle
            // 
            btnUyeGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUyeGuncelle.Location = new Point(111, 208);
            btnUyeGuncelle.Name = "btnUyeGuncelle";
            btnUyeGuncelle.Size = new Size(126, 39);
            btnUyeGuncelle.TabIndex = 31;
            btnUyeGuncelle.Text = "Üye Güncelle";
            btnUyeGuncelle.UseVisualStyleBackColor = true;
            btnUyeGuncelle.Click += btnUyeGuncelle_Click;
            // 
            // UyeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnKapat;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUyeGuncelle);
            Controls.Add(btnKapat);
            Controls.Add(dgvUyeler);
            Controls.Add(btnUyeKaydet);
            Controls.Add(txtUyeTelefon);
            Controls.Add(txtUyeAdSoyad);
            Controls.Add(label9);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UyeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UyeForm";
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUyeler;
        private Button btnUyeKaydet;
        private TextBox txtUyeTelefon;
        private TextBox txtUyeAdSoyad;
        private Label label9;
        private Label label8;
        private Button btnKapat;
        private Button btnUyeGuncelle;
    }
}