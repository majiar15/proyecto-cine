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
    public partial class ccLog : Form
    {
        private homeCajero formParent;
        private string opcion;
        public int idFuncion;
        public string pelicula;
        public string sala;
        public int precio;
        public long cedulaCliente;
        public DateTime fechaFuncion;
        
        public ccLog( homeCajero formParent, string opcion)
        {
            this.formParent = formParent;
            this.opcion = opcion;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            if (opcion == "reserva")
            {
                SeleccionarSillas seleccionar = new SeleccionarSillas(formParent);
                seleccionar.cedulaCliente = long.Parse(cc.Text);
                seleccionar.idFuncion = idFuncion;
                seleccionar.pelicula = pelicula;
                seleccionar.sala = sala;
                seleccionar.precio = precio;
                seleccionar.fechaFuncion = fechaFuncion;
                seleccionar.opcion = "reserva";
                formParent.OpenFormInPanelCentral(seleccionar);
            }
            else {
                SeleccionarSillas seleccionar = new SeleccionarSillas(formParent);
                seleccionar.cedulaCliente = long.Parse(cc.Text);
                seleccionar.idFuncion = idFuncion;
                seleccionar.pelicula = pelicula;
                seleccionar.sala = sala;
                seleccionar.precio = precio;
                seleccionar.fechaFuncion = fechaFuncion;
                seleccionar.opcion = "venta";
                formParent.OpenFormInPanelCentral(seleccionar);
                
            }
            this.Close();
        }
    }
}
