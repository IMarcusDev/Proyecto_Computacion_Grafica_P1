using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoGraficaP1.src;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoGraficaP1
{
    public partial class FigureAnimation : Form
    {
        private bool _isPaused = false;
        private int indexPage;
        private List<List<Animation>> numAnimaciones = new List<List<Animation>>();

        private Graphics g;
        private Pen p;

        private int IndexAnimation = 0;

        List<Polygon> poly1 = new List<Polygon>();

        List<Color> colors = new List<Color> { Color.Violet, Color.Red, Color.Purple, Color.Green, Color.DarkGreen, Color.DarkOrange, Color.Orange, Color.Peru, Color.Pink, Color.Tan};
        private bool _inicio = true;

        Bitmap picCanvasCopy; 
        List<Action<Graphics>> framesCopy = new List<Action<Graphics>>();

        public FigureAnimation()
        {
            InitializeComponent();
            g = picCanvas.CreateGraphics();
            p = new Pen(Color.Black, 2);

            this.indexPage = 0;

            this.picCanvasCopy = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = picCanvasCopy;
            AnimationsPreloaded.center = GetCenterPicCanvas();  // Assign center
            setNumerateAnimations(AnimationsPreloaded.GetMovie1()); // lista de animaciones
            setNumerateAnimations(AnimationsPreloaded.GetMovie2()); // lista de animaciones
            setNumerateAnimations(AnimationsPreloaded.GetMovie3()); // lista de animaciones

            setFramesToPoly(this.numAnimaciones[2]);
        }

        private void setBarCount(int maximun, int minimun = 0)
        {
            pBrProgreso.Minimum = minimun;
            pBrProgreso.Maximum = maximun;
        }

        private void setFramesToPoly(List<Animation> poly)
        {
            var count = poly.Count();
            List<List<Polygon>> arrA = new List<List<Polygon>>();
            for (int i = 0; i < count; i++) 
            {
                arrA.Add(poly[i].Build());
                for(int j = 0; j < arrA[i].Count(); j++)
                {
                    poly1.Add(arrA[i][j]);
                }
            }
        }

        private void setNumerateAnimations(List<Animation> movie)
        {
            this.numAnimaciones.Add(movie);
        }

        private void drawFrames()
        {
            ensureFramesUpTo(IndexAnimation + 1);
            IndexAnimation++;
            drawAllAgain();
            pBrProgreso.Value = IndexAnimation;
        }


        private void drawAllAgain()
        {
            using (Graphics g = Graphics.FromImage(picCanvasCopy))
            {
                g.Clear(Color.White);
                for (int i = 0; i < IndexAnimation && i < framesCopy.Count; i++)
                {
                    framesCopy[i](g);
                }
            }
            picCanvas.Invalidate();
        }


        private void restartAnimation()
        {
            this.picCanvasCopy = new Bitmap(picCanvas.Width, picCanvas.Height);
            this.picCanvas.Image = picCanvasCopy;

            using (Graphics g = Graphics.FromImage(picCanvasCopy))
            {
                g.Clear(Color.White);
            }

            this.framesCopy.Clear();
            this.IndexAnimation = 0;
            pBrProgreso.Value = 0;
            btnPlay.Text = " ▶";
            _inicio = true;
        }

        private void actualizarCentro()
        {
            this.numAnimaciones.Clear();
            AnimationsPreloaded.center = GetCenterPicCanvas();
            setNumerateAnimations(AnimationsPreloaded.GetMovie1()); // lista de animaciones
            setNumerateAnimations(AnimationsPreloaded.GetMovie2()); // lista de animaciones
            setNumerateAnimations(AnimationsPreloaded.GetMovie3()); // lista de animaciones
        }

        private void ensureFramesUpTo(int target)
        {
            for (int i = framesCopy.Count; i < target && i < poly1.Count; i++)
            {
                int colorIndex = i % colors.Count;
                int index = i;
                actualizarCentro();
                Color currentColor = this.colors[colorIndex];
                framesCopy.Add(g => {
                    using (Pen localPen = new Pen(currentColor, 2))
                    {
                        g.DrawPolygon(localPen, poly1[index].GetOutline());
                    }
                });
            }
        }

        private PointF GetCenterPicCanvas()
        {
            return new PointF(picCanvas.Width / 2, picCanvas.Height / 2);
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private async void btnPlay_Click(object sender, EventArgs e)
        {
            if (IndexAnimation >= poly1.Count())
            {
                restartAnimation();
                btnPlay.Text = "⏸";
                _isPaused = false;
                _inicio = false;

                await barraProgresion();
            }
            else
            {
                if (btnPlay.Text == " ▶")
                {
                    btnPlay.Text = "⏸";
                    _isPaused = false;
                    if (_inicio)
                    {
                        _inicio = false;
                    }
                }
                else
                {
                    btnPlay.Text = " ▶";
                    _isPaused = true;
                }

                await barraProgresion();
            }
        }


        public async Task barraProgresion()
        {           

            while (this.IndexAnimation < poly1.Count())
            {
                while (_isPaused)
                {
                    await Task.Delay(100);
                }

                if (this.framesCopy.Count() < poly1.Count()) { drawFrames(); }


                await Task.Delay(150);
            }

            if (IndexAnimation == poly1.Count())
            {
                btnPlay.Text = " ▶";
                _inicio = true;
            }
        }

        private void btnNextFigure_Click(object sender, EventArgs e)
        {
            this.indexPage++;
            if (this.indexPage >= this.numAnimaciones.Count())
                this.indexPage = 0;

            restartAnimation();
            actualizarCentro();

            this.poly1.Clear();
            setFramesToPoly(this.numAnimaciones[this.indexPage]);
            setBarCount(this.poly1.Count());
        }

        private void btnPreviousFigure_Click(object sender, EventArgs e)
        {
            this.indexPage--;
            if (this.indexPage < 0)
                this.indexPage = this.numAnimaciones.Count() - 1;

            restartAnimation();
            actualizarCentro();

            this.poly1.Clear();
            setFramesToPoly(this.numAnimaciones[this.indexPage]);
            setBarCount(this.poly1.Count());
        }


        private void btnAdelatar_Click(object sender, EventArgs e)
        {
            if (IndexAnimation < poly1.Count())
            {
                IndexAnimation += 5;
                if (IndexAnimation > poly1.Count()) IndexAnimation = poly1.Count();

                ensureFramesUpTo(IndexAnimation);
                drawAllAgain();
                pBrProgreso.Value = IndexAnimation;
            }
        }

        private void btnAtrasar_Click(object sender, EventArgs e)
        {
            if (IndexAnimation > 0)
            {
                IndexAnimation -= 5;
                if (IndexAnimation < 0) IndexAnimation = 0;

                drawAllAgain();
                pBrProgreso.Value = IndexAnimation;
            }
        }
    }
}
