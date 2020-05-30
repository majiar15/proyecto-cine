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
            homeCajero home = new homeCajero();
            this.Hide();
            home.Show();
        }
    }
}
