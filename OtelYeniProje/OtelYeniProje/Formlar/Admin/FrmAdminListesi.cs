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
    public partial class FrmAdminListesi : Form
    {
        public FrmAdminListesi()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities db = new DbOtelYeniEntities();
        private void FrmAdminListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TblAdmin.ToList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmAdminSifreIslemleri fr = new FrmAdminSifreIslemleri();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue(nameof(TblAdmin.ID)).ToString());
            fr.Show();
            fr.TxtYeniSifre.Properties.UseSystemPasswordChar = false;
            fr.TxtMevcutSifre.Properties.UseSystemPasswordChar = false;
            fr.TxtYeniSifreTekrar.Properties.UseSystemPasswordChar = false;
            
        }
    }
}
