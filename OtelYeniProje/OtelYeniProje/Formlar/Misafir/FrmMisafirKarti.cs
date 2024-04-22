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

namespace OtelYeniProje.Formlar.Misafir
{
    public partial class FrmMisafirKarti : Form
    {
        public FrmMisafirKarti()
        {
            InitializeComponent();
        }

        DbOtelYeniEntities db = new DbOtelYeniEntities();
        Repository<TblMisafir> repo = new Repository<TblMisafir>();
        TblMisafir t = new TblMisafir();

        public int id;
        string resimA;
        string resimB;
        private void FrmMisafirKarti_Load(object sender, EventArgs e)
        {
            //Güncellenecek kart bilgileri
            try
            {
                if (id != 0)
                {
                    var misafir = repo.Find(x => x.MisafirID == id);
                    TxtAdSoyad.Text = misafir.AdSoyad;
                    TxtTc.Text = misafir.TC;
                    TxtAdres.Text = misafir.Adres;
                    TxtTelefon.Text = misafir.Telefon;
                    TxtMail.Text = misafir.Mail;
                    TxtAciklama.Text = misafir.Aciklama;
                   //PictureKimlikOnYuz.Image = Image.FromFile(misafir.KimlikFoto1);
                   //PictureKimlikArkaYuz.Image = Image.FromFile(misafir.KimlikFoto2);
                    LookUpEditSehir.EditValue = misafir.Sehir;
                    LookUpEditUlke.EditValue = misafir.Ulke;
                    LookUpEditilce.EditValue = misafir.Ilce;
                    PictureKimlikOnYuz.Image = misafir.KimlikFoto1 != null ? Image.FromFile(misafir.KimlikFoto1) : Image.FromFile(misafir.VarsayilanFoto);
                    PictureKimlikArkaYuz.Image = misafir.KimlikFoto2 != null ? Image.FromFile(misafir.KimlikFoto2) : Image.FromFile(misafir.VarsayilanFoto);
                    resimA = misafir.KimlikFoto1;
                    resimB = misafir.KimlikFoto2;
                }

                //ülke listesi
                LookUpEditUlke.Properties.DataSource = (from x in db.TblUlke
                                                        select new
                                                        {
                                                            x.UlkeID,
                                                            x.UlkeAd
                                                        }).ToList();
                //Şehir listesi
                LookUpEditSehir.Properties.DataSource = (from x in db.iller
                                                         select new
                                                         {
                                                             x.id,
                                                             x.sehir
                                                         }).ToList();
                //Şehir listesi
                LookUpEditilce.Properties.DataSource = (from x in db.ilceler
                                                        select new
                                                        {
                                                            x.id,
                                                            x.ilce
                                                        }).ToList();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Bir hata oluştu. Lütfen sütunları kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void LookUpEditSehir_EditValueChanged(object sender, EventArgs e)
        {
            int secilen;

            secilen = int.Parse(LookUpEditSehir.EditValue.ToString());

            LookUpEditilce.Properties.DataSource = (from x in db.ilceler
                                                    select new
                                                    {
                                                        x.id,
                                                        x.ilce,
                                                        x.sehir
                                                    }).Where(y => y.sehir == secilen).ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            t.AdSoyad = TxtAdSoyad.Text;
            t.TC = TxtTc.Text;
            t.Telefon = TxtTelefon.Text;
            t.Mail = TxtMail.Text;
            t.Adres = TxtAdres.Text;
            t.Aciklama = TxtAciklama.Text;
            t.Durum = 1;
            t.Sehir = int.Parse(LookUpEditSehir.EditValue.ToString());
            t.Ilce = int.Parse(LookUpEditilce.EditValue.ToString());
            t.Ulke = int.Parse(LookUpEditUlke.EditValue.ToString());
            t.KimlikFoto1 = resimA;
            t.KimlikFoto2 = resimB;
            repo.TAdd(t);
            XtraMessageBox.Show("Misafir başarılır bir şekilde sisteme kayıt edildi.", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PictureKimlikOnYuz_EditValueChanged(object sender, EventArgs e)
        {
            resimA = PictureKimlikOnYuz.GetLoadedImageLocation().ToString();
        }

        private void PictureKimlikArkaYuz_EditValueChanged(object sender, EventArgs e)
        {
            resimB = PictureKimlikArkaYuz.GetLoadedImageLocation().ToString();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var deger = repo.Find(x => x.MisafirID == id);
            deger.AdSoyad = TxtAdSoyad.Text;
            deger.TC = TxtTc.Text;
            deger.Mail = TxtMail.Text;
            deger.Telefon = TxtTelefon.Text;
            deger.Adres = TxtAdres.Text;
            deger.Aciklama = TxtAciklama.Text;
            deger.KimlikFoto1 = resimA;
            deger.KimlikFoto2 = resimB;
            deger.Ulke = int.Parse(LookUpEditUlke.EditValue.ToString());
            deger.Sehir = int.Parse(LookUpEditSehir.EditValue.ToString());
            deger.Ilce = int.Parse(LookUpEditilce.EditValue.ToString());
            deger.Durum = 1;
            repo.TUpdate(deger);
            XtraMessageBox.Show("Misafir kartı bilgileri başarıyla güncellendi.", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
