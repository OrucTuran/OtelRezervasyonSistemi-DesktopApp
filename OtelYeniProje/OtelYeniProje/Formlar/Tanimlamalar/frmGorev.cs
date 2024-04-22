using DevExpress.XtraEditors;
using OtelYeniProje.Entity;
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

namespace OtelYeniProje.Formlar.Tanimlamalar
{
    public partial class frmGorev : Form
    {
        public frmGorev()
        {
            InitializeComponent();
        }
        readonly DbOtelYeniEntities db = new DbOtelYeniEntities();

        private void frmGorev_Load(object sender, EventArgs e)
        {
            db.TblGorev.Load();
            bindingSource1.DataSource = db.TblGorev.Local;

            repositoryItemLookUpEditDepartman.DataSource = (from x in db.TblDepartman
                                                        select new
                                                        {
                                                            x.DepartmanID,
                                                            x.DepartmanAd
                                                        }).ToList();

            repositoryItemLookUpEditDurum.DataSource = (from x in db.TblDurum
                                                        select new
                                                        {
                                                            x.DurumID,
                                                            x.DurumAd
                                                        }).ToList();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Bilgiler kaydedilirken hata oluştu, tekrar kontrol edin.");
            }
        }
    }
}
