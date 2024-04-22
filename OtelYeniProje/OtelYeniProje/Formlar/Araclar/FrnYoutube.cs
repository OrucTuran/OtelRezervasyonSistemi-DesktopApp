using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelYeniProje.Formlar.Araclar
{
    public partial class FrnYoutube : Form
    {
        public FrnYoutube()
        {
            InitializeComponent();
        }

        private void FrnYoutube_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/");
        }
    }
}
