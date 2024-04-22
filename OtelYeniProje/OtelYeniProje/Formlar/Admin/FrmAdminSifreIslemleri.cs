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

namespace OtelYeniProje.Formlar.Admin
{
    public partial class FrmAdminSifreIslemleri : Form
    {
        public FrmAdminSifreIslemleri()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities db = new DbOtelYeniEntities();
        TblAdmin t = new TblAdmin();
        Repository<TblAdmin> repo = new Repository<TblAdmin>();
        public int id;

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtYeniSifre.Text == TxtYeniSifreTekrar.Text)
            {

                t.KullaniciAdi = TxtKullaniciAdi.Text;
                t.Sifre = TxtMevcutSifre.Text;
                db.TblAdmin.Add(t);
                db.SaveChanges();
                XtraMessageBox.Show("Yeni kullanıcı başarılı bir şekilde oluşturuldu.",
                    "✓", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Şifreler uyuşmuyor lütfen tekrar deneyiniz.",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            FrmAdminListesi fr = new FrmAdminListesi();
            fr.Show();
            this.Hide();
        }

        private void FrmAdminSifreIslemleri_Load(object sender, EventArgs e)
        {
            TxtYeniSifre.Properties.UseSystemPasswordChar = true;
            TxtMevcutSifre.Properties.UseSystemPasswordChar = true;
            TxtYeniSifreTekrar.Properties.UseSystemPasswordChar = true;
            if (id != 0)
            {
                var admin = repo.Find(x => x.ID == id);
                TxtKullaniciAdi.Text = admin.KullaniciAdi;
                TxtMevcutSifre.Text = admin.Sifre;
                TxtRol.Text = admin.Rol;
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (TxtYeniSifre.Text == TxtYeniSifreTekrar.Text)
            {

                var deger = repo.Find(x => x.ID == id);
                deger.KullaniciAdi = TxtKullaniciAdi.Text;
                deger.Sifre = TxtMevcutSifre.Text;
                deger.Rol = TxtRol.Text;
                repo.TUpdate(deger);
                XtraMessageBox.Show("Admin şifre bilgileri başarılı bir şekilde güncellendi.",
                    "✓", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Şifreler uyuşmuyor lütfen tekrar deneyiniz.",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
