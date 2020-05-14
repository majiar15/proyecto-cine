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
    public partial class Clientes : Form
    {
        homeCajero formParent;
        public Clientes(homeCajero formParent)
        {
            this.formParent = formParent;
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 14; i++)
            {
                dataGridView1.Rows.Add(
                    new object[]
                    {
                        "",
                        "",
                        "",
                        "",
                        "",
                    }

                );
            }
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
    }
}
