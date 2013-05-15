using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFalcon.HDL
{
    [Flags]
    public enum DeviceStatus
    {
        Ready = 0,
        Uninitialized = 0x01,
        NotRunning = 0x02,
        NotCalibrated = 0x04
    }
}
