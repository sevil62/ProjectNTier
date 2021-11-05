
namespace Project.UI
{
    partial class Form1
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
            this.lstSonuc = new System.Windows.Forms.ListBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnPasifler = new System.Windows.Forms.Button();
            this.btnGuncellenenler = new System.Windows.Forms.Button();
            this.btnAktifler = new System.Windows.Forms.Button();
            this.btnHepsi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSonuc
            // 
            this.lstSonuc.FormattingEnabled = true;
            this.lstSonuc.ItemHeight = 16;
            this.lstSonuc.Location = new System.Drawing.Point(34, 32);
            this.lstSonuc.Name = "lstSonuc";
            this.lstSonuc.Size = new System.Drawing.Size(250, 388);
            this.lstSonuc.TabIndex = 0;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(347, 56);
            this.txtCategoryName.Multiline = true;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(230, 31);
            this.txtCategoryName.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(347, 118);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(147, 29);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(347, 153);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(147, 29);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(347, 188);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(147, 29);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnPasifler
            // 
            this.btnPasifler.Location = new System.Drawing.Point(347, 284);
            this.btnPasifler.Name = "btnPasifler";
            this.btnPasifler.Size = new System.Drawing.Size(147, 29);
            this.btnPasifler.TabIndex = 5;
            this.btnPasifler.Text = "Pasifler";
            this.btnPasifler.UseVisualStyleBackColor = true;
            this.btnPasifler.Click += new System.EventHandler(this.btnPasifler_Click);
            // 
            // btnGuncellenenler
            // 
            this.btnGuncellenenler.Location = new System.Drawing.Point(500, 284);
            this.btnGuncellenenler.Name = "btnGuncellenenler";
            this.btnGuncellenenler.Size = new System.Drawing.Size(147, 29);
            this.btnGuncellenenler.TabIndex = 6;
            this.btnGuncellenenler.Text = "Güncellenenler";
            this.btnGuncellenenler.UseVisualStyleBackColor = true;
            this.btnGuncellenenler.Click += new System.EventHandler(this.btnGuncellenenler_Click);
            // 
            // btnAktifler
            // 
            this.btnAktifler.Location = new System.Drawing.Point(347, 331);
            this.btnAktifler.Name = "btnAktifler";
            this.btnAktifler.Size = new System.Drawing.Size(147, 29);
            this.btnAktifler.TabIndex = 7;
            this.btnAktifler.Text = "Aktifler";
            this.btnAktifler.UseVisualStyleBackColor = true;
            this.btnAktifler.Click += new System.EventHandler(this.btnAktifler_Click);
            // 
            // btnHepsi
            // 
            this.btnHepsi.Location = new System.Drawing.Point(500, 331);
            this.btnHepsi.Name = "btnHepsi";
            this.btnHepsi.Size = new System.Drawing.Size(147, 29);
            this.btnHepsi.TabIndex = 8;
            this.btnHepsi.Text = "Hepsi";
            this.btnHepsi.UseVisualStyleBackColor = true;
            this.btnHepsi.Click += new System.EventHandler(this.btnHepsi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(845, 473);
            this.Controls.Add(this.btnHepsi);
            this.Controls.Add(this.btnAktifler);
            this.Controls.Add(this.btnGuncellenenler);
            this.Controls.Add(this.btnPasifler);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.lstSonuc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSonuc;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnPasifler;
        private System.Windows.Forms.Button btnGuncellenenler;
        private System.Windows.Forms.Button btnAktifler;
        private System.Windows.Forms.Button btnHepsi;
    }
}

