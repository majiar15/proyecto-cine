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
        homeCajero formParent;
        string option;
        public GuardadoConExito(homeCajero formParent,String option)
        {
            this.option = option;
            this.formParent = formParent;
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (option == "cajero")
            {
                this.formParent.OpenFormInPanelCentral(new Cajeros(this.formParent));
            }
            else if (option == "cliente") {
                this.formParent.OpenFormInPanelCentral(new Clientes(this.formParent));
            }
                this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
