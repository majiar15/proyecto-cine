using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_cine.views.alertas
{
    public partial class esVip : Form
    {
        homeCajero formParent;
        public int idFuncion;
        public string pelicula;
        public string sala;
        public int precio;
        public long cedulaCliente;
        public DateTime fechaFuncion;
        public string opcion;
        public esVip( homeCajero formParent)
        {
            this.formParent = formParent;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void si_Click(object sender, EventArgs e)
        {
            ccLog cc = new ccLog(formParent,"vender");
            cc.idFuncion = idFuncion;
            cc.pelicula = pelicula;
            cc.sala = sala;
            cc.precio = precio;
            cc.fechaFuncion = fechaFuncion;
            cc.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void no_Click(object sender, EventArgs e)
        {
            SeleccionarSillas seleccionar = new SeleccionarSillas(formParent);
            
            seleccionar.idFuncion = idFuncion;
            seleccionar.pelicula = pelicula;
            seleccionar.sala = sala;
            seleccionar.precio = precio;
            seleccionar.fechaFuncion = fechaFuncion;
            if (opcion == "reserva")
            {
                seleccionar.bunifuThinButton22.Visible = false;
            }
            else seleccionar.bunifuThinButton23.Visible = false;

            


            formParent.OpenFormInPanelCentral(seleccionar);
            this.Close();



        }
    }
}
