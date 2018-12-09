namespace Listboxsayiödev
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnkuponolustur = new System.Windows.Forms.Button();
            this.txtkuponsayisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbitis = new System.Windows.Forms.TextBox();
            this.txtbaslangıc = new System.Windows.Forms.TextBox();
            this.lsbkuponlar = new System.Windows.Forms.ListBox();
            this.lsbsayiadetleri = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Başlangıç Sayısı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnkuponolustur);
            this.groupBox1.Controls.Add(this.txtkuponsayisi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbitis);
            this.groupBox1.Controls.Add(this.txtbaslangıc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 222);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kupon Oluştur";
            // 
            // btnkuponolustur
            // 
            this.btnkuponolustur.Location = new System.Drawing.Point(9, 143);
            this.btnkuponolustur.Name = "btnkuponolustur";
            this.btnkuponolustur.Size = new System.Drawing.Size(229, 23);
            this.btnkuponolustur.TabIndex = 6;
            this.btnkuponolustur.Text = "Kupon Oluştur";
            this.btnkuponolustur.UseVisualStyleBackColor = true;
            this.btnkuponolustur.Click += new System.EventHandler(this.btnkuponolustur_Click);
            // 
            // txtkuponsayisi
            // 
            this.txtkuponsayisi.Location = new System.Drawing.Point(112, 99);
            this.txtkuponsayisi.Name = "txtkuponsayisi";
            this.txtkuponsayisi.Size = new System.Drawing.Size(126, 20);
            this.txtkuponsayisi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kupon Sayısı:";
            // 
            // txtbitis
            // 
            this.txtbitis.Location = new System.Drawing.Point(112, 62);
            this.txtbitis.Name = "txtbitis";
            this.txtbitis.Size = new System.Drawing.Size(126, 20);
            this.txtbitis.TabIndex = 3;
            // 
            // txtbaslangıc
            // 
            this.txtbaslangıc.Location = new System.Drawing.Point(112, 28);
            this.txtbaslangıc.Name = "txtbaslangıc";
            this.txtbaslangıc.Size = new System.Drawing.Size(126, 20);
            this.txtbaslangıc.TabIndex = 2;
            // 
            // lsbkuponlar
            // 
            this.lsbkuponlar.FormattingEnabled = true;
            this.lsbkuponlar.Location = new System.Drawing.Point(294, 12);
            this.lsbkuponlar.Name = "lsbkuponlar";
            this.lsbkuponlar.Size = new System.Drawing.Size(202, 329);
            this.lsbkuponlar.TabIndex = 3;
            // 
            // lsbsayiadetleri
            // 
            this.lsbsayiadetleri.FormattingEnabled = true;
            this.lsbsayiadetleri.Location = new System.Drawing.Point(502, 12);
            this.lsbsayiadetleri.Name = "lsbsayiadetleri";
            this.lsbsayiadetleri.Size = new System.Drawing.Size(202, 329);
            this.lsbsayiadetleri.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "grafik olustur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 388);
            this.Controls.Add(this.lsbsayiadetleri);
            this.Controls.Add(this.lsbkuponlar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtkuponsayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbitis;
        private System.Windows.Forms.TextBox txtbaslangıc;
        private System.Windows.Forms.Button btnkuponolustur;
        private System.Windows.Forms.ListBox lsbkuponlar;
        private System.Windows.Forms.ListBox lsbsayiadetleri;
        private System.Windows.Forms.Button button1;
    }
}

