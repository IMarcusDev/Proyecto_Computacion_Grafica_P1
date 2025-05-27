using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoGraficaP1
{
    public partial class FigureAnimation : Form
    {
        private bool _isPaused = false;
        private int valor = 0;
        private int figura = 1; //Numero de veces que adelanta o atrasa

        public FigureAnimation()
        {

            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private async void btnPlay_Click(object sender, EventArgs e)
        {
            if (valor >= 100)
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
            pBrProgreso.Maximum = 100;

            while (valor <= 100)
            {
                while (_isPaused)
                {
                    await Task.Delay(100); // Espera si está en pausa
                }

                pBrProgreso.Value = valor;
                valor++;

                await Task.Delay(50); // Simula trabajo

                if (valor > 100)
                {
                    valor = 100;
                    break;
                }
            }

            btnPlay.Text = " ▶";
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
            if (valor < 100)
            {
                valor += 5;
                if (valor > 100) valor = 100; // límite superior
                pBrProgreso.Value = valor;
            }
        }

        private void btnAtrasar_Click(object sender, EventArgs e)
        {
            if (valor > 0)
            {
                valor -= 5;
                if (valor < 0) valor = 0; // límite inferior
                pBrProgreso.Value = valor;
            }
        }
    }
}
