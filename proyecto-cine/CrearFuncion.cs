using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_cine
{
    public partial class CrearFuncion : Form
    {
        homeCajero formParent;
        int idPelicula;
        public CrearFuncion(homeCajero parent, int idPelicula)
        {
            this.formParent = parent;
            this.idPelicula = idPelicula;
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            conexiondb conexion = new conexiondb();
            SqlCommand cmd;

            DateTime fechaFuncion = fecha.Value;

            try
            {
                conexion.abrir();
                cmd = new SqlCommand("Insert into funcion (sala_id, pelicula_id, fecha, hora, tipo, valor_entrada) values (" + tbSala.Text + " , "+idPelicula+", '" + fechaFuncion.ToString("yyyy-MM-dd") + "', '" + tbHora.Text + "', '" + tbTipo.Text + "', " + tbValor.Text + ")", conexion.conexion);
                cmd.ExecuteNonQuery();
                conexion.cerra();
                GuardadoConExito guardado = new GuardadoConExito(formParent, "pelicula");
                guardado.Show();

            }
            catch (Exception ex)
            {
                ErrorAlGuardar error = new ErrorAlGuardar();
                error.Show();
                MessageBox.Show("No se pudo insertar los datos, error: " + ex.ToString()); ;

            }
        }
    }
            
}
