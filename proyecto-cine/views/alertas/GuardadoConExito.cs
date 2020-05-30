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
    public partial class GuardadoConExito : Form
    {
        homeCajero Parent;
        string option;
        public GuardadoConExito(homeCajero parent,String option)
        {
            this.option = option;
            this.Parent = parent;
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (option == "cajero")
            {
                Parent.OpenFormInPanelCentral(new Cajeros(Parent));
            }
            else if (option == "cliente") {
                Parent.OpenFormInPanelCentral(new Clientes(Parent));
            }
                this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
