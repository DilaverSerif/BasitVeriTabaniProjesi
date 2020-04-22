namespace ProjeOdevi
{
    partial class Personel
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
            this.tablopersonel = new System.Windows.Forms.DataGridView();
            this.adisoyadi = new System.Windows.Forms.TextBox();
            this.tc = new System.Windows.Forms.TextBox();
            this.ekle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gorev = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.aylik = new System.Windows.Forms.TextBox();
            this.birim = new System.Windows.Forms.TextBox();
            this.duzenle = new System.Windows.Forms.Button();
            this.idgir = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablopersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // tablopersonel
            // 
            this.tablopersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablopersonel.Location = new System.Drawing.Point(185, 10);
            this.tablopersonel.Name = "tablopersonel";
            this.tablopersonel.Size = new System.Drawing.Size(487, 366);
            this.tablopersonel.TabIndex = 0;
            // 
            // adisoyadi
            // 
            this.adisoyadi.Location = new System.Drawing.Point(42, 29);
            this.adisoyadi.Name = "adisoyadi";
            this.adisoyadi.Size = new System.Drawing.Size(100, 20);
            this.adisoyadi.TabIndex = 1;
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(42, 68);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(100, 20);
            this.tc.TabIndex = 2;
            this.tc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tc_KeyPress);
            // 
            // ekle
            // 
            this.ekle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ekle.Location = new System.Drawing.Point(32, 214);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(125, 40);
            this.ekle.TabIndex = 7;
            this.ekle.Text = "EKLE";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(55, 332);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(77, 28);
            this.sil.TabIndex = 9;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Adi Soyadi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "TC kimlik numarısı";
            // 
            // gorev
            // 
            this.gorev.FormattingEnabled = true;
            this.gorev.Items.AddRange(new object[] {
            "Genel Müdür",
            "Müdür Yardımcısı",
            "Muhasebeci",
            "Satış Elemanı",
            "Temizlikci",
            ""});
            this.gorev.Location = new System.Drawing.Point(42, 107);
            this.gorev.Name = "gorev";
            this.gorev.Size = new System.Drawing.Size(100, 21);
            this.gorev.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Görevi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Birim Saat Maliyeti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Aylık Maliyet";
            // 
            // aylik
            // 
            this.aylik.Location = new System.Drawing.Point(42, 188);
            this.aylik.Name = "aylik";
            this.aylik.Size = new System.Drawing.Size(100, 20);
            this.aylik.TabIndex = 17;
            this.aylik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aylik_KeyPress);
            // 
            // birim
            // 
            this.birim.Location = new System.Drawing.Point(42, 149);
            this.birim.Name = "birim";
            this.birim.Size = new System.Drawing.Size(100, 20);
            this.birim.TabIndex = 18;
            this.birim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.birim_KeyPress);
            // 
            // duzenle
            // 
            this.duzenle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.duzenle.Location = new System.Drawing.Point(42, 293);
            this.duzenle.Name = "duzenle";
            this.duzenle.Size = new System.Drawing.Size(101, 33);
            this.duzenle.TabIndex = 19;
            this.duzenle.Text = "DUZENLE";
            this.duzenle.UseVisualStyleBackColor = true;
            this.duzenle.Click += new System.EventHandler(this.duzenle_Click_1);
            // 
            // idgir
            // 
            this.idgir.Location = new System.Drawing.Point(54, 267);
            this.idgir.Name = "idgir";
            this.idgir.Size = new System.Drawing.Size(91, 20);
            this.idgir.TabIndex = 20;
            this.idgir.Text = "ID GIR";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(30, 270);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(21, 13);
            this.id.TabIndex = 21;
            this.id.Text = "ID:";
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 387);
            this.Controls.Add(this.id);
            this.Controls.Add(this.idgir);
            this.Controls.Add(this.duzenle);
            this.Controls.Add(this.birim);
            this.Controls.Add(this.aylik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gorev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.adisoyadi);
            this.Controls.Add(this.tablopersonel);
            this.Name = "Personel";
            this.Text = "Personel";
            ((System.ComponentModel.ISupportInitialize)(this.tablopersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablopersonel;
        private System.Windows.Forms.TextBox adisoyadi;
        private System.Windows.Forms.TextBox tc;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox gorev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox aylik;
        private System.Windows.Forms.TextBox birim;
        private System.Windows.Forms.Button duzenle;
        private System.Windows.Forms.TextBox idgir;
        private System.Windows.Forms.Label id;
    }
}