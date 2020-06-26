using proyecto_cine.views.alertas;
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

namespace proyecto_cine.views.ventas_y_reservas
{
    public partial class Funciones : Form
    {
        homeCajero FormParent;
        int IdPelicula;
        string pelicula;
        public long cedulaCliente;
        public string opcion;
        public Funciones(homeCajero parent, int idPelicula, string pelicula)
        {
            this.FormParent = parent;
            InitializeComponent();
            this.IdPelicula = idPelicula;
            this.pelicula = pelicula;
        }
        private DataSet ds;
        conexiondb conexion = new conexiondb();
        SqlCommand cmd;

        private void Funciones_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CargarFunciones();
        }

        public DataTable CargarFunciones()
        {
            try
            {
                conexion.abrir();
                cmd = new SqlCommand("select id, sala_id, fecha, hora, tipo, valor_entrada from funcion where fecha > (select dateadd(day,-1,SYSDATETIME())) and pelicula_id = "+ IdPelicula +" order by fecha asc", conexion.conexion);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ds = new DataSet();
                ad.Fill(ds, "tabla");
                conexion.cerra();
                return ds.Tables["tabla"];
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
                return ds.Tables["tabla"];
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

            if (opcion == "reserva")
            {


                SeleccionarSillas seleccionar = new SeleccionarSillas(FormParent);

                seleccionar.idFuncion = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
                seleccionar.pelicula = pelicula;
                seleccionar.sala = dataGridView1.CurrentRow.Cells["sala_id"].Value.ToString();
                seleccionar.precio = int.Parse(dataGridView1.CurrentRow.Cells["valor_entrada"].Value.ToString());
                seleccionar.fechaFuncion = DateTime.Parse(dataGridView1.CurrentRow.Cells["fecha"].Value.ToString());
                seleccionar.cedulaCliente = cedulaCliente;
                seleccionar.bunifuThinButton22.Visible = false;
                seleccionar.bunifuThinButton23.Visible = true;
                FormParent.OpenFormInPanelCentral(seleccionar);
                this.Close();

            }

            else {
                esVip vip = new esVip(FormParent);
                vip.idFuncion = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
                vip.pelicula = pelicula;
                vip.sala = dataGridView1.CurrentRow.Cells["sala_id"].Value.ToString();
                vip.precio = int.Parse(dataGridView1.CurrentRow.Cells["valor_entrada"].Value.ToString());
                vip.fechaFuncion = DateTime.Parse(dataGridView1.CurrentRow.Cells["fecha"].Value.ToString());
                vip.Show();
            }
            
            //if (opcion == "reserva")
            //{
            //    seleccionar.bunifuThinButton22.Visible = false;
            //}else seleccionar.bunifuThinButton23.Visible = false;


        }
    }
}
