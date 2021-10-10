using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev3
{
    public partial class frmEkran : Form
    {
        public frmEkran()
        {
            InitializeComponent();
        }

        bool MukemmelSayiKontrol(int sayi)
        {
            bool mukkemelSayi = false;
            int toplam = 0;
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    toplam += i;
                }
            }
            if (toplam == sayi)
                mukkemelSayi = true;
            return mukkemelSayi;
        }

        bool AsalSayiKontrol(int sayi)
        {
            bool asalSayi = true;
            {
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                        asalSayi = false;
                }
                return asalSayi;
            }
        }
        void Temizleme()
        {
            lvTek.Items.Clear();
            lvCift.Items.Clear();
            lvAsal.Items.Clear();
            lvMukkemel.Items.Clear();
        }
        bool Kontrol(String mtbBaslangic, String mtbBitis)
        {
            int baslangic, bitis;
            try
            {
                baslangic = Convert.ToInt32(mtbBaslangic);
                bitis = Convert.ToInt32(mtbBitis);
            }
            catch (Exception)
            {
                return false;
            }
            if (baslangic > bitis || baslangic < 1 || baslangic > 10000)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnCalistir_Click(object sender, EventArgs e)
        {
            int baslangic, bitis, tekToplam = 0, ciftToplam = 0, asalToplam = 0, mukkemelToplam = 0;
            long tekCarpim = 1, ciftCarpim = 1, asalCarpim = 1, mukkemelCarpim = 1;

            mtbBaslangic.Focus();


            Temizleme();

            if (!Kontrol(mtbBaslangic.Text, mtbBitis.Text))
            {
                MessageBox.Show("Hatalı Giriş");

                mtbBaslangic.Text = "";
                mtbBitis.Text = "";
            }
            else
            {

                baslangic = Convert.ToInt32(mtbBaslangic.Text);
                bitis = Convert.ToInt32(mtbBitis.Text);

                for (int i = baslangic; i < bitis; i++)
                {
                    if (i % 2 == 1)
                    {
                        tekToplam += i;
                        tekCarpim *= i;
                        lvTek.Items.Add(i.ToString());
                    }
                    else
                    {
                        ciftToplam += i;
                        ciftCarpim *= i;
                        lvCift.Items.Add(i.ToString());
                    }

                    if (AsalSayiKontrol(i))
                    {
                        if (i != 1)
                        {
                            asalToplam += i;
                            asalCarpim *= i;
                            lvAsal.Items.Add(i.ToString());
                        }
                    }

                    if (MukemmelSayiKontrol(i))
                    {
                        mukkemelToplam += i;
                        mukkemelCarpim *= i;
                        lvMukkemel.Items.Add(i.ToString());
                    }

                }
                lvTek.Items.Add("Tek sayıların toplamı: " + tekToplam);
                lvTek.Items.Add("Tek sayıların çarpımı: " + tekCarpim);
                lvCift.Items.Add("Cift sayıların toplamı: " + ciftToplam);
                lvCift.Items.Add("Cift sayıların çarpımı: " + ciftCarpim);
                lvAsal.Items.Add("Asal sayıların toplamı: " + asalToplam);
                lvAsal.Items.Add("Asal sayıların çarpımı: " + asalCarpim);
                lvMukkemel.Items.Add("Mükkemel sayıların toplamı: " + mukkemelToplam);
                lvMukkemel.Items.Add("Mükkemel sayıların çarpımı: " + mukkemelCarpim);

                mtbBaslangic.Text = "";
                mtbBitis.Text = "";

            }
        }
        private void frmEkran_Load(object sender, EventArgs e)
        {
            mtbBaslangic.Focus();

            girisUyarisi.Visible = true;
            girisUyarisi.Icon = SystemIcons.Application;
            girisUyarisi.BalloonTipIcon = ToolTipIcon.Info;
            girisUyarisi.ShowBalloonTip(2000);
        }
    }
}