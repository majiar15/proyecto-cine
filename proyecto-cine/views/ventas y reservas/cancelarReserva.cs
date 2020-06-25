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
    public partial class cancelarReserva : Form
    {
        //variable del formulario home cajero
        homeCajero homeCajeroParent;
        private DataSet ds;
        conexiondb conexion = new conexiondb();
        SqlCommand cmd;
        public long cedulaCliente;
        public cancelarReserva(homeCajero formParent)
        {
            this.homeCajeroParent = formParent;
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                long  id = int.Parse(dataGridView1.CurrentRow.Cells["cliente_id"].Value.ToString());
                int funcionId = int.Parse(dataGridView1.CurrentRow.Cells["funcion_id"].Value.ToString());
                try
                {
                    conexiondb conexion = new conexiondb();
                    conexion.abrir();
                    SqlCommand cmd = new SqlCommand(string.Format("delete from asientos where cliente_id = {0} and funcion_id = {1}" , id, funcionId), conexion.conexion);
                    int filasafectadas = cmd.ExecuteNonQuery();
                    conexion.cerra();

                    EliminadoCorrectamente eliminado = new EliminadoCorrectamente(homeCajeroParent);
                    eliminado.Show();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.ToString());
                }
                }
                else
                {
                    MessageBox.Show("Seleccione una fila por favor");
                }

        }

        private void cancelarReserva_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CargarReservas();
        }

        public DataTable CargarReservas()
        {
            try
            {
                conexion.abrir();
                cmd = new SqlCommand("select * from asientos where cliente_id = "+cedulaCliente+"", conexion.conexion);
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
    }
}
