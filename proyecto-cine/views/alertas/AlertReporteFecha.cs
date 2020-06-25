using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto_cine.views.reportes.ReporteFecha;

namespace proyecto_cine.views.alertas
{
    public partial class AlertReporteFecha : Form
    {
        public AlertReporteFecha()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MostrarReporteFecha mostrar = new MostrarReporteFecha();
            mostrar.Fecha = dateTimePicker1.Value;
            mostrar.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
