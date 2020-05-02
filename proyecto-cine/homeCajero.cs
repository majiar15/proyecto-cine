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
    public partial class homeCajero : Form
    {
        public homeCajero()
        {
            InitializeComponent();
            /*btPeliculas.BackColor = Color.FromArgb(115, 115, 115);
            btHorarios.BackColor = Color.FromArgb(15, 15, 15);
            btSalas.BackColor = Color.FromArgb(15, 15, 15);
            btReservas.BackColor = Color.FromArgb(15, 15, 15);
            btTicket.BackColor = Color.FromArgb(15, 15, 15);*/
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if(panelLeft.Width == 155)
            {
                panelLeft.Visible = false;
                panelLeft.Width = 65 ;
                bunifuTransition1.Show(panelLeft);
                bunifuTransition1.Show(panelCenter);
            }
            else
            {
                panelLeft.Visible = false;
                panelLeft.Width = 155;
                bunifuTransition1.Show(panelLeft);
                bunifuTransition1.Show(panelCenter);
            }
        }
    }
}
