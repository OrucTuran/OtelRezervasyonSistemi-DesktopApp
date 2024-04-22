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
    public partial class FrmUrunKarti : Form
    {
        DbOtelYeniEntities db = new DbOtelYeniEntities();
        Repository<TblUrun> repo = new Repository<TblUrun>();
        TblUrun t = new TblUrun();
        public int id;

        public FrmUrunKarti()
        {
            InitializeComponent();
        }

        private void FrmUrunKarti_Load(object sender, EventArgs e)
        {
            //ürün grubu listesi
            LookUpEditUrunGrup.Properties.DataSource = (from x in db.TblUrunGrup
                                                        select new
                                                        {
                                                            x.UrunGrupID,
                                                            x.UrunGrupAd
                                                        }).ToList();
            //birim listesi
            LookUpEditBirim.Properties.DataSource = (from x in db.TblBirim
                                                     select new
                                                     {
                                                         x.BirimID,
                                                         x.BirimAd
                                                     }).ToList();

            //Durum listesi
            LookUpEditDurum.Properties.DataSource = (from x in db.TblDurum
                                                     select new
                                                     {
                                                         x.DurumID,
                                                         x.DurumAd
                                                     }).ToList();
            //ürün güncelleme alani
            if (id!=0)
            {
                var urun = repo.Find(x => x.UrunID == id);
                TxtUrunAdi.Text = urun.UrunAd;
                LookUpEditUrunGrup.EditValue = urun.UrunGrup;
                LookUpEditBirim.EditValue = urun.Birim;
                TxtFiyat.Text = urun.Fiyat.ToString();
                TxtToplam.Text = urun.Toplam.ToString();
                TxtKDV.Text = urun.Kdv.ToString();
                TxtAciklama.Text = urun.Aciklama;
                LookUpEditDurum.EditValue = urun.Durum;
            }
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            t.UrunAd = TxtUrunAdi.Text;
            t.UrunGrup = int.Parse(LookUpEditUrunGrup.EditValue.ToString());
            t.Birim = int.Parse(LookUpEditBirim.EditValue.ToString());
            t.Durum = int.Parse(LookUpEditDurum.EditValue.ToString());
            t.Fiyat = decimal.Parse(TxtFiyat.Text);
            t.Toplam = decimal.Parse(TxtToplam.Text);
            t.Kdv = byte.Parse(TxtKDV.Text);
            t.Aciklama = TxtAciklama.Text;

            repo.TAdd(t);
            XtraMessageBox.Show("Ürün başarılı bir şekilde veri tabanına kayıt edildi.");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var urunDeger = repo.Find(x => x.UrunID == id);
            urunDeger.UrunAd = TxtUrunAdi.Text;
            urunDeger.UrunGrup = int.Parse(LookUpEditUrunGrup.EditValue.ToString());
            urunDeger.Birim = int.Parse(LookUpEditBirim.EditValue.ToString());
            urunDeger.Durum = int.Parse(LookUpEditDurum.EditValue.ToString());
            urunDeger.Fiyat = decimal.Parse(TxtFiyat.Text);
            urunDeger.Toplam = decimal.Parse(TxtToplam.Text);
            urunDeger.Kdv = byte.Parse(TxtKDV.Text);
            urunDeger.Aciklama = TxtAciklama.Text;

            repo.TUpdate(urunDeger);
            XtraMessageBox.Show("Ürün başarılı bir şekilde güncellendi.");
        }

        private void Rdb1_CheckedChanged(object sender, EventArgs e)
        {
            TxtKDV.Text = "1";
        }

        private void Rdb8_CheckedChanged(object sender, EventArgs e)
        {
            TxtKDV.Text = "8";
        }

        private void Rdb10_CheckedChanged(object sender, EventArgs e)
        {
            TxtKDV.Text = "10";
        }

        private void Rdb18_CheckedChanged(object sender, EventArgs e)
        {
            TxtKDV.Text = "18";
        }
    }
}
