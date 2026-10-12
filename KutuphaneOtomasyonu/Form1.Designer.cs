namespace KutuphaneOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRafIslemi = new Button();
            btnUyeIslemleri = new Button();
            btnKitapIslemleri = new Button();
            btnEmanetIslemleri = new Button();
            label1 = new Label();
            label2 = new Label();
            lbl = new Label();
            btnCikis = new Button();
            SuspendLayout();
            // 
            // btnRafIslemi
            // 
            btnRafIslemi.BackColor = Color.Snow;
            btnRafIslemi.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnRafIslemi.Location = new Point(141, 148);
            btnRafIslemi.Name = "btnRafIslemi";
            btnRafIslemi.Size = new Size(240, 43);
            btnRafIslemi.TabIndex = 0;
            btnRafIslemi.Text = "🏷️ Raf Yönetimi";
            btnRafIslemi.UseVisualStyleBackColor = false;
            btnRafIslemi.Click += btnRafIslemi_Click;
            // 
            // btnUyeIslemleri
            // 
            btnUyeIslemleri.BackColor = Color.Snow;
            btnUyeIslemleri.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnUyeIslemleri.Location = new Point(141, 264);
            btnUyeIslemleri.Name = "btnUyeIslemleri";
            btnUyeIslemleri.Size = new Size(240, 43);
            btnUyeIslemleri.TabIndex = 1;
            btnUyeIslemleri.Text = "👥 Üye Yönetimi";
            btnUyeIslemleri.UseVisualStyleBackColor = false;
            btnUyeIslemleri.Click += btnUyeIslemleri_Click_1;
            // 
            // btnKitapIslemleri
            // 
            btnKitapIslemleri.BackColor = Color.Snow;
            btnKitapIslemleri.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnKitapIslemleri.Location = new Point(141, 206);
            btnKitapIslemleri.Name = "btnKitapIslemleri";
            btnKitapIslemleri.Size = new Size(240, 43);
            btnKitapIslemleri.TabIndex = 2;
            btnKitapIslemleri.Text = "📚 Kitap Yönetimi";
            btnKitapIslemleri.UseVisualStyleBackColor = false;
            btnKitapIslemleri.Click += btnKitapIslemleri_Click_1;
            // 
            // btnEmanetIslemleri
            // 
            btnEmanetIslemleri.BackColor = Color.Snow;
            btnEmanetIslemleri.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnEmanetIslemleri.Location = new Point(141, 329);
            btnEmanetIslemleri.Name = "btnEmanetIslemleri";
            btnEmanetIslemleri.Size = new Size(240, 43);
            btnEmanetIslemleri.TabIndex = 3;
            btnEmanetIslemleri.Text = "🔄 Emanet ve İade İşlemleri";
            btnEmanetIslemleri.UseVisualStyleBackColor = false;
            btnEmanetIslemleri.Click += btnEmanetIslemleri_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(62, 16);
            label1.Name = "label1";
            label1.Size = new Size(413, 45);
            label1.TabIndex = 4;
            label1.Text = "Kütüphane Yönetim Paneli";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(111, 36);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 5;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl.Location = new Point(77, 85);
            lbl.Name = "lbl";
            lbl.Size = new Size(371, 32);
            lbl.TabIndex = 6;
            lbl.Text = "Yapmak İstediğiniz İşelmi Seçin";
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.Snow;
            btnCikis.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnCikis.Location = new Point(141, 390);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(240, 43);
            btnCikis.TabIndex = 7;
            btnCikis.Text = "❌ Programdan Çık";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            CancelButton = btnCikis;
            ClientSize = new Size(524, 492);
            Controls.Add(btnCikis);
            Controls.Add(lbl);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEmanetIslemleri);
            Controls.Add(btnKitapIslemleri);
            Controls.Add(btnUyeIslemleri);
            Controls.Add(btnRafIslemi);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Yönetim Sistemi - Ana Menü";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgsEmanetler;
        private Button btnRafIslemi;
        private Button btnUyeIslemleri;
        private Button btnKitapIslemleri;
        private Button btnEmanetIslemleri;
        private Label label1;
        private Label label2;
        private Label lbl;
        private Button btnCikis;
    }
}
