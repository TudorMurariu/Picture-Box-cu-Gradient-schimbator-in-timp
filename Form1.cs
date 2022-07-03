using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Box_cu_Gradient_schimbator_in_timp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ///this.timer1.Start();
            //button1.Parent = class11;
        }
        float PLUS = 90F;
        List<Color> colors = new List<Color>();                           
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void class11_Paint(object sender, PaintEventArgs e)
        {

        }
        int c = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (c > 3)
                c = 0;
            this.BackColor = colors[c];
             c++;
           this.class11.I += 30F;
            this.PLUS += 60F;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush ln = new LinearGradientBrush(this.ClientRectangle, Color.Blue, Color.Red, this.PLUS);
            //Graphics g = e.Graphics;
            e.Graphics.FillRectangle(ln, this.ClientRectangle);
            base.OnPaint(e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
            colors.Add(Color.AntiqueWhite);
            colors.Add(Color.Coral);
            colors.Add(Color.CadetBlue);
            colors.Add(Color.Cyan);
        }

        private void button1_DragOver(object sender, DragEventArgs e)
        {
            //this.timer1.Start();
        }
    }
}
