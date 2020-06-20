using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; ////// Hacemos mover el formulario
using System.Data.SqlClient;


namespace proyecto_cine
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        /// hacemos mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        ///


        private void loginClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxLoginMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void userLoginTextBox_Enter(object sender, EventArgs e)
        {
            if (userLoginTextBox.Text == "USUARIO")
            {
                userLoginTextBox.Text = "";
            }
        }

        private void userLoginTextBox_Leave(object sender, EventArgs e)
        {
            if (userLoginTextBox.Text == "")
            {
                userLoginTextBox.Text = "USUARIO";
            }
        }

        private void passwordLoginTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordLoginTextBox.Text == "CONTRASEÑA")
            {
                passwordLoginTextBox.Text = "";
            }
        }

        private void passwordLoginTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordLoginTextBox.Text == "")
            {
                passwordLoginTextBox.Text = "CONTRASEÑA";
            }
        }


        // Ver contraseña
        private void VerContraseñaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (VerContraseñaCheckBox.Checked)
            {
                passwordLoginTextBox.PasswordChar = '\0';
                passwordLoginTextBox.Focus();
            }
            else
            {
                passwordLoginTextBox.PasswordChar = '*';
                passwordLoginTextBox.Focus();
            }
        }

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void loginClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void LoginMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //if(userLoginTextBox.Text != "USUARIO")
            //{
            VerificarLog();
            //}

        }

        private void VerificarLog()
        {
            //try
            //{
            //conexiondb conexion = new conexiondb();
            //conexion.abrir();
            //SqlCommand cmd = new SqlCommand("select id, contraseña from empleados where id = '" + userLoginTextBox.Text + "' and contraseña = '" + passwordLoginTextBox.Text + "'", conexion.conexion);
            //SqlDataReader dr = cmd.ExecuteReader();
            //    if (dr.Read())
                //{
                    homeCajero home = new homeCajero();
                    this.Hide();
                    home.Show();
                    //RegistroLog();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Usuario incorrecto");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}

        }

        public void RegistroLog()
        {
            conexiondb conexion = new conexiondb();
            SqlCommand cmd;
            DateTime fecha = DateTime.Today;
            string horaInicio = DateTime.Now.ToString("HH:mm:ss");
            try
            {
                conexion.abrir();
                cmd = new SqlCommand("Insert into logueos (empleado_id,fecha,hora_incio) values (" + long.Parse(userLoginTextBox.Text) + ",'" + fecha.ToShortDateString() + "', '" + horaInicio + "')", conexion.conexion);
                cmd.ExecuteNonQuery();
                conexion.cerra();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar los datos, error: " + ex.ToString()); ;
            }
        }
    }
}
