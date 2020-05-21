using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto_cine.Models;
using proyecto_cine.controllers;

namespace proyecto_cine
{
    public partial class Confirmarcs : Form
    {
        //CrearClientes crear;
        Cliente cli;
        
        Clientedb nCliente;
        int id;
        homeCajero formParent;
        public Confirmarcs(homeCajero parent,int id)
        {
            this.id = id;
            this.formParent = parent;
            
            cli = new Cliente();
            nCliente = new Clientedb();
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SIbtn_Click(object sender, EventArgs e)
        {
            
            nCliente.Eliminar(id,formParent);
            this.Close();
            
        }

        private void NObtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
