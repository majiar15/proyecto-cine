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
    public partial class EliminadoCorrectamente : Form
    {
        homeCajero Parent;
        public EliminadoCorrectamente(homeCajero parent)
        {
            this.Parent = parent;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
