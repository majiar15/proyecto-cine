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
    public partial class ErrorAlGuardar : Form
    {
        
        public ErrorAlGuardar(String option ="agregar")
        {
           
            InitializeComponent();
            if (option == "eliminar")
            {
                label1.Text = "Error Al Eliminar";
            }
            else if (option == "modificar") {
                label1.Text = "Error Al Modificar";
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ErrorAlGuardar_Load(object sender, EventArgs e)
        {

        }
    }
}
