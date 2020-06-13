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
using proyecto_cine.controller;

namespace proyecto_cine
{
    public partial class Peliculas : Form
    {
        homeCajero formParent;
        DataTable dataTable;

        public Peliculas(homeCajero parent)
        {
            this.formParent = parent;
            InitializeComponent();
        }
        private void Peliculas_Load(object sender, EventArgs e)
        {
            PeliculaController controlador = new PeliculaController(formParent);
            dataGridView23.DataSource = controlador.mostrarTabla();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Modificar_Click(object sender, EventArgs e)
        {

            if (dataGridView23.SelectedRows.Count > 0)
            {
                string id = dataGridView23.CurrentRow.Cells["id"].Value.ToString();
                ModificarPelicula form = new ModificarPelicula(this.formParent, "modificar");
                
                form.NameTextBox.Text = dataGridView23.CurrentRow.Cells["nombre"].Value.ToString();
                form.DuracionTextBox.Text = dataGridView23.CurrentRow.Cells["duracion"].Value.ToString();
                form.CategoriaTextBox.Text = dataGridView23.CurrentRow.Cells["categoria"].Value.ToString();
                form.DescripcionTextBox.Text = dataGridView23.CurrentRow.Cells["descripcion"].Value.ToString();

                
                PeliculaController pelicula = new PeliculaController(formParent);
                form.id = id;

                this.formParent.OpenFormInPanelCentral(form);
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }




            
          

        }

        private void Crear_Click(object sender, EventArgs e)
        {
            this.formParent.OpenFormInPanelCentral(new ModificarPelicula(this.formParent, "crear"));
            this.Close();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            int id;

            if (dataGridView23.SelectedRows.Count > 0)
            {

                try
                {
                    id = int.Parse(dataGridView23.CurrentRow.Cells["id"].Value.ToString());
                    PeliculaController controller = new PeliculaController(formParent);
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
            PeliculaController controlardor = new PeliculaController(formParent);
            if (searchMenu.text != "")
            {
                try
                {
                    dataGridView23.DataSource = controlardor.buscarPelicula(searchMenu.text);
                }
                catch
                {
                    searchMenu.text = "";
                    MessageBox.Show("INGRESE SOLO EL ID DE LA PELICULA");
                }
  
            }
            else
            {
                dataGridView23.DataSource = controlardor.mostrarTabla();
            }
        }
    }
}
