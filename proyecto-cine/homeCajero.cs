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
        private void OpenFormInPanelCentral(object FormHijo) {
            if (this.panelCenter.Controls.Count > 0) {
                this.panelCenter.Controls.RemoveAt(0);
            }
            Form formChild = FormHijo as Form;
            formChild.TopLevel = false;
            formChild.Dock = DockStyle.Fill;
            this.panelCenter.Controls.Add(formChild);
            this.panelCenter.Tag = formChild;
            formChild.Show();
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

        private void peliculaButtonMenu_Click(object sender, EventArgs e)
        {
            OpenFormInPanelCentral(new Peliculas());
        }

        private void reservaButtonMenu_Click(object sender, EventArgs e)
        {
            OpenFormInPanelCentral(new Reservas());
        }

        private void PanelTopMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
