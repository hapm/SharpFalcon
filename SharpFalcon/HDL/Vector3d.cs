using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpFalcon.HDL
{
    public struct Vector3d
    {
        private double[] pos;
        public double X
        {
            get { return pos[0]; }
            set { pos[0] = value; }
        }

        public double Y
        {
            get { return pos[1]; }
            set { pos[1] = value; }
        }

        public double Z
        {
            get { return pos[2]; }
            set { pos[2] = value; }
        }

        internal Vector3d(double[] pos)
        {
            if (pos.Length != 3)
                throw new ArgumentException("Only array with the length of 3 allowed");

            this.pos = pos;
        }

        internal double[] AsArray()
        {
            return pos;
        }
    }
}
