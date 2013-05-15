using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpFalcon.HDL
{
    public struct DeviceWorkspace
    {
        public DeviceWorkspace(double[] wsValues)
        {
            this.MinX = wsValues[0];
            this.MinY = wsValues[0];
            this.MinZ = wsValues[0];
            this.MaxX = wsValues[0];
            this.MaxY = wsValues[0];
            this.MaxZ = wsValues[0];
        }

        public double MinX;
        public double MinY;
        public double MinZ;
        public double MaxX;
        public double MaxY;
        public double MaxZ;
    }
}
