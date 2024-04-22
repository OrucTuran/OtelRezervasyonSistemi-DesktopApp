﻿using DevExpress.XtraEditors;
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
    public partial class FrmUlke : Form
    {
        public FrmUlke()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities db = new DbOtelYeniEntities();
        private void FrmUlke_Load(object sender, EventArgs e)
        {
            db.TblUlke.Load();
            bindingSource1.DataSource = db.TblUlke.Local;

            //repositoryItemLookUpEditDurum.DataSource = (from x in db.TblDurum
            //                                            select new
            //                                            {
            //                                                x.DurumID,
            //                                                x.DurumAd
            //                                            }).ToList(); // ÜLKE İÇİN DURUM GELECEK ŞUANLIK YOK 
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

        private void SilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }
    }
}
