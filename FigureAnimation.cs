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
        private int valor = 0;
        private int figura = 1; //Numero de veces que adelanta o atrasa

        private Graphics g;
        private Pen p;

        private int IndexAnimation = 0;

        private Timer t;

        List<Animation> movie;

        List<Polygon> poly1;

        public FigureAnimation()
        {

            InitializeComponent();
            g = picCanvas.CreateGraphics();
            p = new Pen(Color.Black, 1);

            AnimationsPreloaded.center = GetCenterPicCanvas();  // Assign center
            movie = AnimationsPreloaded.GetMovie3(); // lista de animaciones 
            poly1 = movie[0].Build();
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
            //MessageBox.Show(""+ poly1.Count() + "");

            if (valor >= poly1.Count())
            {
                valor = 0;
                pBrProgreso.Value = 0;
                btnPlay.Text = " ▶";
            }else
            {
                if (btnPlay.Text == " ▶")
                {

                    btnPlay.Text = "⏸";
                    _isPaused = false;

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
            pBrProgreso.Minimum = 0;
            pBrProgreso.Maximum = poly1.Count();

            while (IndexAnimation < poly1.Count())
            {
                while (_isPaused)
                {
                    await Task.Delay(100); // Espera si está en pausa
                }

                g.DrawPolygon(p, poly1[IndexAnimation].GetOutline());

                pBrProgreso.Value = IndexAnimation + 1; // +1 si quieres que la barra avance desde 1
                IndexAnimation++;
                await Task.Delay(150);
            }

            btnPlay.Text = " ▶";
            IndexAnimation = 0; // Reinicia para la próxima vez
        }

        private void btnChangeFigureForward_Click(object sender, EventArgs e)
        {
            if (figura <= 2)
            {
                figura++;
            }

            if (figura == 1)
            {
                
            }else if (figura == 2)
            {

            }
            else if(figura == 3)
            {

            }
        }


        private void btnChangeFigure_Click(object sender, EventArgs e)
        {
            if (figura > 1)
            {
                figura--;
            }

            if (figura == 1)
            {

            }
            else if (figura == 2)
            {

            }
            else if (figura == 3)
            {

            }
        }


        private void btnAdelatar_Click(object sender, EventArgs e)
        {
            if (valor < poly1.Count())
            {
                valor += 5;
                if (valor > poly1.Count()) valor = poly1.Count(); // límite superior
                pBrProgreso.Value = valor;
            }
        }

        private void btnAtrasar_Click(object sender, EventArgs e)
        {
            if (valor > 0)
            {
                valor -= 1;
                if (valor < 0) valor = 0; // límite inferior
                pBrProgreso.Value = valor;
            }
        }
    }
}
