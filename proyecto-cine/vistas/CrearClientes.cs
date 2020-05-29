using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace proyecto_cine
{
    public partial class CrearClientes : Form
    {
  
        homeCajero formParent;
            
        public CrearClientes(homeCajero formParent, string opcion)
        {

            this.formParent = formParent;
            
            InitializeComponent();
            if (opcion == "modificar")
            {
                label6.Text = "MODIFICAR CLIENTES";
            }

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            this.formParent.OpenFormInPanelCentral(new Clientes(this.formParent));
            
            this.Close();
        }

        private void enviar_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
