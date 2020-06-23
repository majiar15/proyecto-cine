using proyecto_cine.views.ventas_y_reservas;
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
    public partial class SeleccionPeliculas : Form
    {
        homeCajero FormParent;
        public SeleccionPeliculas(homeCajero parent)
        {
            this.FormParent = parent;
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            FormParent.OpenFormInPanelCentral(new Funciones(FormParent, 1, "Avengers"));
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            FormParent.OpenFormInPanelCentral(new Funciones(FormParent, 2, "Bad boys"));
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            FormParent.OpenFormInPanelCentral(new Funciones(FormParent, 3, "Joker"));
        }
    }
}
