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

namespace OtelYeniProje.Formlar.WebSite
{
    public partial class FrmMesajKarti : Form
    {
        public FrmMesajKarti()
        {
            InitializeComponent();
        }

        public int id;
        public int id2;

        DbOtelYeniEntities db = new DbOtelYeniEntities();

        Repository<TblMesaj2> repo = new Repository<TblMesaj2>();
        Repository<TblMesaj> repoIletisim = new Repository<TblMesaj>();

        TblMesaj2 t = new TblMesaj2();
        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMesajKarti_Load(object sender, EventArgs e)
        {
            if (id != 0)  //tblMesaj2
            {
                var mesaj2 = repo.Find(x => x.MesajID == id);

                txtMesaj.Text = mesaj2.Mesaj;
                txtMail.Text = mesaj2.Gonderen;
                txtKonu.Text = mesaj2.Konu;
                txtTarih.Text = string.Format("{0:dd/MM/yyyy}", mesaj2.Tarih);

                var kisi = db.TblYeniKayit.Where(x => x.Mail == mesaj2.Gonderen).Select(y => y.AdSoyad).FirstOrDefault();

                if (kisi != null)
                {
                    TxtAdSoyad.Text = kisi.ToString();
                }
                else
                {
                    TxtAdSoyad.Text = "Admin";
                }
            }

            if (id2 != 0) //tblMesaj
            {
                var mesaj = repoIletisim.Find(x => x.MesajID == id2);
                txtMail.Text = mesaj.Mail;
                txtKonu.Text = mesaj.Konu;
                txtMesaj.Text = mesaj.Mesaj;
                TxtAdSoyad.Text = mesaj.Gonderen;
                //txtTarih.Text = string.Format("{0:dd/MM/yyyy}", mesaj.Tarih);
            }
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            t.Gonderen = "Admin";
            t.Alici = txtMail.Text;
            t.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            t.Konu = txtKonu.Text;
            t.Mesaj = txtMesaj.Text;
            repo.TAdd(t);
            XtraMessageBox.Show("Mesajınız başarılı bir şekilde iletildi.");
        }
    }
}
