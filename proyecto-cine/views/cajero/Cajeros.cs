﻿using proyecto_cine.controller;
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
        public int id { get; set; }

        public Cajeros(homeCajero formParent)
        {
            this.formParent = formParent;
            
            InitializeComponent();

        }


        private void Cajeros_Load(object sender, EventArgs e)
        {
            CajeroController cajero = new CajeroController(formParent);
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
            CajeroController cajeroBus = new CajeroController(formParent);
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
            if (dataGridView1.SelectedRows.Count > 0)
            {

                try
                {
                    id = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
                    CajeroController controller = new CajeroController(formParent);
                    controller.confirmarEliminacion(id);

                }
                catch
                {
                    new ErrorAlGuardar("eliminar").Show();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }

        }

        private void bunifuThinButton24_Click_1(object sender, EventArgs e)
        {
            CrearCajeros modificar = new CrearCajeros(this.formParent);
            modificar.lbTitle.Text = "MODIFICAR CAJEROS";
            modificar.lbTitle.Location = new Point(182, 9);

            modificar.tbNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            modificar.tbApellidos.Text = dataGridView1.CurrentRow.Cells["Apellidos"].Value.ToString();
            modificar.tbEmail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
            modificar.tbTelefono.Text = dataGridView1.CurrentRow.Cells["telefono"].Value.ToString();
            modificar.tbContraseña.Text = dataGridView1.CurrentRow.Cells["contraseña"].Value.ToString();
            modificar.tbCedula.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            string cargo = dataGridView1.CurrentRow.Cells["cargo"].Value.ToString();
            if (cargo == "Administrador")
            {
                modificar.cbCargo.selectedIndex = 1;
            }
            else if (cargo == "Cajero")
            {
                modificar.cbCargo.selectedIndex = 2;
            }
            modificar.btUpdate.Visible = true;
            modificar.enviar.Visible = false;

            this.formParent.OpenFormInPanelCentral(modificar);
            this.Close();
        }
    }
}
