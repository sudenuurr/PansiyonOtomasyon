namespace Asil_Pansiyon_Uygulaması
{
    partial class FrmGelirGider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGelirGider));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblPersonelMaaslari = new System.Windows.Forms.Label();
            this.LblToplamTutar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblUrunlerinTutari1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblFaturalar1 = new System.Windows.Forms.Label();
            this.TxtPersonelSayisi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.LblSonuc = new System.Windows.Forms.Label();
            this.LblUrunlerinTutari3 = new System.Windows.Forms.Label();
            this.LblUrunlerinTutari2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblFaturalar3 = new System.Windows.Forms.Label();
            this.LblFaturalar2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasadaki Toplam Tutar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel Maaşları:";
            // 
            // LblPersonelMaaslari
            // 
            this.LblPersonelMaaslari.AutoSize = true;
            this.LblPersonelMaaslari.Location = new System.Drawing.Point(273, 106);
            this.LblPersonelMaaslari.Name = "LblPersonelMaaslari";
            this.LblPersonelMaaslari.Size = new System.Drawing.Size(40, 31);
            this.LblPersonelMaaslari.TabIndex = 2;
            this.LblPersonelMaaslari.Text = "00";
            // 
            // LblToplamTutar
            // 
            this.LblToplamTutar.AutoSize = true;
            this.LblToplamTutar.Location = new System.Drawing.Point(273, 47);
            this.LblToplamTutar.Name = "LblToplamTutar";
            this.LblToplamTutar.Size = new System.Drawing.Size(40, 31);
            this.LblToplamTutar.TabIndex = 3;
            this.LblToplamTutar.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alınan Ürünlerin Tutarı:";
            // 
            // LblUrunlerinTutari1
            // 
            this.LblUrunlerinTutari1.AutoSize = true;
            this.LblUrunlerinTutari1.Location = new System.Drawing.Point(273, 170);
            this.LblUrunlerinTutari1.Name = "LblUrunlerinTutari1";
            this.LblUrunlerinTutari1.Size = new System.Drawing.Size(40, 31);
            this.LblUrunlerinTutari1.TabIndex = 5;
            this.LblUrunlerinTutari1.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 31);
            this.label7.TabIndex = 6;
            this.label7.Text = "Faturalar:";
            // 
            // LblFaturalar1
            // 
            this.LblFaturalar1.AutoSize = true;
            this.LblFaturalar1.Location = new System.Drawing.Point(273, 227);
            this.LblFaturalar1.Name = "LblFaturalar1";
            this.LblFaturalar1.Size = new System.Drawing.Size(40, 31);
            this.LblFaturalar1.TabIndex = 7;
            this.LblFaturalar1.Text = "00";
            // 
            // TxtPersonelSayisi
            // 
            this.TxtPersonelSayisi.Location = new System.Drawing.Point(551, 47);
            this.TxtPersonelSayisi.Name = "TxtPersonelSayisi";
            this.TxtPersonelSayisi.Size = new System.Drawing.Size(100, 38);
            this.TxtPersonelSayisi.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(372, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 31);
            this.label9.TabIndex = 9;
            this.label9.Text = "Personel Sayısı:";
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(404, 348);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(273, 40);
            this.BtnHesapla.TabIndex = 10;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            this.BtnHesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(94, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 31);
            this.label10.TabIndex = 11;
            this.label10.Text = "Sonuç:";
            // 
            // LblSonuc
            // 
            this.LblSonuc.AutoSize = true;
            this.LblSonuc.Location = new System.Drawing.Point(184, 348);
            this.LblSonuc.Name = "LblSonuc";
            this.LblSonuc.Size = new System.Drawing.Size(40, 31);
            this.LblSonuc.TabIndex = 12;
            this.LblSonuc.Text = "00";
            // 
            // LblUrunlerinTutari3
            // 
            this.LblUrunlerinTutari3.AutoSize = true;
            this.LblUrunlerinTutari3.Location = new System.Drawing.Point(365, 170);
            this.LblUrunlerinTutari3.Name = "LblUrunlerinTutari3";
            this.LblUrunlerinTutari3.Size = new System.Drawing.Size(40, 31);
            this.LblUrunlerinTutari3.TabIndex = 13;
            this.LblUrunlerinTutari3.Text = "00";
            // 
            // LblUrunlerinTutari2
            // 
            this.LblUrunlerinTutari2.AutoSize = true;
            this.LblUrunlerinTutari2.Location = new System.Drawing.Point(319, 170);
            this.LblUrunlerinTutari2.Name = "LblUrunlerinTutari2";
            this.LblUrunlerinTutari2.Size = new System.Drawing.Size(40, 31);
            this.LblUrunlerinTutari2.TabIndex = 14;
            this.LblUrunlerinTutari2.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(714, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "______________________________________________________________________";
            // 
            // LblFaturalar3
            // 
            this.LblFaturalar3.AutoSize = true;
            this.LblFaturalar3.Location = new System.Drawing.Point(365, 227);
            this.LblFaturalar3.Name = "LblFaturalar3";
            this.LblFaturalar3.Size = new System.Drawing.Size(40, 31);
            this.LblFaturalar3.TabIndex = 16;
            this.LblFaturalar3.Text = "00";
            // 
            // LblFaturalar2
            // 
            this.LblFaturalar2.AutoSize = true;
            this.LblFaturalar2.Location = new System.Drawing.Point(319, 227);
            this.LblFaturalar2.Name = "LblFaturalar2";
            this.LblFaturalar2.Size = new System.Drawing.Size(40, 31);
            this.LblFaturalar2.TabIndex = 17;
            this.LblFaturalar2.Text = "00";
            // 
            // FrmGelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(706, 411);
            this.Controls.Add(this.LblFaturalar2);
            this.Controls.Add(this.LblFaturalar3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblUrunlerinTutari2);
            this.Controls.Add(this.LblUrunlerinTutari3);
            this.Controls.Add(this.LblSonuc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnHesapla);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtPersonelSayisi);
            this.Controls.Add(this.LblFaturalar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblUrunlerinTutari1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblToplamTutar);
            this.Controls.Add(this.LblPersonelMaaslari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGelirGider";
            this.Text = "Gelir-Gider";
            this.Load += new System.EventHandler(this.FrmGelirGider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblPersonelMaaslari;
        private System.Windows.Forms.Label LblToplamTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblUrunlerinTutari1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblFaturalar1;
        private System.Windows.Forms.TextBox TxtPersonelSayisi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblSonuc;
        private System.Windows.Forms.Label LblUrunlerinTutari3;
        private System.Windows.Forms.Label LblUrunlerinTutari2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblFaturalar3;
        private System.Windows.Forms.Label LblFaturalar2;
    }
}