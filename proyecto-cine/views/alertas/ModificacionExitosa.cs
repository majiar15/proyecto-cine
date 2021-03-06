﻿using proyecto_cine.views.salas;
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
    public partial class ModificacionExitosa : Form
    {
        homeCajero parent;
        public string opcion;
        public ModificacionExitosa(homeCajero parent, string opcion)
        {
            this.opcion = opcion;
            this.parent = parent;
            this.opcion = opcion;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            switch (opcion)
            {
                case "modificarCliente":
                    parent.OpenFormInPanelCentral(new Clientes(parent));
                    this.Close();
                    break;
                case "modificarPelicula":
                    parent.OpenFormInPanelCentral(new Peliculas(parent));
                    this.Close();
                    break;
                case "modificarCajero":
                    parent.OpenFormInPanelCentral(new Cajeros(parent));
                    this.Close();
                    break;
                case "modificarSala":
                    parent.OpenFormInPanelCentral(new Salas(parent));
                    this.Close();
                    break;
                default:
                    MessageBox.Show("Error");
                    break;

            }
            
        }
    }
}
