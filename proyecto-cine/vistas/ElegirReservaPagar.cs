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
    public partial class ElegirReservaPagar : Form
    {
        homeCajero homeCajeroParent;
        public ElegirReservaPagar(homeCajero homeCajero)
        {
            this.homeCajeroParent = homeCajero;
            InitializeComponent();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            homeCajeroParent.OpenFormInPanelCentral(new Reservas(homeCajeroParent));
            this.Close();
        }

        private void PagarReservaButtom1_Click(object sender, EventArgs e)
        {
            ConfirmarPagarReserva pagarReservaForm = new ConfirmarPagarReserva(homeCajeroParent,"PAGAR RESERVA");
            pagarReservaForm.Show();
            homeCajeroParent.OpenFormInPanelCentral();
            this.Close();
        }
    }
}
