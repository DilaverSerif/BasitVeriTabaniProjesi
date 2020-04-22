namespace ProjeOdevi
{
    partial class Istasyon
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
            this.aciklamabox = new System.Windows.Forms.TextBox();
            this.hammadde = new System.Windows.Forms.TextBox();
            this.maliyet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ekle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.duzenle = new System.Windows.Forms.Button();
            this.istasyontablo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.istasyontablo)).BeginInit();
            this.SuspendLayout();
            // 
            // kodbox
            // 
            this.kodbox.Location = new System.Drawing.Point(12, 29);
            this.kodbox.Name = "kodbox";
            this.kodbox.Size = new System.Drawing.Size(100, 20);
            this.kodbox.TabIndex = 0;
            // 
            // aciklamabox
            // 
            this.aciklamabox.Location = new System.Drawing.Point(12, 72);
            this.aciklamabox.Multiline = true;
            this.aciklamabox.Name = "aciklamabox";
            this.aciklamabox.Size = new System.Drawing.Size(166, 73);
            this.aciklamabox.TabIndex = 1;
            // 
            // hammadde
            // 
            this.hammadde.Location = new System.Drawing.Point(12, 164);
            this.hammadde.Name = "hammadde";
            this.hammadde.Size = new System.Drawing.Size(100, 20);
            this.hammadde.TabIndex = 2;
            // 
            // maliyet
            // 
            this.maliyet.Location = new System.Drawing.Point(12, 207);
            this.maliyet.Name = "maliyet";
            this.maliyet.Size = new System.Drawing.Size(100, 20);
            this.maliyet.TabIndex = 3;
            this.maliyet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maliyet_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "İş İstasyonu Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "İstasyon Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hammadde Ambarı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "İstasyon Maliyeti";
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(78, 292);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(100, 20);
            this.idbox.TabIndex = 8;
            this.idbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(90, 249);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(75, 23);
            this.ekle.TabIndex = 10;
            this.ekle.Text = "EKLE";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(37, 318);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 23);
            this.sil.TabIndex = 11;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // duzenle
            // 
            this.duzenle.Location = new System.Drawing.Point(150, 318);
            this.duzenle.Name = "duzenle";
            this.duzenle.Size = new System.Drawing.Size(75, 23);
            this.duzenle.TabIndex = 12;
            this.duzenle.Text = "DÜZENLE";
            this.duzenle.UseVisualStyleBackColor = true;
            this.duzenle.Click += new System.EventHandler(this.duzenle_Click);
            // 
            // istasyontablo
            // 
            this.istasyontablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.istasyontablo.Location = new System.Drawing.Point(275, 13);
            this.istasyontablo.Name = "istasyontablo";
            this.istasyontablo.Size = new System.Drawing.Size(302, 425);
            this.istasyontablo.TabIndex = 13;
            // 
            // Istasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.istasyontablo);
            this.Controls.Add(this.duzenle);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maliyet);
            this.Controls.Add(this.hammadde);
            this.Controls.Add(this.aciklamabox);
            this.Controls.Add(this.kodbox);
            this.Name = "Istasyon";
            this.Text = "İstasyon";
            ((System.ComponentModel.ISupportInitialize)(this.istasyontablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kodbox;
        private System.Windows.Forms.TextBox aciklamabox;
        private System.Windows.Forms.TextBox hammadde;
        private System.Windows.Forms.TextBox maliyet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button duzenle;
        private System.Windows.Forms.DataGridView istasyontablo;
    }
}