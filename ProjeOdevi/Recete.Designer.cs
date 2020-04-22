namespace ProjeOdevi
{
    partial class Recete
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
            this.anaurun = new System.Windows.Forms.TextBox();
            this.aciklama = new System.Windows.Forms.TextBox();
            this.recetetablo = new System.Windows.Forms.DataGridView();
            this.miktar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ekle = new System.Windows.Forms.Button();
            this.duzelt = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.idbox = new System.Windows.Forms.TextBox();
            this.idlable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recetetablo)).BeginInit();
            this.SuspendLayout();
            // 
            // anaurun
            // 
            this.anaurun.Location = new System.Drawing.Point(12, 34);
            this.anaurun.Name = "anaurun";
            this.anaurun.Size = new System.Drawing.Size(100, 20);
            this.anaurun.TabIndex = 0;
            // 
            // aciklama
            // 
            this.aciklama.Location = new System.Drawing.Point(12, 73);
            this.aciklama.Multiline = true;
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(156, 72);
            this.aciklama.TabIndex = 1;
            // 
            // recetetablo
            // 
            this.recetetablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recetetablo.Location = new System.Drawing.Point(186, 11);
            this.recetetablo.Name = "recetetablo";
            this.recetetablo.Size = new System.Drawing.Size(256, 426);
            this.recetetablo.TabIndex = 2;
            // 
            // miktar
            // 
            this.miktar.Location = new System.Drawing.Point(12, 164);
            this.miktar.Name = "miktar";
            this.miktar.Size = new System.Drawing.Size(100, 20);
            this.miktar.TabIndex = 3;
            this.miktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ana Ürün Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Miktar ve Satır ";
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(47, 202);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(75, 23);
            this.ekle.TabIndex = 7;
            this.ekle.Text = "EKLE";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // duzelt
            // 
            this.duzelt.Location = new System.Drawing.Point(47, 277);
            this.duzelt.Name = "duzelt";
            this.duzelt.Size = new System.Drawing.Size(75, 23);
            this.duzelt.TabIndex = 8;
            this.duzelt.Text = "DÜZELT";
            this.duzelt.UseVisualStyleBackColor = true;
            this.duzelt.Click += new System.EventHandler(this.duzelt_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(47, 306);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 23);
            this.sil.TabIndex = 9;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(34, 251);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(100, 20);
            this.idbox.TabIndex = 10;
            this.idbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // idlable
            // 
            this.idlable.AutoSize = true;
            this.idlable.Location = new System.Drawing.Point(10, 254);
            this.idlable.Name = "idlable";
            this.idlable.Size = new System.Drawing.Size(21, 13);
            this.idlable.TabIndex = 11;
            this.idlable.Text = "ID:";
            // 
            // Recete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.idlable);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.duzelt);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.miktar);
            this.Controls.Add(this.recetetablo);
            this.Controls.Add(this.aciklama);
            this.Controls.Add(this.anaurun);
            this.Name = "Recete";
            this.Text = "Recete";
            ((System.ComponentModel.ISupportInitialize)(this.recetetablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox anaurun;
        private System.Windows.Forms.TextBox aciklama;
        private System.Windows.Forms.DataGridView recetetablo;
        private System.Windows.Forms.TextBox miktar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button duzelt;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Label idlable;
    }
}