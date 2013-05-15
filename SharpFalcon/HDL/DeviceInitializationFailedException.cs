using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpFalcon.HDL
{
    public class DeviceInitializationFailedException : Exception
    {
        private int deviceId;
        private int errorCode;

        public DeviceInitializationFailedException(String msg, int deviceId, int errorCode)
            : base(msg)
        {
            this.deviceId = deviceId;
            this.errorCode = errorCode;
        }

        public DeviceInitializationFailedException(int deviceId, int errorCode) 
            : base(String.Format("Initialization of device with id {0} failed with error code {1}", deviceId, errorCode))
        {
            this.deviceId = deviceId;
            this.errorCode = errorCode;
        }

        public int ErrorCode
        {
            get { return errorCode; }
        }

        public int DeviceId
        {
            get { return deviceId; }
        }
    }
}
