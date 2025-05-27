using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGraficaP1.src
{
    static class AnimationsPreloaded
    {
        public static PointF center = new PointF(0, 0);  // Assign center when start form
        public static List<Animation> GetMovie1()
        {
            // Explicación:
            // Esta función generará 4 figuras que rotarán constantemente pero se dispersarán desde el centro
            // hasta las esquinas. Desde ahí, empezarán a rotar en dirección contraria y cambiarán de extremo
            // al derecho más cercano. Una vez ahí, acabarán volviendo al centro.
            int numLados = 5;
            Animation firstShape = new Animation(new Polygon(numLados, 30, center, Math.PI / 5));
            Animation secondShape = new Animation(new Polygon(numLados, 30, center, Math.PI / 5));
            Animation thirdShape = new Animation(new Polygon(numLados, 30, center, Math.PI / 5));
            Animation fourthShape = new Animation(new Polygon(numLados, 30, center, Math.PI / 5));

            AnimationStep rotateInCenter = new AnimationStep(20, rotate: Math.PI / 10);

            firstShape
                .AddStep(rotateInCenter)
                .AddStep(new AnimationStep(25, -center.X, -center.Y, Math.PI / 10))
                .AddStep(rotateInCenter)
                .AddStep(new AnimationStep(20, traslateY: 2 * center.Y))
                ;
            secondShape
                .AddStep(rotateInCenter)
                .AddStep(new AnimationStep(25, center.X, -center.Y, Math.PI / 10))
                .AddStep(rotateInCenter)
                .AddStep(new AnimationStep(20, traslateX: -2 * center.X))
                ;
            thirdShape
                .AddStep(rotateInCenter)
                .AddStep(new AnimationStep(25, center.X, center.Y, Math.PI / 10))
                .AddStep(rotateInCenter)
                .AddStep(new AnimationStep(20, traslateY: -2 * center.Y))
                ;
            fourthShape
                .AddStep(rotateInCenter)
                .AddStep(new AnimationStep(25, -center.X, center.Y, Math.PI / 10))
                .AddStep(rotateInCenter)
                .AddStep(new AnimationStep(20, traslateX: 2 * center.X))
                ;

            return new List<Animation> { 
                firstShape, secondShape, thirdShape, fourthShape
            };
        }

        public static List<Animation> GetMovie2()
        {
            // Explicación
            // Esta animación generará figuras poco a poco que saldrán girando hacia afuera, con una rotación constante
            // de la figura, pero la salida será poco a poco y con dirección a semicircunferencia.
            int numLados = 3;
            Animation firstShape = new Animation(new Polygon(numLados, 30, center, Math.PI / 5));
            Animation secondShape = new Animation(new Polygon(numLados, 30, center, Math.PI / 5));
            Animation thirdShape = new Animation(new Polygon(numLados, 30, center, Math.PI / 5));
            Animation fourthShape = new Animation(new Polygon(numLados, 30, center, Math.PI / 5));

            Polygon circle = new Polygon(50, center.X / 2, radRotate: Math.PI / 2);
            var circlePoints = circle.GetOutline();

            int framesNum = circle.GetNumLados() / 2;
            for (int i = 0; i < framesNum; i++)
            {
                firstShape
                    .AddStep(new AnimationStep(1, circlePoints[i].X / framesNum, circlePoints[i].Y / framesNum))
                    ;
                secondShape
                    .AddStep(new AnimationStep(1, -circlePoints[i].X / framesNum, circlePoints[i].Y / framesNum))
                    ;
                thirdShape
                    .AddStep(new AnimationStep(1, -circlePoints[i].X / framesNum, -circlePoints[i].Y / framesNum))
                    ;
                fourthShape
                    .AddStep(new AnimationStep(1, circlePoints[i].X / framesNum, -circlePoints[i].Y / framesNum))
                    ;
            }

            for (int i = 0; i < framesNum; i++)
            {
                firstShape
                    .AddStep(new AnimationStep(1, circlePoints[i].X / framesNum, circlePoints[i].Y / framesNum))
                    ;
                secondShape
                    .AddStep(new AnimationStep(1, -circlePoints[i].X / framesNum, circlePoints[i].Y / framesNum))
                    ;
                thirdShape
                    .AddStep(new AnimationStep(1, -circlePoints[i].X / framesNum, -circlePoints[i].Y / framesNum))
                    ;
                fourthShape
                    .AddStep(new AnimationStep(1, circlePoints[i].X / framesNum, -circlePoints[i].Y / framesNum))
                    ;
            }

            for (int i = 0; i < framesNum; i++)
            {
                firstShape
                    .AddStep(new AnimationStep(1, circlePoints[i].X / framesNum, circlePoints[i].Y / framesNum))
                    ;
                secondShape
                    .AddStep(new AnimationStep(1, -circlePoints[i].X / framesNum, circlePoints[i].Y / framesNum))
                    ;
                thirdShape
                    .AddStep(new AnimationStep(1, -circlePoints[i].X / framesNum, -circlePoints[i].Y / framesNum))
                    ;
                fourthShape
                    .AddStep(new AnimationStep(1, circlePoints[i].X / framesNum, -circlePoints[i].Y / framesNum))
                    ;
            }

            return new List<Animation> { firstShape, secondShape, thirdShape, fourthShape };
        }

        public static List<Animation> GetMovie3()
        {
            // Explicación:
            // Figura que inicia desde el centro y, mientras crece, va rotando y formando una "flor"
            int numLados = 5;
            Animation shape = new Animation(new Polygon(numLados, 0, center));

            int numFrames = 100;
            shape.AddStep(new AnimationStep(numFrames, scale: 300, rotate: 2 * Math.PI));

            return new List<Animation> { shape };
        }
    }
}
