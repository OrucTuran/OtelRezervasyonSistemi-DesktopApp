using DevExpress.XtraEditors;
using OtelYeniProje.Entity;
using OtelYeniProje.Repositories;
using System;
using System.Windows.Forms;

namespace OtelYeniProje.Formlar.WebSite
{
    public partial class FrmHakkimizda : Form
    {
        public FrmHakkimizda()
        {
            InitializeComponent();
        }

        Repository<TblHakkimda> repo = new Repository<TblHakkimda>();

        private void FrmHakkimizda_Load(object sender, EventArgs e)
        {
            var hakkimda = repo.Find(x => x.ID == 1);

            TxtHakkimda1.Text = hakkimda.Hakkimda1;
            TxtHakkimda2.Text = hakkimda.Hakkimda2;
            TxtHakkimda3.Text = hakkimda.Hakkimda3;
            TxtHakkimda4.Text = hakkimda.Hakkimda4;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var hakkimda = repo.Find(x => x.ID == 1);
            hakkimda.Hakkimda1 = TxtHakkimda1.Text;
            hakkimda.Hakkimda2 = TxtHakkimda2.Text;
            hakkimda.Hakkimda3 = TxtHakkimda3.Text;
            hakkimda.Hakkimda4 = TxtHakkimda4.Text;
            repo.TUpdate(hakkimda);
            XtraMessageBox.Show("Hakkımda kısmı başarılı bir şekilde güncellenmiştir.");
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
