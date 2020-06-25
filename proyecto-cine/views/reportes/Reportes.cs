using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto_cine.views.alertas;

namespace proyecto_cine
{
    public partial class Reportes : Form
    {
        homeCajero formParent;
        public Reportes(homeCajero formParent)
        {
            this.formParent = formParent;
            InitializeComponent();
        }

        private void reservarBoletoButton_Click(object sender, EventArgs e)
        {
            ReportePelicula reporte = new ReportePelicula();
            reporte.Show();
        }

        private void cancelarReservaButton_Click(object sender, EventArgs e)
        {
            //formParent.OpenFormInPanelCentral(new ReporteFecha(formParent));
            AlertReporteFecha reporte = new AlertReporteFecha();
            reporte.Show();
        }

        private void pagarReservaButtom_Click(object sender, EventArgs e)
        {
            ReporteCliente reporte = new ReporteCliente();
            reporte.Show();
        }
    }
}
