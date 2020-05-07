using BunifuAnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_cine
{
    public partial class homeCajero : Form
    {
        private Boolean switchs = true;
        public homeCajero()
        {
            InitializeComponent();
            /*btPeliculas.BackColor = Color.FromArgb(115, 115, 115);
            btHorarios.BackColor = Color.FromArgb(15, 15, 15);
            btSalas.BackColor = Color.FromArgb(15, 15, 15);
            btReservas.BackColor = Color.FromArgb(15, 15, 15);
            btTicket.BackColor = Color.FromArgb(15, 15, 15);*/
        }

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


    }
}
