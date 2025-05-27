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
        private int IndexAnimation = 0;

        private List<Polygon> CurrentAnimation;

        private Timer t;

        public FormMediaPlayer()
        {
            InitializeComponent();

            g = picCanvas.CreateGraphics();
            p = new Pen(Color.Black, 1);

            a1 = new Animation(new Polygon(5, 25, GetCenterPicCanvas()));

            // Add Many Steps as wanted
            a1.AddStep(10, 100, 30, Math.PI / 3)
              .AddStep(new AnimationStep(5, 100, -30, -Math.PI / 3))
              .AddStep(new AnimationStep(15, -100, -30, Math.PI / 3))
              .AddStep(new AnimationStep(25, 100, 30, -Math.PI / 3))
              ;

            CurrentAnimation = a1.Build();
        }

        private void Draw(object sender, EventArgs e)
        {
            g.DrawPolygon(p, CurrentAnimation[IndexAnimation].GetOutline());
            IndexAnimation++;

            if (IndexAnimation >= a1.GetNumFrames()) t.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IndexAnimation = 0;

            t = new Timer();
            t.Interval = 150;
            t.Tick += Draw;
            t.Start();
        }

        private PointF GetCenterPicCanvas()
        {
            return new PointF(picCanvas.Width/2, picCanvas.Height/2);
        }
    }
}
