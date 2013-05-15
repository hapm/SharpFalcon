using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SharpFalcon.HDL.Native
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    delegate int HDLServoOP(IntPtr pParam);

    public static class NativeMethods
    {
        [DllImport("hdl.dll")]
        internal static extern uint hdlGetState();

        [DllImport("hdl.dll")]
        internal static extern void hdlStart();

        [DllImport("hdl.dll")]
        internal static extern void hdlStop();

        [DllImport("hdl.dll")]
        internal static extern int hdlGetError();

        [DllImport("hdl.dll")]
        internal static extern int hdlInitIndexedDevice([In]int deviceID, [In]string configPath = null);

        [DllImport("hdl.dll")]
        internal static extern int hdlCountDevices();

        [DllImport("hdl.dll")]
        internal static extern int hdlUninitDevice([In]int handle);

        [DllImport("hdl.dll")]
        internal static extern void hdlMakeCurrent([In]int handle);

        [DllImport("hdl.dll")]
        internal static extern void hdlDeviceWorkspace([Out]double[] workspaceDimensions);

        [DllImport("hdl.dll")]
        internal unsafe static extern void hdlToolPosition(double* position);

        [DllImport("hdl.dll")]
        internal static extern void hdlSetToolForce([In]double[] force);

        [DllImport("hdl.dll")]
        internal static extern void hdlToolButton(ref bool pButton);

        [DllImport("hdl.dll")]
        internal static extern IntPtr hdlDeviceModel();

        [DllImport("hdl.dll")]
        internal static extern void hdlToolButtons(ref int result);

        [DllImport("hdl.dll")]
        internal static extern int hdlCreateServoOp([In]IntPtr pServoOp, [In]IntPtr pParam, [In]bool blocking);

        [DllImport("hdl.dll")]
        internal static extern void hdlDestroyServoOp([In]int handle);
    }
}
