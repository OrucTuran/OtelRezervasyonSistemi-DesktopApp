using DevExpress.XtraEditors;
using OtelYeniProje.Entity;
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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        Form1 fr = new Form1();
        DbOtelYeniEntities db = new DbOtelYeniEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            var kullanici = db.TblAdmin.Where(x => x.KullaniciAdi == TxtKullaniciAdi.Text
            && x.Sifre == TxtSifre.Text).FirstOrDefault();
            if (kullanici != null)
            {
                fr.kullaniciRolu = kullanici.Rol;
                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Kullanıcı adı veya şifreniz yanlış, tekrar deneyin.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
