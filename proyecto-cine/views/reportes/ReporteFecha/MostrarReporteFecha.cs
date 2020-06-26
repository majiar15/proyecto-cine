using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto_cine.views;

namespace proyecto_cine.views.reportes.ReporteFecha
{
    public partial class MostrarReporteFecha : Form
    {
        public MostrarReporteFecha()
        {
            InitializeComponent();
        }
        public DateTime Fecha { get; set; }
        private void ReporteFecha_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.reporteFecha' Puede moverla o quitarla según sea necesario.
            this.reporteFechaTableAdapter.Fill(this.DataSet1.reporteFecha,Fecha);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
