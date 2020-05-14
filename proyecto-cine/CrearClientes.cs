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
    public partial class CrearClientes : Form
    {
        homeCajero formParent;
        public CrearClientes(homeCajero formParent)
        {
            this.formParent = formParent;
            InitializeComponent();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            this.formParent.OpenFormInPanelCentral(new Clientes(this.formParent));
            this.Close();
        }
    }
}
