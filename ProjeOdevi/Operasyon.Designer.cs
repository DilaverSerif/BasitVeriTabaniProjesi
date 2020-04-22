namespace ProjeOdevi
{
    partial class Operasyon
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
            this.kodbox = new System.Windows.Forms.TextBox();
            this.toplamsurebox = new System.Windows.Forms.TextBox();
            this.islembox = new System.Windows.Forms.TextBox();
            this.beklemesuresibox = new System.Windows.Forms.TextBox();
            this.tasimasuresibox = new System.Windows.Forms.TextBox();
            this.aciklamabox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.operasyontablo = new System.Windows.Forms.DataGridView();
            this.ekle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.idbox = new System.Windows.Forms.TextBox();
            this.duzenle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.istasyonbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.operasyontablo)).BeginInit();
            this.SuspendLayout();
            // 
            // kodbox
            // 
            this.kodbox.Location = new System.Drawing.Point(12, 26);
            this.kodbox.Name = "kodbox";
            this.kodbox.Size = new System.Drawing.Size(100, 20);
            this.kodbox.TabIndex = 0;
            // 
            // toplamsurebox
            // 
            this.toplamsurebox.Location = new System.Drawing.Point(12, 67);
            this.toplamsurebox.Name = "toplamsurebox";
            this.toplamsurebox.Size = new System.Drawing.Size(100, 20);
            this.toplamsurebox.TabIndex = 1;
            this.toplamsurebox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toplamsurebox_KeyPress);
            // 
            // islembox
            // 
            this.islembox.Location = new System.Drawing.Point(12, 112);
            this.islembox.Name = "islembox";
            this.islembox.Size = new System.Drawing.Size(100, 20);
            this.islembox.TabIndex = 2;
            this.islembox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.islembox_KeyPress);
            // 
            // beklemesuresibox
            // 
            this.beklemesuresibox.Location = new System.Drawing.Point(12, 158);
            this.beklemesuresibox.Name = "beklemesuresibox";
            this.beklemesuresibox.Size = new System.Drawing.Size(100, 20);
            this.beklemesuresibox.TabIndex = 3;
            this.beklemesuresibox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.beklemesuresibox_KeyPress);
            // 
            // tasimasuresibox
            // 
            this.tasimasuresibox.Location = new System.Drawing.Point(12, 202);
            this.tasimasuresibox.Name = "tasimasuresibox";
            this.tasimasuresibox.Size = new System.Drawing.Size(100, 20);
            this.tasimasuresibox.TabIndex = 4;
            this.tasimasuresibox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tasimasuresibox_KeyPress);
            // 
            // aciklamabox
            // 
            this.aciklamabox.Location = new System.Drawing.Point(12, 250);
            this.aciklamabox.Multiline = true;
            this.aciklamabox.Name = "aciklamabox";
            this.aciklamabox.Size = new System.Drawing.Size(196, 87);
            this.aciklamabox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Operasyon Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Toplam Operasyon Suresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "İşlem Süresi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bekleme Süresi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Taşıma Süresi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Operasyon Açıklaması";
            // 
            // operasyontablo
            // 
            this.operasyontablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operasyontablo.Location = new System.Drawing.Point(268, 12);
            this.operasyontablo.Name = "operasyontablo";
            this.operasyontablo.Size = new System.Drawing.Size(437, 464);
            this.operasyontablo.TabIndex = 12;
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(133, 363);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(75, 23);
            this.ekle.TabIndex = 13;
            this.ekle.Text = "EKLE";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(105, 446);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 30);
            this.sil.TabIndex = 14;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(40, 420);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(100, 20);
            this.idbox.TabIndex = 15;
            // 
            // duzenle
            // 
            this.duzenle.Location = new System.Drawing.Point(24, 446);
            this.duzenle.Name = "duzenle";
            this.duzenle.Size = new System.Drawing.Size(75, 30);
            this.duzenle.TabIndex = 16;
            this.duzenle.Text = "DÜZENLE";
            this.duzenle.UseVisualStyleBackColor = true;
            this.duzenle.Click += new System.EventHandler(this.duzenle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "İş İstasyonu Kodu";
            // 
            // istasyonbox
            // 
            this.istasyonbox.Location = new System.Drawing.Point(15, 365);
            this.istasyonbox.Name = "istasyonbox";
            this.istasyonbox.Size = new System.Drawing.Size(100, 20);
            this.istasyonbox.TabIndex = 18;
            // 
            // Operasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 490);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.istasyonbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.duzenle);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.operasyontablo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aciklamabox);
            this.Controls.Add(this.tasimasuresibox);
            this.Controls.Add(this.beklemesuresibox);
            this.Controls.Add(this.islembox);
            this.Controls.Add(this.toplamsurebox);
            this.Controls.Add(this.kodbox);
            this.Name = "Operasyon";
            this.Text = "Operasyon";
            ((System.ComponentModel.ISupportInitialize)(this.operasyontablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kodbox;
        private System.Windows.Forms.TextBox toplamsurebox;
        private System.Windows.Forms.TextBox islembox;
        private System.Windows.Forms.TextBox beklemesuresibox;
        private System.Windows.Forms.TextBox tasimasuresibox;
        private System.Windows.Forms.TextBox aciklamabox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView operasyontablo;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Button duzenle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox istasyonbox;
    }
}