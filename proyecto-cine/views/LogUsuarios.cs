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
    public partial class LogUsuarios : Form
    {
        homeCajero formParent;
        public LogUsuarios(homeCajero parent)
        {
            this.formParent = parent;
            InitializeComponent();
        }
    }
}
