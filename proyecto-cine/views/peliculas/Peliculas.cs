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

                ModificarPelicula form = new ModificarPelicula(this.formParent, "modificar");
                
                form.NameTextBox.Text = dataGridView23.CurrentRow.Cells["nombre"].Value.ToString();
                form.DuracionTextBox.Text = dataGridView23.CurrentRow.Cells["duracion"].Value.ToString();
                form.CategoriaTextBox.Text = dataGridView23.CurrentRow.Cells["categoria"].Value.ToString();
                form.DescripcionTextBox.Text = dataGridView23.CurrentRow.Cells["descripcion"].Value.ToString();

                form.ImageNameTextBox.Text = dataGridView23.CurrentRow.Cells["imagen_nombre"].Value.ToString();
                PeliculaController pelicula = new PeliculaController(formParent);
                
                //byte[] foto = (byte[])dataGridView23.CurrentRow.Cells["imagen"];
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

        
    }
}
