using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Box_cu_Gradient_schimbator_in_timp
{
    class Class1 : Panel 
    {
        public Color ColorTop { get; set; }
        public Color ColorBot { get; set; }
        public float I { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush ln = new LinearGradientBrush(this.ClientRectangle,this.ColorTop,this.ColorBot,I);
            Graphics g = e.Graphics;
            g.FillRectangle(ln, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
