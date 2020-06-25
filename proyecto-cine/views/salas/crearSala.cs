using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto_cine.controller;

namespace proyecto_cine.views.salas
{
    public partial class crearSala : Form
    {
        private string nombre, nombre_sede;
        public string opcion;
        public int id;

        homeCajero formParent;

        public crearSala(homeCajero formParent, string opcion)
        {

            this.formParent = formParent;
            this.opcion = opcion;
            InitializeComponent();
        }

        private void crearSala_Load(object sender, EventArgs e)
        {

        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void enviar_Click(object sender, EventArgs e)
        {
            nombre = nombreTextBox.Text;
            nombre_sede = NombreSedeTextBox.Text;

            if (opcion == "crear")
            {
                SalaController controller = new SalaController(formParent);

                controller.crear(nombre, 1);

            }
            else
            {

                SalaController controller = new SalaController(formParent);
                controller.modificar(id, nombre, 1);
            }

        }
    }
}
