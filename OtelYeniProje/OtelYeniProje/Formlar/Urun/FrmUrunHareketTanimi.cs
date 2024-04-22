using DevExpress.XtraEditors;
using OtelYeniProje.Entity;
using OtelYeniProje.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelYeniProje.Formlar.Urun
{
    public partial class FrmUrunHareketTanimi : Form
    {
        DbOtelYeniEntities db = new DbOtelYeniEntities();
        Repository<TblUrunHareket> repo = new Repository<TblUrunHareket>();
        TblUrunHareket t = new TblUrunHareket();
        public int id;

        //ürün giris icin
        double miktar;
        double birimFiyat;
        double toplam;
        public FrmUrunHareketTanimi()
        {
            InitializeComponent();
        }

        private void FrmUrunHareketTanimi_Load(object sender, EventArgs e)
        {
            //id değeri
            TxtID.Text = id.ToString();

            //ürün grubu listesi
            LookUpEditUrun.Properties.DataSource = (from x in db.TblUrun
                                                    select new
                                                    {
                                                        x.UrunID,
                                                        x.UrunAd
                                                    }).ToList();

            //verilerin kart alanlarına doldurulması
            if (id != 0)
            {
                var urun = repo.Find(x => x.HareketID == id);
                LookUpEditUrun.EditValue = urun.Urun/*<-- tablodaki urun*/;
                nudMiktar.Text = urun.Miktar.ToString();
                TxtAciklama.Text = urun.Aciklama;
                ComboBoxHareketTuru.Text = urun.HareketTuru;
                DateEditTarih.Text = urun.Tarih.ToString();
            }

        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            t.Urun = int.Parse(LookUpEditUrun.EditValue.ToString());
            t.Tarih = DateTime.Parse(DateEditTarih.Text);
            t.HareketTuru = ComboBoxHareketTuru.Text;
            t.Miktar = decimal.Parse(nudMiktar.Text);
            t.Aciklama = TxtAciklama.Text;
            t.BirimFiyat = nudBirimFiyat.Value;
            t.ToplamFiyat = nudBirimFiyat.Value * nudMiktar.Value;
            repo.TAdd(t);
            XtraMessageBox.Show("Ürün hareketi sisteme kayıt edildi.");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var urun = repo.Find(x => x.HareketID == id);
            urun.Urun = int.Parse(LookUpEditUrun.EditValue.ToString());
            urun.Tarih = DateTime.Parse(DateEditTarih.Text);
            urun.HareketTuru = ComboBoxHareketTuru.Text;
            urun.Miktar = decimal.Parse(nudMiktar.Text);
            urun.Aciklama = TxtAciklama.Text;
            urun.BirimFiyat = nudBirimFiyat.Value;
            urun.ToplamFiyat = nudBirimFiyat.Value * nudMiktar.Value;
            repo.TUpdate(urun);
            XtraMessageBox.Show("Ürün hareketi güncellendi.");
        }



        private void nudBirimFiyat_ValueChanged(object sender, EventArgs e)
        {
            if (ComboBoxHareketTuru.Text == "Giriş")
            {
                if (double.TryParse(nudBirimFiyat.Value.ToString(), out birimFiyat))
                {
                    if (double.TryParse(nudMiktar.Value.ToString(), out miktar))
                    {
                        toplam = miktar * birimFiyat;
                        TxtToplamFiyat.Text = toplam.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir miktar girin.");
                    }
                }
                else
                {
                    MessageBox.Show("Geçerli bir birim fiyat girin.");
                }
            }
        }

        private void nudMiktar_ValueChanged(object sender, EventArgs e)
        {
            if (double.TryParse(nudMiktar.Value.ToString(), out miktar))
            {
                if (double.TryParse(nudBirimFiyat.Value.ToString(), out birimFiyat))
                {
                    toplam = miktar * birimFiyat;
                    TxtToplamFiyat.Text = toplam.ToString();
                }
                else
                {
                    MessageBox.Show("Geçerli bir birim fiyat girin.");
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir miktar girin.");
            }
        }
    }
}
