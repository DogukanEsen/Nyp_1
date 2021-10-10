
namespace ödev3
{
    partial class frmEkran
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvTek = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvCift = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lvAsal = new System.Windows.Forms.ListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lvMukkemel = new System.Windows.Forms.ListView();
            this.gbGiris = new System.Windows.Forms.GroupBox();
            this.btnCalistir = new System.Windows.Forms.Button();
            this.mtbBitis = new System.Windows.Forms.MaskedTextBox();
            this.lblBitis = new System.Windows.Forms.Label();
            this.mtbBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.girisUyarisi = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.gbGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(70, 228);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 200);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvTek);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(652, 174);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tek Sayılar ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvTek
            // 
            this.lvTek.HideSelection = false;
            this.lvTek.Location = new System.Drawing.Point(0, -2);
            this.lvTek.Name = "lvTek";
            this.lvTek.Size = new System.Drawing.Size(652, 178);
            this.lvTek.TabIndex = 1;
            this.lvTek.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvCift);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(652, 174);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Çift Sayılar ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvCift
            // 
            this.lvCift.HideSelection = false;
            this.lvCift.Location = new System.Drawing.Point(0, -2);
            this.lvCift.Name = "lvCift";
            this.lvCift.Size = new System.Drawing.Size(652, 178);
            this.lvCift.TabIndex = 1;
            this.lvCift.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lvAsal);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(652, 174);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Asal  Sayılar ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lvAsal
            // 
            this.lvAsal.HideSelection = false;
            this.lvAsal.Location = new System.Drawing.Point(0, -2);
            this.lvAsal.Name = "lvAsal";
            this.lvAsal.Size = new System.Drawing.Size(652, 178);
            this.lvAsal.TabIndex = 1;
            this.lvAsal.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lvMukkemel);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(652, 174);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Mükkemel Sayılar ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lvMukkemel
            // 
            this.lvMukkemel.HideSelection = false;
            this.lvMukkemel.Location = new System.Drawing.Point(0, 0);
            this.lvMukkemel.Name = "lvMukkemel";
            this.lvMukkemel.Size = new System.Drawing.Size(652, 178);
            this.lvMukkemel.TabIndex = 0;
            this.lvMukkemel.UseCompatibleStateImageBehavior = false;
            // 
            // gbGiris
            // 
            this.gbGiris.Controls.Add(this.btnCalistir);
            this.gbGiris.Controls.Add(this.mtbBitis);
            this.gbGiris.Controls.Add(this.lblBitis);
            this.gbGiris.Controls.Add(this.mtbBaslangic);
            this.gbGiris.Controls.Add(this.lblBaslangic);
            this.gbGiris.Location = new System.Drawing.Point(70, 28);
            this.gbGiris.Name = "gbGiris";
            this.gbGiris.Size = new System.Drawing.Size(660, 136);
            this.gbGiris.TabIndex = 0;
            this.gbGiris.TabStop = false;
            this.gbGiris.Text = "Giriş Bilgileri";
            // 
            // btnCalistir
            // 
            this.btnCalistir.Location = new System.Drawing.Point(518, 59);
            this.btnCalistir.Name = "btnCalistir";
            this.btnCalistir.Size = new System.Drawing.Size(75, 23);
            this.btnCalistir.TabIndex = 4;
            this.btnCalistir.Text = "Çalıştır";
            this.btnCalistir.UseVisualStyleBackColor = true;
            this.btnCalistir.Click += new System.EventHandler(this.btnCalistir_Click);
            // 
            // mtbBitis
            // 
            this.mtbBitis.Location = new System.Drawing.Point(277, 63);
            this.mtbBitis.Name = "mtbBitis";
            this.mtbBitis.Size = new System.Drawing.Size(100, 20);
            this.mtbBitis.TabIndex = 3;
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Location = new System.Drawing.Point(236, 63);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(35, 13);
            this.lblBitis.TabIndex = 2;
            this.lblBitis.Text = "Bitiş:  ";
            // 
            // mtbBaslangic
            // 
            this.mtbBaslangic.Location = new System.Drawing.Point(87, 63);
            this.mtbBaslangic.Name = "mtbBaslangic";
            this.mtbBaslangic.Size = new System.Drawing.Size(100, 20);
            this.mtbBaslangic.TabIndex = 1;
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Location = new System.Drawing.Point(22, 63);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(59, 13);
            this.lblBaslangic.TabIndex = 0;
            this.lblBaslangic.Text = "Başlangıc: ";
            // 
            // girisUyarisi
            // 
            this.girisUyarisi.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.girisUyarisi.BalloonTipText = "Nesne Yönelimli Programlama ödev 1";
            this.girisUyarisi.BalloonTipTitle = "Programa Hoşgeldiniz";
            this.girisUyarisi.Visible = true;
            // 
            // frmEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbGiris);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmEkran";
            this.Text = "Odev1";
            this.Load += new System.EventHandler(this.frmEkran_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.gbGiris.ResumeLayout(false);
            this.gbGiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox gbGiris;
        private System.Windows.Forms.Button btnCalistir;
        private System.Windows.Forms.MaskedTextBox mtbBitis;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.MaskedTextBox mtbBaslangic;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.ListView lvTek;
        private System.Windows.Forms.ListView lvCift;
        private System.Windows.Forms.ListView lvAsal;
        private System.Windows.Forms.ListView lvMukkemel;
        private System.Windows.Forms.NotifyIcon girisUyarisi;
    }
}

