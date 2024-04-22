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
    public partial class FrmOnRezervasyonKarti : Form
    {
        public FrmOnRezervasyonKarti()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities db = new DbOtelYeniEntities();
        Repository<TblOnRezervasyon> repo = new Repository<TblOnRezervasyon>();
        public int id;
        private void FrmOnRezervasyonKarti_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                var rezervasyon = repo.Find(x => x.ID == id);
                DateEditGirisTarihi.Text = string.Format("{0:dd/MM/yyyy}", rezervasyon.GirisTarihi);
                DateEditCikisTarihi.Text = string.Format("{0:dd/MM/yyyy}", rezervasyon.CikisTarihi);
                dateEditRezTarihi.Text = string.Format("{0:dd/MM/yyyy}", rezervasyon.Tarih);
                numericUpDownKisiSayisi.Value = decimal.Parse(rezervasyon.Kisi.ToString());
                txtAdSoyad.Text = rezervasyon.AdSoyad;
                TxtTelefon.Text = rezervasyon.Telefon;
                txtAciklama.Text = rezervasyon.Aciklama;
                txtMail.Text = rezervasyon.Mail;
            }
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
