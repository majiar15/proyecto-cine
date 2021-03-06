﻿using BunifuAnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using proyecto_cine.views.salas;

namespace proyecto_cine
{
    public partial class homeCajero : Form
    {
        private bool switchs = true;
        public long userLog;
        /*
            Documentacion Metodo OpenFormInPanelCentral
            se pasa el formulario  que se desea mostrar en el panel central
            si desea volver a la pagina principal no pasen parametros, el asumira null 
            y entrara en las condicionales correspondientes para colocar la imagen de bienvenidos de fondo
            
        */
        public void OpenFormInPanelCentral(object FormHijo = null) {
            if (this.panelCenter.Controls.Count > 0 && FormHijo != null) {
                this.panelCenter.Controls.RemoveAt(0);
            } else{
                pictureBox1.Dock = DockStyle.Fill;
                this.panelCenter.Controls.Add(pictureBox1);

              
            }
            if (FormHijo != null) {
                Form formChild = FormHijo as Form;
                formChild.TopLevel = false;
                formChild.Dock = DockStyle.Fill;
                this.panelCenter.Controls.Add(formChild);
                this.panelCenter.Tag = formChild;
                formChild.Show();
            }
        }
        public homeCajero()
        {
            InitializeComponent();
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void closeAppMenu_Click(object sender, EventArgs e)
        {
            this.Close();

            conexiondb conexion = new conexiondb();
            SqlCommand cmd;
            string horaSalida = DateTime.Now.ToString("HH:mm:ss");


            try
            {
                conexion.abrir();
                cmd = new SqlCommand("update logueos set hora_salida = '" + horaSalida + "' where id = (select top 1 id from logueos order by id desc)", conexion.conexion);
                cmd.ExecuteNonQuery();
                conexion.cerra();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar los datos, error: " + ex.ToString()); ;
            }

            Application.Exit();
        }

        private void minimizeMenu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void showHideMenu_Click(object sender, EventArgs e)
        {
            if (switchs)
            {
                switchs = false;
                panelLeftMenu.Width = 67;
            }
            else
            {
                switchs = true;
                panelLeftMenu.Width = 151;
            }
        }

        private void PanelTopMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112,0xf012,0);
        }

        private void ventasButtonMenu_Click(object sender, EventArgs e)
        {
            OpenFormInPanelCentral(new SeleccionPeliculas(this));
        }

        private void reservaButtonMenu_Click(object sender, EventArgs e)
        {
            OpenFormInPanelCentral(new Reservas(this));
        }

        private void PanelTopMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logOutMenu_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();

            conexiondb conexion = new conexiondb();
            SqlCommand cmd;
            string horaSalida = DateTime.Now.ToString("HH:mm:ss");
            

            try
            {
                conexion.abrir();
                cmd = new SqlCommand("update logueos set hora_salida = '" + horaSalida + "' where id = (select top 1 id from logueos order by id desc)", conexion.conexion);
                cmd.ExecuteNonQuery();
                conexion.cerra();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar los datos, error: " + ex.ToString()); ;
            }
        }

        private void peliculasButtonMenu_Click(object sender, EventArgs e)
        {
            OpenFormInPanelCentral(new Peliculas(this));
        }

        private void clientesButtonMenu_Click(object sender, EventArgs e)
        {
            OpenFormInPanelCentral(new Clientes(this));
        }

        private void cajerosButtonMenu_Click(object sender, EventArgs e)
        {
            OpenFormInPanelCentral(new Cajeros(this));
        }

        private void logButtonMenu_Click(object sender, EventArgs e)
        {
            OpenFormInPanelCentral(new LogUsuarios(this));
        }

        private void reportesButtonMenu_Click(object sender, EventArgs e)
        {
            OpenFormInPanelCentral(new Reportes(this));
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            OpenFormInPanelCentral(new Salas(this));

        }
    }
}
