namespace CS_Kütüphane_Otomasyonu
{
    partial class frmAnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnuyelistele = new System.Windows.Forms.Button();
            this.btnuyeekle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnkitlistele = new System.Windows.Forms.Button();
            this.btnkitekle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnkitiade = new System.Windows.Forms.Button();
            this.btnkitlisteleme = new System.Windows.Forms.Button();
            this.btnkitverme = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btngrafik = new System.Windows.Forms.Button();
            this.btnsıralama = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnuyelistele);
            this.groupBox1.Controls.Add(this.btnuyeekle);
            this.groupBox1.Location = new System.Drawing.Point(56, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye İşlemleri";
            // 
            // btnuyelistele
            // 
            this.btnuyelistele.Location = new System.Drawing.Point(24, 78);
            this.btnuyelistele.Name = "btnuyelistele";
            this.btnuyelistele.Size = new System.Drawing.Size(212, 39);
            this.btnuyelistele.TabIndex = 1;
            this.btnuyelistele.Text = "Üye listeleme işlemleri";
            this.btnuyelistele.UseVisualStyleBackColor = true;
            this.btnuyelistele.Click += new System.EventHandler(this.btnuyelistele_Click);
            // 
            // btnuyeekle
            // 
            this.btnuyeekle.Location = new System.Drawing.Point(24, 32);
            this.btnuyeekle.Name = "btnuyeekle";
            this.btnuyeekle.Size = new System.Drawing.Size(212, 40);
            this.btnuyeekle.TabIndex = 0;
            this.btnuyeekle.Text = "Üye ekleme işlemleri";
            this.btnuyeekle.UseVisualStyleBackColor = true;
            this.btnuyeekle.Click += new System.EventHandler(this.btnuyeekle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnkitlistele);
            this.groupBox2.Controls.Add(this.btnkitekle);
            this.groupBox2.Location = new System.Drawing.Point(380, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 137);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İşlemleri";
            // 
            // btnkitlistele
            // 
            this.btnkitlistele.Location = new System.Drawing.Point(33, 78);
            this.btnkitlistele.Name = "btnkitlistele";
            this.btnkitlistele.Size = new System.Drawing.Size(206, 39);
            this.btnkitlistele.TabIndex = 1;
            this.btnkitlistele.Text = "Kitap listeleme işlemleri";
            this.btnkitlistele.UseVisualStyleBackColor = true;
            this.btnkitlistele.Click += new System.EventHandler(this.btnkitlistele_Click);
            // 
            // btnkitekle
            // 
            this.btnkitekle.Location = new System.Drawing.Point(33, 32);
            this.btnkitekle.Name = "btnkitekle";
            this.btnkitekle.Size = new System.Drawing.Size(206, 40);
            this.btnkitekle.TabIndex = 0;
            this.btnkitekle.Text = "Kitap ekleme işlemleri";
            this.btnkitekle.UseVisualStyleBackColor = true;
            this.btnkitekle.Click += new System.EventHandler(this.btnkitekle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnkitiade);
            this.groupBox3.Controls.Add(this.btnkitlisteleme);
            this.groupBox3.Controls.Add(this.btnkitverme);
            this.groupBox3.Location = new System.Drawing.Point(56, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 219);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emanet kitap işlemleri ";
            // 
            // btnkitiade
            // 
            this.btnkitiade.Location = new System.Drawing.Point(24, 157);
            this.btnkitiade.Name = "btnkitiade";
            this.btnkitiade.Size = new System.Drawing.Size(206, 41);
            this.btnkitiade.TabIndex = 4;
            this.btnkitiade.Text = "Emanet kitap iade işlemleri";
            this.btnkitiade.UseVisualStyleBackColor = true;
            this.btnkitiade.Click += new System.EventHandler(this.btnkitiade_Click);
            // 
            // btnkitlisteleme
            // 
            this.btnkitlisteleme.Location = new System.Drawing.Point(24, 102);
            this.btnkitlisteleme.Name = "btnkitlisteleme";
            this.btnkitlisteleme.Size = new System.Drawing.Size(206, 49);
            this.btnkitlisteleme.TabIndex = 3;
            this.btnkitlisteleme.Text = "Emanet kitap listeleme işlemleri";
            this.btnkitlisteleme.UseVisualStyleBackColor = true;
            this.btnkitlisteleme.Click += new System.EventHandler(this.btnkitlisteleme_Click);
            // 
            // btnkitverme
            // 
            this.btnkitverme.Location = new System.Drawing.Point(24, 39);
            this.btnkitverme.Name = "btnkitverme";
            this.btnkitverme.Size = new System.Drawing.Size(206, 57);
            this.btnkitverme.TabIndex = 2;
            this.btnkitverme.Text = "Emanet kitap verme işlemleri";
            this.btnkitverme.UseVisualStyleBackColor = true;
            this.btnkitverme.Click += new System.EventHandler(this.btnkitverme_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btngrafik);
            this.groupBox4.Controls.Add(this.btnsıralama);
            this.groupBox4.Location = new System.Drawing.Point(380, 234);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 219);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sıralama ve grafikler";
            // 
            // btngrafik
            // 
            this.btngrafik.Location = new System.Drawing.Point(33, 102);
            this.btngrafik.Name = "btngrafik";
            this.btngrafik.Size = new System.Drawing.Size(206, 50);
            this.btngrafik.TabIndex = 6;
            this.btngrafik.Text = "Grafikler";
            this.btngrafik.UseVisualStyleBackColor = true;
            this.btngrafik.Click += new System.EventHandler(this.btngrafik_Click);
            // 
            // btnsıralama
            // 
            this.btnsıralama.Location = new System.Drawing.Point(33, 39);
            this.btnsıralama.Name = "btnsıralama";
            this.btnsıralama.Size = new System.Drawing.Size(206, 57);
            this.btnsıralama.TabIndex = 5;
            this.btnsıralama.Text = "Sıralama ";
            this.btnsıralama.UseVisualStyleBackColor = true;
            this.btnsıralama.Click += new System.EventHandler(this.btnsıralama_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(695, 504);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAnaSayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnuyelistele;
        private System.Windows.Forms.Button btnuyeekle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnkitlistele;
        private System.Windows.Forms.Button btnkitekle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnkitiade;
        private System.Windows.Forms.Button btnkitlisteleme;
        private System.Windows.Forms.Button btnkitverme;
        private System.Windows.Forms.Button btngrafik;
        private System.Windows.Forms.Button btnsıralama;
    }
}

