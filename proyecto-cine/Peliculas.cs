using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_cine
{
    public partial class Peliculas : Form
    {
        homeCajero FormParent;
        public Peliculas(homeCajero parent)
        {
            this.FormParent = parent;
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            NroBoletas nBoletas = new NroBoletas(FormParent);
            nBoletas.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            NroBoletas nBoletas = new NroBoletas(FormParent);
            nBoletas.Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            NroBoletas nBoletas = new NroBoletas(FormParent);
            nBoletas.Show();
        }
    }
}
