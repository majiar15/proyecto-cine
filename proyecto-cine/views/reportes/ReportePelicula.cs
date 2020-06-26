using proyecto_cine.views.reportes.ReportePelicula;
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
    public partial class ReportePelicula : Form
    {
        public ReportePelicula()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            mostrarReportePelicula reporteForm = new mostrarReportePelicula();
            string nombre = nombrePelicula.Text;
            reporteForm.nombrePelicula = nombre;
            reporteForm.Show();
            this.Close();

        }
    }
}
