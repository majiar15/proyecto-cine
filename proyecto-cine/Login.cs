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



        private void alphaBlendTextBoxUsuario_Enter(object sender, EventArgs e)
        {
            if (alphaBlendTextBoxUsuario.Text == "USUARIO")
            {
                alphaBlendTextBoxUsuario.Text = "";
            }
        }

        private void alphaBlendTextBoxUsuario_Leave(object sender, EventArgs e)
        {
            if (alphaBlendTextBoxUsuario.Text == "")
            {
                alphaBlendTextBoxUsuario.Text = "USUARIO";
            }
        }

        private void alphaBlendTextBoxContraseña_Enter(object sender, EventArgs e)
        {
            if (alphaBlendTextBoxContraseña.Text == "CONTRASEÑA")
            {
                alphaBlendTextBoxContraseña.Text = "";
            }
        }

        private void alphaBlendTextBoxContraseña_Leave(object sender, EventArgs e)
        {
            if (alphaBlendTextBoxContraseña.Text == "")
            {
                alphaBlendTextBoxContraseña.Text = "CONTRASEÑA";
            }
        }


        //////// Ver contraseña
        private void checkBoxVerContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVerContraseña.Checked)
            {
                alphaBlendTextBoxContraseña.PasswordChar = '\0';
                alphaBlendTextBoxContraseña.Focus();
            }
            else
            {
                alphaBlendTextBoxContraseña.PasswordChar = '*';
                alphaBlendTextBoxContraseña.Focus();
            }
        }

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
