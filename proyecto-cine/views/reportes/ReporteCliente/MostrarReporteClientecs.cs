using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_cine.views.reportes.ReporteCliente
{
    public partial class MostrarReporteClientecs : Form
    {
        public MostrarReporteClientecs()
        {
            InitializeComponent();
        }
        public int cedula { get; set; }
        private void MostrarReporteClientecs_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.reporteCliente' Puede moverla o quitarla según sea necesario.
            this.reporteClienteTableAdapter.Fill(this.DataSet1.reporteCliente,cedula);

            this.reportViewer1.RefreshReport();
        }
    }
}
