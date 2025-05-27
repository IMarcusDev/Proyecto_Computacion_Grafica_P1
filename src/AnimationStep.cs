using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGraficaP1.src
{
    internal class AnimationStep
    {
        public readonly int NumFrames;

        public float TraslateX = 0;
        public float TraslateY = 0;
        public double Rotate = 0;
        public float Scale = 0;

        public AnimationStep(int numFrames)
        {
            NumFrames = numFrames;
        }

        public AnimationStep(int numFrames, float traslateX = 0, float traslateY = 0, double rotate = 0, float scale = 0) : this(numFrames)
        {
            TraslateX = traslateX;
            TraslateY = traslateY;
            Rotate = rotate;
            Scale = scale;
        }

        public List<Polygon> GetFrames(Polygon Polygon_Value)
        {
            List<Polygon> frames = new List<Polygon>();

            float traslateXVar = TraslateX / NumFrames;
            float traslateYVar = -TraslateY / NumFrames;
            double RotateVar = Rotate / NumFrames;
            float ScaleVar = Scale / NumFrames;

            for (int i = 0; i < NumFrames; i++)
            {
                Polygon p = new Polygon(Polygon_Value.GetNumLados(), Polygon_Value.GetMagnitud(), Polygon_Value.GetCenter());

                p.TraslateX(traslateXVar * i);
                p.TraslateY(traslateYVar * i);
                p.Rotate(RotateVar * i);
                p.ScaleInteger(ScaleVar * i);

                frames.Add(p);
            }

            // Assign the polygon so new animation start from the last point
            Polygon_Value.TraslateX(TraslateX);
            Polygon_Value.TraslateY(-TraslateY);
            Polygon_Value.Rotate(Rotate);

            return frames;
        }

        public List<Polygon> GetFrames(int numLados, int magnitud, PointF center = new PointF(), double rotateRad = 0)
        {
            return GetFrames(new Polygon(numLados, magnitud, center, rotateRad));
        }
    }
}
