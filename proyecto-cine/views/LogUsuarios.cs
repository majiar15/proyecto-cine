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
    public partial class LogUsuarios : Form
    {
        homeCajero formParent;
        public LogUsuarios(homeCajero parent)
        {
            this.formParent = parent;
            InitializeComponent();
        }

        private void LogUsuarios_Load(object sender, EventArgs e)
        {
            conexiondb conexion = new conexiondb();
            SqlCommand cmd;
            DataSet ds;

            try
            {
                conexion.abrir();
                cmd = new SqlCommand("select * from logueos order by id desc", conexion.conexion);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ds = new DataSet();
                ad.Fill(ds, "tabla");
                conexion.cerra();
                dataGridView1.DataSource = ds.Tables["tabla"];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
           
        }

        private void bunifuTextboxBuscarIdCaje_OnTextChange(object sender, EventArgs e)
        {
            DataSet ds;

            try
            {
                conexiondb conexion = new conexiondb();
                conexion.abrir();
                SqlCommand cmd = new SqlCommand(string.Format("select * from logueos where empleado_id like '%{0}%' order by id desc", buscadorLogueos.text), conexion.conexion);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ds = new DataSet();
                ad.Fill(ds, "tabla");
                conexion.cerra();
                dataGridView1.DataSource = ds.Tables["tabla"];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
        }
    }
}
