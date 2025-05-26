using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProyectoGraficaP1.src
{
    internal class Animation
    {
        private int NumFrames;
        public Polygon polygon;

        private List<AnimationStep> Animations;

        public Animation(Polygon p)
        {
            NumFrames = 0;
            polygon = p;
            Animations = new List<AnimationStep>();
        }

        public int GetNumFrames()
        {
            return NumFrames;
        }

        public Animation AddStep(AnimationStep step)
        {
            Animations.Add(step);
            NumFrames += step.NumFrames;
            return this;
        }

        public Animation AddStep(int numFrames, float traslateX = 0, float traslateY = 0, double rotateRad = 0, float scale = 0)
        {
            Animations.Add(new AnimationStep(numFrames, traslateX, traslateY, rotateRad, scale));
            NumFrames += numFrames;
            return this;
        }

        public List<Polygon> Build()
        {
            List<Polygon> polygons = new List<Polygon>();

            foreach (AnimationStep step in Animations)
            {
                foreach (Polygon frames in step.GetFrames(polygon))
                    polygons.Add(frames);
            }

            return polygons;
        }
    }
}
