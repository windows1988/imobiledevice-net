//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="iDeviceSocketType.cs" company="Quamotion">
// Copyright (c) 2016-2020 Quamotion. All rights reserved.
// </copyright>
#pragma warning disable 1591
#pragma warning disable 1572
#pragma warning disable 1573

namespace iMobileDevice.iDevice
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.Plist;
    
    
    /// <summary>
    /// specifies how libusbmuxd should connect to usbmuxd
    /// </summary>
    public enum iDeviceSocketType : int
    {
        
        SocketTypeUnix = 1,
        
        SocketTypeTcp = 2,
    }
}
