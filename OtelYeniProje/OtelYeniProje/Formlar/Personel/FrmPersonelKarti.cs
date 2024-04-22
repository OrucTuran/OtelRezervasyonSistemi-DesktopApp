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

namespace OtelYeniProje.Formlar.Personel
{
    public partial class FrmPersonelKarti : Form
    {
        public FrmPersonelKarti()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities db = new DbOtelYeniEntities();
        Repository<TblPersonel> repo = new Repository<TblPersonel>();

        public int id;
        private void FrmPersonelKarti_Load(object sender, EventArgs e)
        {
            //this.Text = id.ToString();

            if (id != 0)
            {
                var personel = repo.Find(x => x.PersonelID == id);
                TxtAdSoyad.Text = personel.AdSoyad;
                TxtTc.Text = personel.TC;
                TxtSifre.Text = personel.Sifre;
                TxtAdres.Text = personel.Adres;
                TxtTelefon.Text = personel.Telefon;
                TxtMail.Text = personel.Mail;
                DateEditGiris.Text = personel.IseGirisTarihi.ToString();
                DateEditCikis.Text = personel.IstanCikisTarihi.ToString();
                TxtAciklama.Text = personel.Aciklama;
                labelControl15.Text = personel.KimlikOn;
                PictureKimlikOnYuz.Image = Image.FromFile(!string.IsNullOrEmpty(personel.KimlikOn) ? personel.KimlikOn : personel.KimlikVarsayilan);
                labelControl16.Text = personel.KimlikArka;
                PictureKimlikArkaYuz.Image = Image.FromFile(!string.IsNullOrEmpty(personel.KimlikArka) ? personel.KimlikArka : personel.KimlikVarsayilan);
                lookUpEditDepartman.EditValue = personel.Departman;
                lookUpEditGorev.EditValue = personel.Gorev;
            }

            lookUpEditDepartman.Properties.DataSource = (from x in db.TblDepartman
                                                         select new
                                                         {
                                                             x.DepartmanID,
                                                             x.DepartmanAd
                                                         }).ToList();

            lookUpEditGorev.Properties.DataSource = (from x in db.TblGorev
                                                     select new
                                                     {
                                                         x.GorevID,
                                                         x.GorevAd
                                                     }).ToList();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TblPersonel t = new TblPersonel();
            t.AdSoyad = TxtAdSoyad.Text;
            t.TC = TxtTc.Text;
            t.Adres = TxtAdres.Text;
            t.Mail = TxtMail.Text;
            t.Telefon = TxtTelefon.Text;
            t.IseGirisTarihi = DateTime.Parse(DateEditGiris.Text);
            t.Departman = int.Parse(lookUpEditDepartman.EditValue.ToString());
            t.Gorev = int.Parse(lookUpEditGorev.EditValue.ToString());
            t.Aciklama = TxtAciklama.Text;
            t.KimlikOn = PictureKimlikOnYuz.GetLoadedImageLocation();
            t.KimlikArka = PictureKimlikArkaYuz.GetLoadedImageLocation();
            t.Sifre = TxtSifre.Text;
            t.Durum = 1;
            repo.TAdd(t);
            XtraMessageBox.Show("Personel başarılı bir şekilde sisteme kayıt edildi.");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var deger = repo.Find(x => x.PersonelID == id);
            deger.AdSoyad = TxtAdSoyad.Text;
            deger.TC = TxtTc.Text;
            deger.Adres = TxtAdres.Text;
            deger.Mail = TxtMail.Text;
            deger.Telefon = TxtTelefon.Text;
            deger.Sifre = TxtSifre.Text;
            deger.IseGirisTarihi = DateTime.Parse(DateEditGiris.Text);
            deger.Departman = int.Parse(lookUpEditDepartman.EditValue.ToString());
            deger.Gorev = int.Parse(lookUpEditGorev.EditValue.ToString());
            deger.Aciklama = TxtAciklama.Text;
            deger.KimlikOn = labelControl15.Text;
            deger.KimlikArka = labelControl16.Text;
            repo.TUpdate(deger);
            XtraMessageBox.Show("Personel kartı bilgileri başarıyla güncellendi.", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void PictureKimlikOnYuz_EditValueChanged(object sender, EventArgs e)
        {
            labelControl15.Text = PictureKimlikOnYuz.GetLoadedImageLocation().ToString();
        }

        private void PictureKimlikArkaYuz_EditValueChanged(object sender, EventArgs e)
        {
            labelControl16.Text = PictureKimlikArkaYuz.GetLoadedImageLocation().ToString();
        }
    }
}
