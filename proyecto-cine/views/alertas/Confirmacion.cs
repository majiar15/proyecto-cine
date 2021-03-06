﻿using System;
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
using proyecto_cine.views.salas;

namespace proyecto_cine
{
    public partial class Confirmacion : Form
    {
        homeCajero formParent;
        public int id;
        public string opcion;
        public Confirmacion(homeCajero formParent, int id ,string opcion)
        {
            this.formParent = formParent;
            this.id = id;
            this.opcion = opcion;
            InitializeComponent();

        }


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (opcion == "eliminarCliente")
            {
                ClienteController controller = new ClienteController(formParent);
                controller.eliminar(id);
                formParent.OpenFormInPanelCentral(new Clientes(formParent));
                this.Close();
            }
            else if (opcion == "eliminarPelicula")
            {
                PeliculaController controller = new PeliculaController(formParent);
                controller.eliminar(id);
                formParent.OpenFormInPanelCentral(new Peliculas(formParent));
                this.Close();
            }
            else if (opcion == "eliminarCajero")
            {
                CajeroController controller = new CajeroController(formParent);
                controller.EliminarCajero(id);
                formParent.OpenFormInPanelCentral(new Cajeros(formParent));
                this.Close();
            }
            else if (opcion == "eliminarSala")
            {
                SalaController controller = new SalaController(formParent);
                controller.eliminar(id);
                formParent.OpenFormInPanelCentral(new Salas(formParent));
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
