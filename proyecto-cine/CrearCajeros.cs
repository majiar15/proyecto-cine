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
            

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (tbCedula.Text == "")
            {
                MessageBox.Show("Debe ingresar una cedula valida");
            }
            else if (cbCargo.selectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar un cargo valido");
            }else
            {

            }
        }
    }
}
