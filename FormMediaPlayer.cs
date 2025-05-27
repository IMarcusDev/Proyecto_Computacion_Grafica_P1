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

        private int IndexAnimation = 0;

        private Timer t;

        List<Animation> movie;

        List<Polygon> poly1;
        List<Polygon> poly2;
        List<Polygon> poly3;
        List<Polygon> poly4;

        public FormMediaPlayer()
        {
            InitializeComponent();

            g = picCanvas.CreateGraphics();
            p = new Pen(Color.Black, 1);

            AnimationsPreloaded.center = GetCenterPicCanvas();  // Assign center
            movie = AnimationsPreloaded.GetMovie3();

            poly1 = movie[0].Build();
            //poly2 = movie[1].Build();
            //poly3 = movie[2].Build();
            //poly4 = movie[3].Build();
        }

        private void Draw(object sender, EventArgs e)
        {
            if (IndexAnimation > poly1.Count() - 2) { t.Stop(); picCanvas.Refresh(); }
            else { 
                g.DrawPolygon(p, poly1[IndexAnimation].GetOutline());
                //g.DrawPolygon(p, poly2[IndexAnimation].GetOutline());
                //g.DrawPolygon(p, poly3[IndexAnimation].GetOutline());
                //g.DrawPolygon(p, poly4[IndexAnimation].GetOutline());
            }

            IndexAnimation++;
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
