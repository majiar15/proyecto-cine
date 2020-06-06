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
    public partial class ModificacionExitosa : Form
    {
        homeCajero parent;
        string opcion;
        public ModificacionExitosa(homeCajero parent, string opcion)
        {
            this.parent = parent;
            this.opcion = opcion;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (opcion == "Clientes")
            {
                parent.OpenFormInPanelCentral(new Clientes(parent));
                this.Close();
            }else if (opcion == "Cajeros")
            {
                parent.OpenFormInPanelCentral(new Cajeros(parent));
                this.Close();
            }
        }
    }
}
