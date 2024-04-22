using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelYeniProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDurumTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanimlamalar.FrmDurum fr = new Formlar.Tanimlamalar.FrmDurum();
            fr.Show();
        }

        private void btnBirimTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanimlamalar.FrmBirim fr = new Formlar.Tanimlamalar.FrmBirim();
            fr.Show();
        }

        private void btnDepartmanTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanimlamalar.FrmDepartman fr = new Formlar.Tanimlamalar.FrmDepartman();
            fr.Show();
        }

        private void btnGorevTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanimlamalar.frmGorev fr = new Formlar.Tanimlamalar.frmGorev();
            fr.Show();
        }

        private void BtnKasaTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanimlamalar.FrmKasa fr = new Formlar.Tanimlamalar.FrmKasa();
            fr.Show();
        }

        private void BtnKurTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanimlamalar.FrmKur fr = new Formlar.Tanimlamalar.FrmKur();
            fr.Show();
        }

        private void BtnOdaTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanimlamalar.FrmOda fr = new Formlar.Tanimlamalar.FrmOda();
            fr.Show();
        }

        private void BtnTelefonTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanimlamalar.FrmTelefon fr = new Formlar.Tanimlamalar.FrmTelefon();
            fr.Show();
        }

        private void BtnUlkeTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanimlamalar.FrmUlke fr = new Formlar.Tanimlamalar.FrmUlke();
            fr.Show();
        }

        private void BtnUrunGrupTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanimlamalar.FrmUrunGrup fr = new Formlar.Tanimlamalar.FrmUrunGrup();
            fr.Show();
        }

        private void BtnPersonelKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Personel.FrmPersonelKarti fr = new Formlar.Personel.FrmPersonelKarti();
            fr.Show();
        }

        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Personel.FrmPersonelListesi fr = new Formlar.Personel.FrmPersonelListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnMisafirKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Misafir.FrmMisafirKarti fr = new Formlar.Misafir.FrmMisafirKarti();
            fr.Show();
        }

        private void BtnMusteriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Misafir.FrmMisafirListesi fr = new Formlar.Misafir.FrmMisafirListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Urun.FrmUrunListesi fr = new Formlar.Urun.FrmUrunListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnUrunKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Urun.FrmUrunKarti fr = new Formlar.Urun.FrmUrunKarti();
            fr.Show();
        }

        private void BtnUrunGirisHareketleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Urun.FrmUrunGirisHareketleri fr = new Formlar.Urun.FrmUrunGirisHareketleri();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnUrunCikisHareketleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Urun.FrmUrunCikisHareketleri fr = new Formlar.Urun.FrmUrunCikisHareketleri();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYeniUrunHareketi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Urun.FrmUrunHareketTanimi fr = new Formlar.Urun.FrmUrunHareketTanimi();
            fr.Show();
        }

        private void BtnRezervasyonKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Rezervasyon.FrmRezervasyonKarti fr = new Formlar.Rezervasyon.FrmRezervasyonKarti();
            fr.Show();
        }

        private void BtnTumRezervasyonListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Rezervasyon.FrmTumRezervasyonlar fr = new Formlar.Rezervasyon.FrmTumRezervasyonlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnAktifRezervasyonlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Rezervasyon.FrmAktifRezervasyonlar fr = new Formlar.Rezervasyon.FrmAktifRezervasyonlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnIptalEdilenRezervasyonlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Rezervasyon.FrmIptalRezervasyonlar fr = new Formlar.Rezervasyon.FrmIptalRezervasyonlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnGecmisRezervasyonlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Rezervasyon.FrmGecmisRezervasyonlar fr = new Formlar.Rezervasyon.FrmGecmisRezervasyonlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnGelecekRezervasyonlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Rezervasyon.FrmGelecekRezervasyonlar fr = new Formlar.Rezervasyon.FrmGelecekRezervasyonlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void BtnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void BtnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void BtnKurlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Araclar.FrmKurlar fr = new Formlar.Araclar.FrmKurlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Araclar.FrnYoutube fr = new Formlar.Araclar.FrnYoutube();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnWeb_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Araclar.FrmGoogle fr = new Formlar.Araclar.FrmGoogle();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYeniKayitlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.WebSite.FrmYeniKayit fr = new Formlar.WebSite.FrmYeniKayit();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnOnRezervasyonlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.WebSite.FrmOnRezervasyon fr = new Formlar.WebSite.FrmOnRezervasyon();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnGelenMesajlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.WebSite.FrmGelenMesajlar fr = new Formlar.WebSite.FrmGelenMesajlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnYeniMesaj_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.WebSite.FrmMesajKarti fr = new Formlar.WebSite.FrmMesajKarti();
            fr.Show();
        }

        private void btnGidenMesajlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.WebSite.FrmGidenMesajlar fr = new Formlar.WebSite.FrmGidenMesajlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnIletisim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.WebSite.FrmIletisim fr = new Formlar.WebSite.FrmIletisim();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnAdresKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.WebSite.FrmAdresKarti fr = new Formlar.WebSite.FrmAdresKarti();
            fr.Show();
        }

        private void BtnHakkimda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.WebSite.FrmHakkimizda fr = new Formlar.WebSite.FrmHakkimizda();
            fr.Show();
        }

        private void BtnAnaForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.AnaForm.FrmAnaForm fr = new Formlar.AnaForm.FrmAnaForm();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnGrafikPie_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Grafikler.FrmUrunStokGrafik fr = new Formlar.Grafikler.FrmUrunStokGrafik();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnOdaDolulukGrafik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Grafikler.FrmOdaDolulukGrafigi fr = new Formlar.Grafikler.FrmOdaDolulukGrafigi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnSifreIslemleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Admin.FrmAdminSifreIslemleri fr = new Formlar.Admin.FrmAdminSifreIslemleri();
            fr.Show();
        }

        public string kullaniciRolu; //giris panelinde rol atamasi yapildi/yapilacak
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = kullaniciRolu;

            using (var veritabani = new OtelYeniProje.Entity.DbOtelYeniEntities())
            {
                var adminRol = veritabani.TblAdmin.OrderBy(a => a.Rol).Skip(2).FirstOrDefault()?.Rol; //rolu b olana erisim saglandi. ""B => 2. indexte""
                if (adminRol != null)
                {
                    if (kullaniciRolu != adminRol)
                    {
                        ribbonPageTanimlamalar.Visible = false;
                    }
                }
            }
            Formlar.AnaForm.FrmAnaForm fr = new Formlar.AnaForm.FrmAnaForm();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYetkiler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Admin.FrmAdminSifreIslemleri fr = new Formlar.Admin.FrmAdminSifreIslemleri();
            fr.Show();
        }

        private void BtnResepsiyonHareket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Kasa.FrmResepsiyonHareket fr = new Formlar.Kasa.FrmResepsiyonHareket();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYeniKasaHareket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanimlamalar.FrmKasa fr = new Formlar.Tanimlamalar.FrmKasa();
            fr.Show();
        }

        private void BtnKasaCikisKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Kasa.FrmKasaCikisKarti fr = new Formlar.Kasa.FrmKasaCikisKarti();
            fr.Show();
        }

        private void BtnKasaCikisHareketleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Kasa.FrmKasaCikisHareketListesi fr = new Formlar.Kasa.FrmKasaCikisHareketListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnRaporSihirbazi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Raporlar.FrmRapor fr = new Formlar.Raporlar.FrmRapor();
            fr.Show();
        }
    }
}
