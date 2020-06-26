using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto_cine.views.reportes.ReporteCliente;

namespace proyecto_cine
{
    public partial class ReporteCliente : Form
    {
        public ReporteCliente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MostrarReporteClientecs mostrar = new MostrarReporteClientecs();
            int resultado = int.Parse(cedulaTexbox.Text);
            mostrar.cedula = resultado;
            mostrar.ShowDialog();
            mostrar.Close();
        }
    }
}
