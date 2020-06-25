using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto_cine.controller;

namespace proyecto_cine.views.salas
{
    public partial class Salas : Form
    {
        homeCajero formParent;
        


        public Salas( homeCajero formParent)
        {
            this.formParent = formParent;
            
            InitializeComponent();
        }
        private void Salas_Load(object sender, EventArgs e)
        {
            SalaController controlador = new SalaController(formParent);
            dataGridView.DataSource = controlador.mostrarTabla();
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            this.formParent.OpenFormInPanelCentral(new crearSala(this.formParent, "crear"));
            this.Close();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {

            if (dataGridView.SelectedRows.Count > 0)
            {
                string id = dataGridView.CurrentRow.Cells["id"].Value.ToString();
                crearSala form = new crearSala(this.formParent, "modificar");

                form.nombreTextBox.Text = dataGridView.CurrentRow.Cells["nombre"].Value.ToString();
                form.NombreSedeTextBox.Text = dataGridView.CurrentRow.Cells["sede_id"].Value.ToString();
                

                SalaController sala = new SalaController(formParent);
                form.id = int.Parse(id);

                this.formParent.OpenFormInPanelCentral(form);
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }



        }

        private void eliminar_Click(object sender, EventArgs e)
        {

            int id;

            if (dataGridView.SelectedRows.Count > 0)
            {

                try
                {
                    id = int.Parse(dataGridView.CurrentRow.Cells["id"].Value.ToString());
                    SalaController controller = new SalaController(formParent);
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

        private void searchMenu_OnTextChange(object sender, EventArgs e)
        {
            SalaController controlardor = new SalaController(formParent);
            if (searchMenu.text != "")
            {
                try
                {
                    dataGridView.DataSource = controlardor.buscarSala(searchMenu.text);
                }
                catch
                {
                    
                    searchMenu.text = "";
                    MessageBox.Show("INGRESE SOLO EL ID DE LA PELICULA");
                }

            }
            else
            {
                dataGridView.DataSource = controlardor.mostrarTabla();
            }
        }
    }
}
