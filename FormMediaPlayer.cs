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
        private Animation a;

        public FormMediaPlayer()
        {
            InitializeComponent();

            g = picCanvas.CreateGraphics();
            p = new Pen(Color.Black, 1);
            a = new Animation(10, new Polygon(5, 50, GetCenterPicCanvas()));
        }

        private void Draw()
        {
            a.TraslateX = 100;
            a.TraslateY = 30;
            a.Rotate = Math.PI;

            DrawFrames(a.GetFrames());

            // New Frames
            a.TraslateX = -100;
            a.TraslateY = 30;

            DrawFrames(a.GetFrames());

            a.TraslateX = -150;

            DrawFrames(a.GetFrames());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Draw();
        }

        private PointF GetCenterPicCanvas()
        {
            return new PointF(picCanvas.Width/2, picCanvas.Height/2);
        }

        private void DrawFrames(List<Polygon> frames)
        {
            foreach (var frame in frames)
            {
                g.DrawPolygon(p, frame.GetOutline());
            }
        }
    }
}
