using BunifuAnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace proyecto_cine
{
    public partial class homeCajero : Form
    {
        private Boolean switchs = true;
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
            Application.Exit();
        }

        private void panelLeftMenu_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
