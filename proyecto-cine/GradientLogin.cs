using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_cine
{
    class GradientLogin : Panel
    {
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lbg = new LinearGradientBrush(this.ClientRectangle, this.ColorTop,this.ColorBottom, 120F);
            Graphics g = e.Graphics;
            g.FillRectangle(lbg, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
