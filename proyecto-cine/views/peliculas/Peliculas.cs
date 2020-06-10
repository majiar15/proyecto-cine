using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto_cine.controller;

namespace proyecto_cine
{
    public partial class Peliculas : Form
    {
        homeCajero formParent;
        public Peliculas(homeCajero parent)
        {
            this.formParent = parent;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            
            formParent.OpenFormInPanelCentral(new ModificarPelicula(formParent));
          

        }

        private void Crear_Click(object sender, EventArgs e)
        {
            this.formParent.OpenFormInPanelCentral(new ModificarPelicula(this.formParent, "crear"));
            this.Close();
        }
    }
}
