﻿using System;
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
    public partial class Clientes : Form
    {
        Cliente Cli;
        Clientedb nCliente;
        homeCajero formParent;
        public int id { get; set; }
        

        public Clientes(homeCajero formParent)
        {
            Cli = new Cliente();
            nCliente = new Clientedb();
            this.formParent = formParent;
            InitializeComponent();
            
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nCliente.MostrarConsulta();
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            this.formParent.OpenFormInPanelCentral(new CrearClientes(this.formParent));
            this.Close();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {

            this.formParent.OpenFormInPanelCentral(new CrearClientes(this.formParent));

            if (dataGridView1.SelectedRows.Count > 0)
            {

                CrearClientes form = new CrearClientes(this.formParent);
                form.CedulaTextBox.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                form.NameTextBox.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                form.ApellidoTextBox.Text = dataGridView1.CurrentRow.Cells["apellidos"].Value.ToString();

                form.DireccionTextBox.Text = dataGridView1.CurrentRow.Cells["direccion"].Value.ToString();
                form.EmailTextBox.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
            this.Close();

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void seachMenu_KeyUp(object sender, EventArgs e)
        {
                        
            
        }
        
        private void seachMenu_OnTextChange(object sender, EventArgs e)
        {
            
        }

    }
}
