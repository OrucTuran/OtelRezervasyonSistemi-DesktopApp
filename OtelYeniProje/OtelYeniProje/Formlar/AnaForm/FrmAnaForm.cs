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

namespace OtelYeniProje.Formlar.AnaForm
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities db = new DbOtelYeniEntities();
        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            gridControlMisafirListesi.DataSource = (from x in db.TblMisafir
                                                    select new
                                                    {
                                                        x.AdSoyad
                                                    }).ToList();

            gridControlMesajListesi.DataSource = (from x in db.TblMesaj
                                                  select new
                                                  {
                                                      x.MesajID,
                                                      x.Gonderen,
                                                      x.Konu
                                                  }).ToList();

            gridControlBugunGelecekMisafirler.DataSource = (from x in db.TblRezervasyon
                                                            select new
                                                            {
                                                                x.TblMisafir.AdSoyad,
                                                                x.Durum
                                                            }).Where(y => y.Durum == 17).ToList(); //Durum==17 bugün gelecek misafirler
            gridView3.Columns["Durum"].Visible = false;

            gridControlUrunStokListesi.DataSource = (from x in db.TblUrun
                                                     select new
                                                     {
                                                         x.UrunAd,
                                                         x.Toplam
                                                     }).ToList();

            //ürün stok grafiği
            var urunler = db.TblUrun.ToList();
            foreach (var item in urunler)
            {
                chartControlGrafik1.Series[0].Points.AddPoint(item.UrunAd,
                    double.Parse(item.Toplam.ToString()));
            }

            //Oda doluluk grafigi
            var durumlar = db.OdaDurum();
            foreach (var item in durumlar)
            {
                chartControlOdaDoluluk.Series[0].Points.AddPoint(item.DurumAd, double.Parse(item.Sayı.ToString()));
            }
        }


        private void gridView4_DoubleClick(object sender, EventArgs e)
        {
            WebSite.FrmMesajKarti fr = new WebSite.FrmMesajKarti();
            fr.id2 = int.Parse(gridView4.GetFocusedRowCellValue("MesajID").ToString());
            fr.Show();
        }
    }
}
