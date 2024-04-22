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

namespace OtelYeniProje.Formlar.Grafikler
{
    public partial class FrmUrunStokGrafik : Form
    {
        public FrmUrunStokGrafik()
        {
            InitializeComponent();
        }

        DbOtelYeniEntities db = new DbOtelYeniEntities();

        private void FrmGrafikPie_Load(object sender, EventArgs e)
        {
            var urunler = db.TblUrun.ToList();
            foreach (var item in urunler)
            {
                chartControl1.Series[0].Points.AddPoint(item.UrunAd,
                    double.Parse(item.Toplam.ToString()));
            }
        }
    }
}
