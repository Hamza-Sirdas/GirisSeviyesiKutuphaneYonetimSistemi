namespace KutuphaneOtomasyonu
{
    partial class EmanetForm
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
            btnIadeAl = new Button();
            dgvEmanetler = new DataGridView();
            btnOduncVer = new Button();
            cmbEmanetKitaplar = new ComboBox();
            cmbEmanetUyeler = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            btnKapat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmanetler).BeginInit();
            SuspendLayout();
            // 
            // btnIadeAl
            // 
            btnIadeAl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnIadeAl.Location = new Point(142, 309);
            btnIadeAl.Name = "btnIadeAl";
            btnIadeAl.Size = new Size(212, 39);
            btnIadeAl.TabIndex = 37;
            btnIadeAl.Text = "Seçili Kitabı İade Al";
            btnIadeAl.UseVisualStyleBackColor = true;
            btnIadeAl.Click += btnIadeAl_Click_1;
            // 
            // dgvEmanetler
            // 
            dgvEmanetler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmanetler.Location = new Point(383, 89);
            dgvEmanetler.Name = "dgvEmanetler";
            dgvEmanetler.Size = new Size(275, 282);
            dgvEmanetler.TabIndex = 36;
            // 
            // btnOduncVer
            // 
            btnOduncVer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnOduncVer.Location = new Point(195, 223);
            btnOduncVer.Name = "btnOduncVer";
            btnOduncVer.Size = new Size(158, 52);
            btnOduncVer.TabIndex = 35;
            btnOduncVer.Text = "Kitabı Ödünç Ver";
            btnOduncVer.UseVisualStyleBackColor = true;
            btnOduncVer.Click += btnOduncVer_Click_1;
            // 
            // cmbEmanetKitaplar
            // 
            cmbEmanetKitaplar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmanetKitaplar.FormattingEnabled = true;
            cmbEmanetKitaplar.Location = new Point(233, 127);
            cmbEmanetKitaplar.Name = "cmbEmanetKitaplar";
            cmbEmanetKitaplar.Size = new Size(121, 23);
            cmbEmanetKitaplar.TabIndex = 34;
            // 
            // cmbEmanetUyeler
            // 
            cmbEmanetUyeler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmanetUyeler.FormattingEnabled = true;
            cmbEmanetUyeler.Location = new Point(233, 176);
            cmbEmanetUyeler.Name = "cmbEmanetUyeler";
            cmbEmanetUyeler.Size = new Size(121, 23);
            cmbEmanetUyeler.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(150, 174);
            label11.Name = "label11";
            label11.Size = new Size(68, 21);
            label11.TabIndex = 32;
            label11.Text = "Üye Seç:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(142, 125);
            label10.Name = "label10";
            label10.Size = new Size(76, 21);
            label10.TabIndex = 31;
            label10.Text = "Kitap Seç:";
            // 
            // btnKapat
            // 
            btnKapat.BackColor = Color.LightCoral;
            btnKapat.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKapat.Location = new Point(634, 12);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(154, 32);
            btnKapat.TabIndex = 38;
            btnKapat.Text = "Geri Dön";
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            // 
            // EmanetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnKapat;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKapat);
            Controls.Add(btnIadeAl);
            Controls.Add(dgvEmanetler);
            Controls.Add(btnOduncVer);
            Controls.Add(cmbEmanetKitaplar);
            Controls.Add(cmbEmanetUyeler);
            Controls.Add(label11);
            Controls.Add(label10);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EmanetForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmanetForm";
            ((System.ComponentModel.ISupportInitialize)dgvEmanetler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIadeAl;
        private DataGridView dgvEmanetler;
        private Button btnOduncVer;
        private ComboBox cmbEmanetKitaplar;
        private ComboBox cmbEmanetUyeler;
        private Label label11;
        private Label label10;
        private Button btnKapat;
    }
}