using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace proyecto_cine
{
    public partial class CedulaClienteReserva : Form
    {
        homeCajero formParent;
        string opcion;
        private DataSet ds;
        conexiondb conexion = new conexiondb();
        SqlCommand cmd;
        public CedulaClienteReserva(homeCajero formParent, string opcion)
        {
            this.formParent = formParent;
            this.opcion = opcion;
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTopCedulaCliente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (opcion == "crear")
            {
                conexiondb conexion = new conexiondb();
                conexion.abrir();
                try
                {

                    SqlCommand cmd = new SqlCommand("select * from cliente where id = " + tbCedula.Text + "", conexion.conexion);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        SeleccionPeliculas peliculas = new SeleccionPeliculas(formParent);
                        peliculas.cedulaCliente = long.Parse(tbCedula.Text);
                        peliculas.opcion = "reserva";
                        formParent.OpenFormInPanelCentral(peliculas);
                        this.Hide();

                    }
                    else MessageBox.Show("Usuario no encontrado");
                    conexion.cerra();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conexion.cerra();
                }
            }else if(opcion == "cancelar")
            {
                try
                {
                    conexion.abrir();
                    cmd = new SqlCommand("select * from asientos where cliente_id = " + tbCedula.Text + "", conexion.conexion);
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    ad.Fill(ds, "tabla");
                    conexion.cerra();
                    cancelarReserva cancelar = new cancelarReserva(formParent);
                    cancelar.dataGridView1.DataSource = ds.Tables["tabla"];
                    cancelar.cedulaCliente = long.Parse(tbCedula.Text);
                    formParent.OpenFormInPanelCentral(cancelar);
                    this.Hide();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                    //ds.Tables["tabla"];
                }


            }else if(opcion == "pagar")
            {
                try
                {
                    conexion.abrir();
                    cmd = new SqlCommand("select id, cliente_id, estado, funcion_id from reserva where cliente_id = " + tbCedula.Text + " and estado = 'SinPagar'", conexion.conexion);
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    ad.Fill(ds, "tabla");
                    conexion.cerra();
                    ElegirReservaPagar pagar = new ElegirReservaPagar(formParent);
                    pagar.dataGridView1.DataSource = ds.Tables["tabla"];
                    pagar.cedula_id = int.Parse(tbCedula.Text);
                    formParent.OpenFormInPanelCentral(pagar);
                    this.Hide();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                }
            }
        
        }
    }
}
