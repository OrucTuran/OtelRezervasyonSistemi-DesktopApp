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
    public partial class FrmOdaDolulukGrafigi : Form
    {
        public FrmOdaDolulukGrafigi()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities db = new DbOtelYeniEntities();
        private void FrmOdaDolulukGrafigi_Load(object sender, EventArgs e)
        {
            //Oda doluluk grafigi
            var durumlar = db.OdaDurum();
            foreach (var item in durumlar)
            {
                chartControl1.Series[0].Points.AddPoint(item.DurumAd, double.Parse(item.Sayı.ToString()));
            }
        }
    }
}
