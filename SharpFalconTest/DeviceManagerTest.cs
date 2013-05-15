using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SharpFalcon.HDL.Native
{
    [TestClass]
    public class DeviceManagerTest
    {
        [TestMethod]
        public void Constructor()
        {
            DeviceManager mgr = DeviceManager.Instance;
            Assert.IsNotNull(mgr);
            Assert.AreEqual(1, mgr.Count);
            mgr.Dispose();
        }

        [TestMethod]
        public void Index()
        {
            DeviceManager mgr = DeviceManager.Instance;
            HapticDevice dev = mgr[0];
            Assert.IsNotNull(dev);
            mgr.Dispose();
        }

        [TestMethod]
        public void Status()
        {
            DeviceManager mgr = DeviceManager.Instance;
            Assert.AreEqual(DeviceStatus.NotRunning, mgr.Status & DeviceStatus.NotRunning);
            Assert.IsFalse(mgr.IsRunning);
            mgr.Dispose();
        }
    }
}
