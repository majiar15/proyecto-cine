using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto_cine.controller;

namespace proyecto_cine
{
    public partial class Confirmacion : Form
    {
        homeCajero formParent;
        public Confirmacion(homeCajero formParent, int id =0)
        {
            this.formParent = formParent;
            this.id = id;
            InitializeComponent();

        }

        public int id;
        public int confirmacion;
        public int cedula;
        public int cargo;
        public String nombre;
        public String apellidos;
        public int telefono;
        public String email;
        public String contraseña;

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {

            }
            else
            {
                ClienteController controller = new ClienteController(formParent);
                controller.eliminar(id);
                formParent.OpenFormInPanelCentral(new Clientes(formParent));
                this.Close();
            }
            

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
