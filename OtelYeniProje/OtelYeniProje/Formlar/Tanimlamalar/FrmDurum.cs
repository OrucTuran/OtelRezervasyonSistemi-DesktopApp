using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OtelYeniProje.Entity;

namespace OtelYeniProje.Formlar.Tanimlamalar
{
    public partial class FrmDurum : Form
    {
        public FrmDurum()
        {
            InitializeComponent();
        }

        DbOtelYeniEntities db = new DbOtelYeniEntities();

        private void FrmDurum_Load(object sender, EventArgs e)
        {
            db.TblDurum.Load();
            bindingSource1.DataSource = db.TblDurum.Local;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                db.SaveChanges(); //gridView üzerinden eklenen verileri db e kaydettik
                //güncelleme için bir koda gerek yok. form üzerinden güncelleme yapılabilir.
                //

            }
            catch (Exception)
            {
                XtraMessageBox.Show("Lütfen değerleri kontrol ediniz ve yeniden giriş yapınız!", "Uyarı"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void durumuSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();  //gridView üzerinden eklenen verileri sildik ve db e de guncelledık
            db.SaveChanges();
        }

        private void vazgecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
