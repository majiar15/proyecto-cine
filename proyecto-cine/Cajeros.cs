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

        private void bunifuThinButton24_Click(object sender, EventArgs e)
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
    }
}
