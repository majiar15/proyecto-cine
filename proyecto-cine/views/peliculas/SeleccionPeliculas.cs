using proyecto_cine.views.ventas_y_reservas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_cine
{
    public partial class SeleccionPeliculas : Form
    {
        homeCajero FormParent;
        public long cedulaCliente;
        public string opcion;
        private DataSet ds;
        conexiondb conexion = new conexiondb();
        SqlCommand cmd;
        public SeleccionPeliculas(homeCajero parent)
        {
            this.FormParent = parent;
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            string nombre = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            Funciones funcion = new Funciones(FormParent, id, nombre);
            funcion.cedulaCliente = cedulaCliente;
            funcion.opcion = opcion;
            FormParent.OpenFormInPanelCentral(funcion);
        }

        private void SeleccionPeliculas_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn imagen = new DataGridViewImageColumn();
            imagen = (DataGridViewImageColumn)dataGridView1.Columns[0];
            dataGridView1.RowTemplate.Height = 120;
            imagen.ImageLayout = DataGridViewImageCellLayout.Stretch;

            try
            {
                conexion.abrir();
                cmd = new SqlCommand("select id, nombre, categoria, duracion, imagen from peliculas ", conexion.conexion);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    MemoryStream ms = new MemoryStream((byte[])reader["imagen"]);
                    Bitmap img = new Bitmap(ms);
                    Image im = img;
                    dataGridView1.Rows.Add(im, reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
        }
    }
}
