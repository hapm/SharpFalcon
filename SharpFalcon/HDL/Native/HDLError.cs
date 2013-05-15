using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFalcon.HDL.Native
{
    public enum HDLError : int
    {
        /// <summary>
        /// No errors on error stack
        /// </summary>
        NoError = 0x0,

        /// <summary>
        /// Overflow of error stack
        /// </summary>
        StackOverflow = 0x1,

        /// <summary>
        /// HDAL internal error
        /// </summary>
        Internal = 0x2,

        /// <summary>
        /// Mask for all initialization errors
        /// </summary>
        AllInitErrors = 0x1F,

        /// <summary>
        /// Device initialization error
        /// </summary>
        InitFailed = 0x10,

        /// <summary>
        /// Could not find configuration file
        /// </summary>
        InitIniNotFound = 0x11,

        /// <summary>
        /// No DLL name in configuration file
        /// </summary>
        InitIniDllStringNotFound = 0x12,

        /// <summary>
        /// No MANUFACTURER_NAME value in configuration file
        /// </summary>
        InitIniManufacturerNameStringNotFound = 0x13,

        /// <summary>
        /// Could not load driver DLL
        /// </summary>
        InitDllLoadError = 0x14,

        /// <summary>
        /// Failed to initilize device
        /// </summary>
        InitDeviceFailure = 0x15,

        /// <summary>
        /// Device already initialized
        /// </summary>
        InitDeviceAlreadyInited = 0x16,

        /// <summary>
        /// Requested device not connected
        /// </summary>
        InitDeviceNotConnected = 0x17,

        /// <summary>
        /// Could not start servo thread
        /// </summary>
        ServoStartError = 0x18
    }
}
