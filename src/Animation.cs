using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGraficaP1.src
{
    internal class Animation
    {
        public readonly int NumFrames;
        public Polygon Polygon_Value;

        public float TraslateX = 0;
        public float TraslateY = 0;
        public double Rotate = 0;
        public float Scale = 1;

        public Animation(int numFrames, Polygon polygon)
        {
            NumFrames = numFrames;
            Polygon_Value = polygon;
        }

        public Animation(int numFrames, int numLados, int magnitud)
        {
            NumFrames = numFrames;
            Polygon_Value = new Polygon(numLados, magnitud, new PointF(0, 0), 0);
        }

        public List<Polygon> GetFrames()
        {
            List<Polygon> frames = new List<Polygon>();

            float traslateXVar = TraslateX / NumFrames;
            float traslateYVar = -TraslateY / NumFrames;
            double RotateVar = Rotate / NumFrames;

            for (int i = 0; i < NumFrames; i++)
            {
                Polygon p = new Polygon(Polygon_Value.GetNumLados(), Polygon_Value.GetMagnitud(), Polygon_Value.GetCenter());

                p.TraslateX(traslateXVar * i);
                p.TraslateY(traslateYVar * i);
                p.Rotate(RotateVar * i);

                frames.Add(p);
            }

            // Assign the polygon so new animation start from the last point
            Polygon_Value.TraslateX(TraslateX);
            Polygon_Value.TraslateY(-TraslateY);
            Polygon_Value.Rotate(Rotate);

            RemoveData();

            return frames;
        }

        // Current Polygon
        public Polygon GetPolygon()
        {
            return Polygon_Value;
        }

        public void RemoveData()
        {
            TraslateX = 0;
            TraslateY = 0;
            Rotate = 0;
        }
    }
}
