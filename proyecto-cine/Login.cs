using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_cine
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



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
                alphaBlendTextBoxContraseña.UseSystemPasswordChar = true;
            }
            else
            {
                alphaBlendTextBoxContraseña.UseSystemPasswordChar = false;
            }
        }
    }
}
