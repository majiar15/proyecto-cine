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
    public partial class Reservas : Form
    {
        homeCajero formParent;
        public Reservas(homeCajero formParent)
        {
            this.formParent = formParent;
            InitializeComponent();
        }

        private void reservarBoletoButton_Click(object sender, EventArgs e)
        {
            CedulaClienteReserva cedulaCliente = new CedulaClienteReserva();
            cedulaCliente.Show();
        }

        private void cancelarReservaButton_Click(object sender, EventArgs e)
        {
            cancelarReserva cancelarReservaForm = new cancelarReserva(this.formParent);
            this.formParent.OpenFormInPanelCentral(cancelarReservaForm);
            this.Close();



        }
    }
}
