using System;
using System.Collections.Generic;
using SharpFalcon.HDL.Native;
using Microsoft.Xna.Framework;
using System.Runtime.InteropServices;

namespace SharpFalcon.HDL
{
    public delegate bool DeviceLoopOperationDelegate(HapticDevice device);

    public class HapticDevice
    {
        private int deviceId;
        private int deviceHandle;
        private DeviceWorkspace workspace;
        private DeviceForce force;
        private string model;
        private HashSet<DeviceLoopOperation> loopOps;

        public string Model
        {
            get { return model; }
        }

        internal HapticDevice(DeviceManager mgr, int deviceId)
        {
            this.deviceId = deviceId;
            this.deviceHandle = NativeMethods.hdlInitIndexedDevice(deviceId);
            if (this.deviceHandle == -1)
                throw new DeviceInitializationFailedException(deviceId, NativeMethods.hdlGetError());

            double[] wsValues = new double[6];
            NativeMethods.hdlMakeCurrent(deviceHandle);
            NativeMethods.hdlDeviceWorkspace(wsValues);
            IntPtr modelPtr;
            modelPtr = NativeMethods.hdlDeviceModel();
            this.model = Marshal.PtrToStringAnsi(modelPtr);
            workspace = new DeviceWorkspace(wsValues);
            this.force = new DeviceForce(this);
            this.loopOps = new HashSet<DeviceLoopOperation>();
        }

        internal void Uninit()
        {
            foreach (DeviceLoopOperation op in loopOps)
            {
                op.Unregister();
            }

            loopOps.Clear();
            NativeMethods.hdlUninitDevice(deviceHandle);
            deviceHandle = -1;
        }

        public int Handle
        {
            get { return deviceHandle; }
        }

        public Vector3d Position
        {
            get
            {
                Vector3d result = new Vector3d(new double[3]);
                NativeMethods.hdlMakeCurrent(deviceHandle);
                unsafe
                {
                    fixed (double* pos = result.AsArray())
                    {
                        NativeMethods.hdlToolPosition(pos);
                    }
                }

                return result;
            }
        }

        public DeviceForce Force
        {
            get
            {
                return force;
            }
        }

        public DeviceWorkspace Workspace
        {
            get { return workspace; }
        }

        public bool IsButtonPressed
        {
            get
            {
                bool result = false;
                NativeMethods.hdlMakeCurrent(deviceHandle);
                NativeMethods.hdlToolButton(ref result);
                return result;
            }
        }

        public DeviceButtonState ButtonState 
        {
            get 
            {
                int result = 0;
                NativeMethods.hdlToolButtons(ref result);
                return (DeviceButtonState)result;
            } 
        }

        public DeviceLoopOperation RegisterDeviceLoopOperation(DeviceLoopOperationDelegate operation, bool isBlocking)
        {
            DeviceLoopOperation op = new DeviceLoopOperation(operation, isBlocking, this);
            loopOps.Add(op);
            op.Register();
            return op;
        }

        public void UnregisterDeviceLoopOperation(DeviceLoopOperation operation) 
        {
            if (!loopOps.Contains(operation))
                return;

            operation.Unregister();
            loopOps.Remove(operation);
        }
    }
}
