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
    public partial class Confirmarcs : Form
    {
        homeCajero formParent;
        public Confirmarcs(homeCajero parent,int id)
        {
            
            this.formParent = parent;
           
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SIbtn_Click(object sender, EventArgs e)
        {
            
           
            this.Close();
            
        }

        private void NObtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
