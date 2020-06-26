using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_cine.views.reportes.ReportePelicula
{
    public partial class mostrarReportePelicula : Form
      
    {
        

        public mostrarReportePelicula()
        {
            InitializeComponent();
        }
        public string nombrePelicula { get; set; }
        private void mostrarReportePelicula_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet2.reportePelicula' Puede moverla o quitarla según sea necesario.
            this.reportePeliculaTableAdapter.Fill(this.DataSet2.reportePelicula,nombrePelicula);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
