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
    public partial class cancelarReserva : Form
    {
        //variable del formulario home cajero
        homeCajero formParent;
        public cancelarReserva(homeCajero formParent)
        {
            this.formParent = formParent;
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.formParent.OpenFormInPanelCentral();
            this.Close();

        }
    }
}
