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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelYeniProje.Formlar.Rezervasyon
{
    public partial class FrmRezervasyonKarti : Form
    {
        DbOtelYeniEntities db = new DbOtelYeniEntities();
        Repository<TblRezervasyon> repo = new Repository<TblRezervasyon>();
        Repository<TblOda> repo2 = new Repository<TblOda>();
        TblRezervasyon t = new TblRezervasyon();
        public int id;
        int secilenMisafir;

        public FrmRezervasyonKarti()
        {
            InitializeComponent();
        }

        private void FrmRezervasyonKarti_Load(object sender, EventArgs e)
        {
            //misafir listesi
            lookUpEditMisafir.Properties.DataSource = (from x in db.TblMisafir
                                                       select new
                                                       {
                                                           x.MisafirID,
                                                           x.AdSoyad
                                                       }).ToList();
            //misafir listesi 2
            lookUpEditKisi2.Properties.DataSource = (from x in db.TblMisafir
                                                     select new
                                                     {
                                                         x.MisafirID,
                                                         x.AdSoyad
                                                     }).ToList();
            //misafir listesi 3
            lookUpEditKisi3.Properties.DataSource = (from x in db.TblMisafir
                                                     select new
                                                     {
                                                         x.MisafirID,
                                                         x.AdSoyad
                                                     }).ToList();
            //misafir listesi 4
            lookUpEditKisi4.Properties.DataSource = (from x in db.TblMisafir
                                                     select new
                                                     {
                                                         x.MisafirID,
                                                         x.AdSoyad
                                                     }).ToList();
            //oda listesi
            LookUpEditOda.Properties.DataSource = (from x in db.TblOda
                                                   select new
                                                   {
                                                       x.OdaID,
                                                       x.OdaNo,
                                                       x.TblDurum.DurumAd
                                                   }).Where(y => y.DurumAd == "Aktif").ToList();
            //durum listesi
            lookUpEditDurum.Properties.DataSource = (from x in db.TblDurum
                                                     select new
                                                     {
                                                         x.DurumID,
                                                         x.DurumAd
                                                     }).ToList();
            //Ürün güncelleme alanı
            if (id != 0)
            {
                var rezervasyon = repo.Find(x => x.RezervasyonID == id);
                TxtToplamTutar.Text = rezervasyon.ToplamTutar.ToString();
                lookUpEditMisafir.EditValue = rezervasyon.Misafir;
                lookUpEditKisi2.EditValue = rezervasyon.Kisi2;
                lookUpEditKisi3.EditValue = rezervasyon.Kisi3;
                lookUpEditKisi4.EditValue = rezervasyon.Kisi4;
                DateEditGirisTarihi.Text = rezervasyon.GirisTarihi.ToString();
                DateEditCikisTarihi.Text = rezervasyon.CikisTarihi.ToString();
                numericUpDownKisiSayisi.Value = decimal.Parse(rezervasyon.Kisi.ToString());
                LookUpEditOda.EditValue = rezervasyon.Oda;
                TxtTelefon.Text = rezervasyon.Telefon;
                TxtAciklama.Text = rezervasyon.Aciklama;
                lookUpEditDurum.EditValue = rezervasyon.Durum;
                TxtOdaNo.Text = rezervasyon.TblOda.OdaNo;
                rbOdemeAlindi.Checked = (bool)rezervasyon.OdemeAlindiMi;
            }
            rbOdemeAlindi.Enabled = true;
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                t.Misafir = lookUpEditMisafir.EditValue != null ? int.Parse(lookUpEditMisafir.EditValue.ToString()) : 0;
                t.Kisi2 = lookUpEditKisi2.EditValue != null ? int.Parse(lookUpEditKisi2.EditValue.ToString()) : 0;
                t.Kisi3 = lookUpEditKisi3.EditValue != null ? int.Parse(lookUpEditKisi3.EditValue.ToString()) : 0;
                t.Kisi4 = lookUpEditKisi4.EditValue != null ? int.Parse(lookUpEditKisi4.EditValue.ToString()) : 0;
                t.GirisTarihi = DateTime.Parse(DateEditGirisTarihi.Text);
                t.CikisTarihi = DateTime.Parse(DateEditCikisTarihi.Text);
                t.Kisi = numericUpDownKisiSayisi.Value.ToString();
                t.Oda = int.Parse(LookUpEditOda.EditValue.ToString());
                t.OdemeAlindiMi = rbOdemeAlindi.Checked;

                if (rbOdemeAlindi.Checked)
                {
                    t.KasayaAktar = true;
                    repo.TUpdate(t);

                    //Kasaya aktarma islemi

                    TblKasaHareket tKasa = new TblKasaHareket();
                    Repository<TblKasaHareket> repoKasa = new Repository<TblKasaHareket>();

                    tKasa.Misafir = lookUpEditMisafir.Text;
                    tKasa.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
                    tKasa.Tutar = decimal.Parse(TxtToplamTutar.Text);

                    repoKasa.TAdd(tKasa);
                }

                // t.RezervasyonAdSoyad = lookUpEditMisafir.SelectedText;
                var rezKisi = (dynamic)lookUpEditMisafir.GetSelectedDataRow();
                if (rezKisi != null)
                {
                    string rezKisiAdSoyad = rezKisi.AdSoyad;
                    t.RezervasyonAdSoyad = rezKisiAdSoyad;
                }

                t.Telefon = TxtTelefon.Text;
                t.Aciklama = TxtAciklama.Text;
                t.ToplamTutar = decimal.Parse(TxtToplamTutar.Text);
                if (lookUpEditDurum.EditValue != null)
                {
                    t.Durum = int.Parse(lookUpEditDurum.EditValue.ToString());
                }
                else
                {
                    throw new Exception("Durum seçimi yapılmadı."); // Durum seçilmemişse özel bir hata fırlat
                }
                repo.TAdd(t);
                XtraMessageBox.Show("Rezervasyon başarılı bir şekilde oluşturuldu.");
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Rezervasyon oluşturulurken bir hata oluştu, girdileri kontrol ediniz",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lookUpEditMisafir_EditValueChanged(object sender, EventArgs e)
        {
            secilenMisafir = int.Parse(lookUpEditMisafir.EditValue.ToString());
            var misafirTelefon = db.TblMisafir.Where(x => x.MisafirID == secilenMisafir).Select(y => y.Telefon).FirstOrDefault();
            TxtTelefon.Text = misafirTelefon.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var rezervasyon = repo.Find(x => x.RezervasyonID == id);

            //Repository<TblOda> repo2 = new Repository<TblOda>();

            if ((int)lookUpEditDurum.EditValue == 15)//Cikis yapildiysa
            {
                if (!rbOdemeAlindi.Checked)
                {
                    var odaDurum = repo2.Find(x => x.OdaID == rezervasyon.Oda);
                    odaDurum.Durum = 3; //oda kirli
                    repo2.TUpdate(odaDurum);
                    rezervasyon.KasayaAktar = true;
                    repo.TUpdate(rezervasyon);

                    //Kasaya aktarma islemi

                    TblKasaHareket tKasa = new TblKasaHareket();
                    Repository<TblKasaHareket> repoKasa = new Repository<TblKasaHareket>();

                    tKasa.Misafir = lookUpEditMisafir.Text;
                    tKasa.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
                    tKasa.Tutar = decimal.Parse(TxtToplamTutar.Text);
                    
                    rbOdemeAlindi.Checked = true; //

                    repoKasa.TAdd(tKasa);
                }
                else if (rbOdemeAlindi.Checked)
                {
                    var odaDurum = repo2.Find(x => x.OdaID == rezervasyon.Oda);
                    odaDurum.Durum = 3; //oda kirli
                    repo2.TUpdate(odaDurum);
                }
                
            }
            //else
            //{
            //    XtraMessageBox.Show("Çıkış ve ödeme durumunu kontrol ediniz.",
            //        "Eksik veya Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}


            rezervasyon.Misafir = int.Parse(lookUpEditMisafir.EditValue.ToString());
            rezervasyon.GirisTarihi = DateTime.Parse(DateEditGirisTarihi.EditValue.ToString());
            rezervasyon.CikisTarihi = DateTime.Parse(DateEditCikisTarihi.EditValue.ToString());
            rezervasyon.Kisi = numericUpDownKisiSayisi.Value.ToString();
            rezervasyon.Oda = int.Parse(LookUpEditOda.EditValue.ToString());
            rezervasyon.Telefon = TxtTelefon.Text;
            rezervasyon.Durum = int.Parse(lookUpEditDurum.EditValue.ToString());
            rezervasyon.Kisi2 = lookUpEditKisi2.EditValue != null ? int.Parse(lookUpEditKisi2.EditValue.ToString()) : 0;
            rezervasyon.Kisi3 = lookUpEditKisi3.EditValue != null ? int.Parse(lookUpEditKisi3.EditValue.ToString()) : 0;
            rezervasyon.Kisi4 = lookUpEditKisi4.EditValue != null ? int.Parse(lookUpEditKisi4.EditValue.ToString()) : 0;
            rezervasyon.Aciklama = TxtAciklama.Text;
            rezervasyon.ToplamTutar = decimal.Parse(TxtToplamTutar.Text);
            rezervasyon.OdemeAlindiMi = rbOdemeAlindi.Checked;

            repo.TUpdate(rezervasyon);
            XtraMessageBox.Show("Rezervasyon başarılı bir şekilde güncellendi.");

            //odanın durumu degisecek - cikis yapilinca oda kullanilabilir olacak.


        }

        private void LookUpEditOda_EditValueChanged(object sender, EventArgs e)
        {
            //var secilenOdaNo = LookUpEditOda.EditValue.ToString();
            //TxtOdaNo.Text = secilenOdaNo;

            var secilenOda = (dynamic)LookUpEditOda.GetSelectedDataRow();
            if (secilenOda != null)
            {
                string secilenOdaNo = secilenOda.OdaNo;
                TxtOdaNo.Text = secilenOdaNo;
            }
        }

        private bool lastCheckedState = false;
        private void rbOdemeAlindi_Click(object sender, EventArgs e)
        {
            // Checked özelliğini önceki durumunun tersine çevir
            rbOdemeAlindi.Checked = !lastCheckedState;

            // lastCheckedState değişkenini güncelle
            lastCheckedState = rbOdemeAlindi.Checked;
        }
    }
}
