using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpFalcon.HDL.Native;

namespace SharpFalcon.HDL
{
    public class DeviceManager : IReadOnlyList<HapticDevice>, IDisposable
    {
        private static DeviceManager instance;
        private List<HapticDevice> devices;
        private bool disposed;

        private DeviceManager()
        {
            devices = new List<HapticDevice>();
            int count = NativeMethods.hdlCountDevices();
            for (int i = 0; i < count; i++)
            {
                HapticDevice dev = new HapticDevice(this, i);
                devices.Add(dev);
            }
        }

        public static DeviceManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new DeviceManager();

                return instance;
            }
        }

        public int Count
        {
            get 
            {
                if (disposed) 
                    throw new ObjectDisposedException("DeviceManager");
                return devices.Count; 
            }
        }

        public bool IsRunning
        {
            get { return (Status & DeviceStatus.NotRunning) != DeviceStatus.NotRunning; }
        }

        public IEnumerator<HapticDevice> GetEnumerator()
        {
            if (disposed)
                throw new ObjectDisposedException("DeviceManager");
            return devices.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            if (disposed)
                throw new ObjectDisposedException("DeviceManager");
            return (devices as System.Collections.IEnumerable).GetEnumerator();
        }

        public void Dispose()
        {
            if (disposed)
                throw new ObjectDisposedException("DeviceManager");

            this.disposed = true;
            if (IsRunning)
                Stop();

            foreach (HapticDevice dev in devices)
            {
                dev.Uninit();
            }

            DeviceManager.instance = null;
        }

        public HapticDevice this[int index]
        {
            get { return devices[index]; }
        }

        public DeviceStatus Status
        {
            get 
            {
                return (DeviceStatus)NativeMethods.hdlGetState(); 
            } 
        }

        public void Stop()
        {
            NativeMethods.hdlStop();
        }

        public void Start()
        {
            NativeMethods.hdlStart();
        }
    }
}
