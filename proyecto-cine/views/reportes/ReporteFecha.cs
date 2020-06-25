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
    public partial class ReporteFecha : Form
    {
        homeCajero formParent;
        public ReporteFecha(homeCajero formParent)
        {
            this.formParent = formParent;
            InitializeComponent();
        }

        private void pagarReservaButtom_Click(object sender, EventArgs e)
        {

        }
    }
}
