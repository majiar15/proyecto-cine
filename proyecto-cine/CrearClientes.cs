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
using proyecto_cine.controllers;


namespace proyecto_cine
{
    public partial class CrearClientes : Form
    {
        string opcion;        
        Clientedb nClientedb;
        homeCajero formParent;
            
        public CrearClientes(homeCajero formParent, string opcion)
        {
            this.opcion = opcion;
            nClientedb = new Clientedb();
            this.formParent = formParent;
            InitializeComponent();
            
            
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            this.formParent.OpenFormInPanelCentral(new Clientes(this.formParent));
            
            this.Close();
        }

        private void enviar_Click(object sender, EventArgs e)
        {

            
            
           
            if(opcion == "modificar")
            {
                nClientedb.Modificardb(Informacion());
            }
            else
            {
                nClientedb.Agregar(Informacion());
            }
            this.formParent.OpenFormInPanelCentral(new Clientes(this.formParent));
            this.Close();


        }
        private Cliente Informacion()
        {
            Cliente nCliente = new Cliente();
            nCliente.nombre = NameTextBox.Text;
            nCliente.apellidos = ApellidoTextBox.Text;
            int cedulaN = 0; int.TryParse(CedulaTextBox.Text, out cedulaN);
            nCliente.cedula = cedulaN;
            nCliente.email = EmailTextBox.Text;
            nCliente.direccion = DireccionTextBox.Text;

            return nCliente;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
