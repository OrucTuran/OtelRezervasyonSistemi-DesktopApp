using DevExpress.XtraEditors;
using OtelYeniProje.Entity;
using OtelYeniProje.Repositories;
using System;
using System.Windows.Forms;


namespace OtelYeniProje.Formlar.WebSite
{
    public partial class FrmAdresKarti : Form
    {
        public FrmAdresKarti()
        {
            InitializeComponent();
        }

        Repository<Tbliletisim> repo = new Repository<Tbliletisim>();

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAdresKarti_Load(object sender, EventArgs e)
        {
            var iletisim = repo.Find(x => x.ID == 1);

            TxtAciklama.Text = iletisim.Aciklama;
            TxtAdres.Text = iletisim.Adres;
            TxtKoordinat.Text = iletisim.Koordinat;
            TxtMail.Text = iletisim.Mail;
            TxtTelefon.Text = iletisim.Telefon;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var iletisim = repo.Find(x => x.ID == 1);

            iletisim.Aciklama = TxtAciklama.Text;
            iletisim.Adres = TxtAdres.Text;
            iletisim.Koordinat = TxtKoordinat.Text;
            iletisim.Mail = TxtMail.Text;
            iletisim.Telefon = TxtTelefon.Text;
            repo.TUpdate(iletisim); //            db.SaveChanges();
            XtraMessageBox.Show("İletişim bilgileri başarılı bir şekilde güncellendi.");
        }
    }
}
