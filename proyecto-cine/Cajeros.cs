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
        cajero cajero = new cajero();

        homeCajero formParent;
        public Cajeros(homeCajero formParent)
        {
            this.formParent = formParent;
            InitializeComponent();

        }


        private void Cajeros_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = cajero.MostrarDatos();
        }

        

        private void enviar_Click(object sender, EventArgs e)
        {
            this.formParent.OpenFormInPanelCentral(new CrearCajeros(this.formParent));
            this.Close();
        }

        private void bunifuTextboxBuscarIdCaje_OnTextChange(object sender, EventArgs e)
        {
            if (bunifuTextboxBuscarIdCaje.text != "")
            {
                dataGridView1.DataSource = cajero.Buscar(bunifuTextboxBuscarIdCaje.text);
            }
            else
            {
                dataGridView1.DataSource = cajero.MostrarDatos();
            }
        }

        private void btnEliminarCajero_Click(object sender, EventArgs e)
        {
            Confirmacion confirmar = new Confirmacion(this.formParent);
            confirmar.id = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            confirmar.confirmacion = 1;
            confirmar.Show();
            

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
            int cargo = int.Parse(dataGridView1.CurrentRow.Cells["cargo_id"].Value.ToString());
            if(cargo == 1)
            {
                modificar.cbCargo.selectedIndex = 1;
            }else if(cargo == 2){
                modificar.cbCargo.selectedIndex = 2;
            }
            modificar.btUpdate.Visible = true;
            modificar.enviar.Visible = false;

            this.formParent.OpenFormInPanelCentral(modificar);
            this.Close();
        }
    }
}
