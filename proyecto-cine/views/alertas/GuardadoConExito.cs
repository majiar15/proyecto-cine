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
    public partial class GuardadoConExito : Form
    {
        homeCajero Parent;
        string option;
        public GuardadoConExito(homeCajero Parent, String option)
        {
            this.option = option;
            this.Parent = Parent;
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (option == "cajero")
            {
                this.Parent.OpenFormInPanelCentral(new Cajeros(this.Parent));
            }
            else if (option == "cliente") {
                this.Parent.OpenFormInPanelCentral(new Clientes(this.Parent));
            } else if (option == "pelicula") {
                this.Parent.OpenFormInPanelCentral(new Peliculas(this.Parent));
            
            }
                this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
