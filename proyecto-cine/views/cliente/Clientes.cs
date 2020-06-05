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
    public partial class Clientes : Form
    {
        
        homeCajero formParent;
        public int id { get; set; }
        

        public Clientes(homeCajero formParent)
        {
           
            this.formParent = formParent;
            InitializeComponent();
            
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            ClienteController controlardor = new ClienteController(formParent);
            dataGridView1.DataSource = controlardor.mostrarTabla();
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            this.formParent.OpenFormInPanelCentral(new CrearClientes(this.formParent,"crear"));
            this.Close();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {

            

            if (dataGridView1.SelectedRows.Count > 0)
            {

                CrearClientes form = new CrearClientes(this.formParent,"modificar");
                form.CedulaTextBox.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                form.NameTextBox.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                form.ApellidoTextBox.Text = dataGridView1.CurrentRow.Cells["apellidos"].Value.ToString();

                form.ApellidoTextBox.Text = dataGridView1.CurrentRow.Cells["descuento"].Value.ToString();

                form.DireccionTextBox.Text = dataGridView1.CurrentRow.Cells["direccion"].Value.ToString();
                form.EmailTextBox.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
                this.formParent.OpenFormInPanelCentral(form);
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
            

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void seachMenu_KeyUp(object sender, EventArgs e)
        {
                        
            
        }
        
        private void searchMenu_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
                //Confirmarcs confirmar = new Confirmarcs(formParent, id);
                //confirmar.Show();
            }
            catch {
                new ErrorAlGuardar("eliminar").Show();
            }
            
           
        }



    }
}
