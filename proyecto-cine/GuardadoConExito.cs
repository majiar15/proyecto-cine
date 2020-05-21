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
    public partial class GuardadoConExito : Form
    {
        homeCajero FormParent;
        public GuardadoConExito(homeCajero FormParent)
        {
            this.FormParent = FormParent;
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            FormParent.OpenFormInPanelCentral(new Clientes(FormParent));
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
