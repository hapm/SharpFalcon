using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpFalcon.HDL;

namespace SharpFalconTest
{
    [TestClass]
    public class HapticDeviceTest
    {
        [TestMethod]
        public void Workspace()
        {
            DeviceManager mgr = DeviceManager.Instance;
            HapticDevice dev = mgr[0];
            DeviceWorkspace ws= dev.Workspace;
            Assert.AreNotEqual(0, ws.MinX);
            Assert.AreNotEqual(0, ws.MinY);
            Assert.AreNotEqual(0, ws.MinZ);
            Assert.AreNotEqual(0, ws.MaxX);
            Assert.AreNotEqual(0, ws.MaxY);
            Assert.AreNotEqual(0, ws.MaxZ);
            mgr.Dispose();
        }

        [TestMethod]
        public void IsButtonPressed()
        {
            DeviceManager mgr = DeviceManager.Instance;
            HapticDevice dev = mgr[0];
            mgr.Start();
            Assert.IsFalse(dev.IsButtonPressed);
            mgr.Stop();
            mgr.Dispose();
        }
    }
}
