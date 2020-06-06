using proyecto_cine.controller;
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
    public partial class Cajeros : Form
    {
      

        homeCajero formParent;
        public Cajeros(homeCajero formParent)
        {
            this.formParent = formParent;
            
            InitializeComponent();

        }


        private void Cajeros_Load(object sender, EventArgs e)
        {
            CajeroController cajero = new CajeroController();
            dataGridView1.DataSource = cajero.consultarCajero();
        }

        

        private void enviar_Click(object sender, EventArgs e)
        {
            this.formParent.OpenFormInPanelCentral(new CrearCajeros(this.formParent));
            this.Close();
        }

        /// BUSCAR CAJERO
        private void bunifuTextboxBuscarIdCaje_OnTextChange(object sender, EventArgs e)
        {
            CajeroController cajeroBus = new CajeroController();
            if (bunifuTextboxBuscarIdCaje.text != "")
            {
                dataGridView1.DataSource = cajeroBus.BuscarCajero(bunifuTextboxBuscarIdCaje.text);
            }
            else
            {
                dataGridView1.DataSource = cajeroBus.consultarCajero();
            }
        }

        // ELIMINAR CAJERO
        private void btnEliminarCajero_Click(object sender, EventArgs e)
        {
            CajeroController eliminar = new CajeroController();
            //Confirmacion confirmar = new Confirmacion(this.formParent);

            eliminar.EliminarCajero((dataGridView1.CurrentRow.Cells["id"].Value.ToString()));

        }

        private void bunifuThinButton24_Click_1(object sender, EventArgs e)
        {

        }
    }
}
