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
            this.formParent.OpenFormInPanelCentral(new CrearCajeros(this.formParent));
            this.Close();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            this.formParent.OpenFormInPanelCentral(new CrearCajeros(this.formParent));
            this.Close();
        }
    }
}
