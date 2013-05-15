using System;

namespace SharpFalcon.HDL
{
    [Flags]
    public enum DeviceButtonState : uint
    {
        Button1 = 1,
        Button2 = 2,
        Button3 = 4,
        Button4 = 8,
        Any = 0xffffffff
    }
}