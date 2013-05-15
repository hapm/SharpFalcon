using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using SharpFalcon.HDL.Native;

namespace SharpFalcon.HDL
{
    public class DeviceLoopOperation
    {
        private bool blocking;
        private int handle;
        private bool continueProcessing;
        private HapticDevice device;
        private DeviceLoopOperationDelegate operation;
        private GCHandle gch;
        private bool lastResult;

        internal DeviceLoopOperation(DeviceLoopOperationDelegate operation, bool blocking, HapticDevice dev)
        {
            if (operation == null)
                throw new ArgumentNullException("operation");

            this.operation = operation;
            this.blocking = blocking;
            this.device = dev;
        }

        internal int Start(IntPtr pParam)
        {
            lastResult = operation(device);
            device.Force.Update();
            if (lastResult)
                return 1;
            else
            {
                handle = 0;
                return 0;
            }
        }

        internal void Register()
        {
            HDLServoOP op = Start;
            gch = GCHandle.Alloc(op);
            IntPtr opPtr = Marshal.GetFunctionPointerForDelegate(op);
            NativeMethods.hdlMakeCurrent(device.Handle);
            this.handle = NativeMethods.hdlCreateServoOp(opPtr, IntPtr.Zero, blocking);
        }

        internal void Unregister()
        {
            if (handle != 0)
            {
                NativeMethods.hdlMakeCurrent(device.Handle);
                NativeMethods.hdlDestroyServoOp(handle);
                handle = 0;
            }

            gch.Free();
        }

        public bool IsBlocking
        {
            get { return blocking; }
        }

        public DeviceLoopOperationDelegate Operation
        {
            get { return operation; }
        }
    }
}
