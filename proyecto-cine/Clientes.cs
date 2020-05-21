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
using proyecto_cine.Models;

namespace proyecto_cine
{
    public partial class Clientes : Form
    {
        Clientedb nCliente;
        homeCajero formParent;
        public int id { get; set; }
        

        public Clientes(homeCajero formParent)
        {
            
            nCliente = new Clientedb();
            this.formParent = formParent;
            InitializeComponent();
            
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nCliente.MostrarClientes().Tables[0];
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            this.formParent.OpenFormInPanelCentral(new CrearClientes(this.formParent));
            this.Close();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            
            this.formParent.OpenFormInPanelCentral(new CrearClientes(this.formParent));
            this.Close();
            
        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            CrearClientes form = new CrearClientes(this.formParent);
            form.CedulaTextBox.Text = dataGridView1.Rows[indice].Cells[0].Value.ToString();
            form.NameTextBox.Text = dataGridView1.Rows[indice].Cells[1].Value.ToString();
            form.ApellidoTextBox.Text= dataGridView1.Rows[indice].Cells[2].Value.ToString();

            form.EmailTextBox.Text=dataGridView1.Rows[indice].Cells[3].Value.ToString();
            form.DireccionTextBox.Text= dataGridView1.Rows[indice].Cells[4].Value.ToString();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void seachMenu_KeyUp(object sender, EventArgs e)
        {
                        
            
        }
        
        private void seachMenu_OnTextChange(object sender, EventArgs e)
        {
            
        }

    }
}
