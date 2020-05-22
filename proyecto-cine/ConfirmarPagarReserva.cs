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
    public partial class ConfirmarPagarReserva : Form
    {
        String option;
        homeCajero parent;
        public ConfirmarPagarReserva(homeCajero parent,String option)
        {
            this.option = option;
            this.parent = parent;
            InitializeComponent();
            label2.Text = option;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (option == "PAGAR BOLETOS")
            {
                
                parent.OpenFormInPanelCentral();
                this.Close();
            }
            else {
                this.Close();
            }
            
        }
    }
}
