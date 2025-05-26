using ProyectoGraficaP1.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGraficaP1
{
    public partial class FormMediaPlayer : Form
    {
        private Graphics g;
        private Pen p;

        private Animation a1;

        public FormMediaPlayer()
        {
            InitializeComponent();

            g = picCanvas.CreateGraphics();
            p = new Pen(Color.Black, 1);

            a1 = new Animation(new Polygon(5, 25, GetCenterPicCanvas()));
        }

        private void Draw()
        {
            // Add Many Steps as wanted
            a1.AddStep(10, 100, 30, Math.PI / 3)
              .AddStep(new AnimationStep(5, 100, -30, -Math.PI / 3))
              //.AddStep()
              ;

            foreach (Polygon poly in a1.Build())
                g.DrawPolygon(p, poly.GetOutline());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Draw();
        }

        private PointF GetCenterPicCanvas()
        {
            return new PointF(picCanvas.Width/2, picCanvas.Height/2);
        }
    }
}
