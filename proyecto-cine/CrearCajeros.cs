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
    public partial class CrearCajeros : Form
    {
        homeCajero formParent;
        public CrearCajeros(homeCajero formParent)
        {
            this.formParent = formParent;
            InitializeComponent();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            this.formParent.OpenFormInPanelCentral(new Cajeros(this.formParent));
            this.Close();
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            int cargo = 0;
            cajero cajero = new cajero();
            if(cbCargo.selectedIndex == 1)
            {
                cargo = 1;
            }
            else if(cbCargo.selectedIndex == 2)
            {
                cargo = 2;
            }

            cajero.crearCajero(Convert.ToInt32(tbCedula.Text), cargo, tbNombre.Text, tbApellidos.Text, tbTelefono.Text, tbEmail.Text, tbContraseña.Text);
            tbNombre.Text = "";
            tbApellidos.Text = "";
            tbEmail.Text = "";
            tbTelefono.Text = "";
            tbContraseña.Text = "";
            tbCedula.Text = "";
            cbCargo.selectedIndex = 0;
        }
    }
}
