//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="IRecoveryApi.cs" company="Quamotion">
// Copyright (c) 2016-2020 Quamotion. All rights reserved.
// </copyright>
#pragma warning disable 1591
#pragma warning disable 1572
#pragma warning disable 1573

namespace iMobileDevice.Recovery
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.Plist;
    
    
    public partial interface IRecoveryApi
    {
        
        /// <summary>
        /// Gets or sets the <see cref="ILibiMobileDeviceApi"/> which owns this <see cref="Recovery"/>.
        /// </summary>
        ILibiMobileDevice Parent
        {
            get;
        }
        
        void irecv_set_debug_level(int level);
        
        System.IntPtr irecv_strerror(RecoveryError error);
        
        void irecv_init();
        
        void irecv_exit();
        
        RecoveryError irecv_open_with_ecid(out RecoveryClientHandle client, ulong ecid);
        
        RecoveryError irecv_open_with_ecid_and_attempts(out RecoveryClientHandle pclient, ulong ecid, int attempts);
        
        RecoveryError irecv_reset(RecoveryClientHandle client);
        
        RecoveryError irecv_close(RecoveryClientHandle client);
        
        RecoveryClientHandle irecv_reconnect(RecoveryClientHandle client, int initialPause);
        
        RecoveryError irecv_receive(RecoveryClientHandle client);
        
        RecoveryError irecv_execute_script(RecoveryClientHandle client, string script);
        
        RecoveryError irecv_reset_counters(RecoveryClientHandle client);
        
        RecoveryError irecv_finish_transfer(RecoveryClientHandle client);
        
        RecoveryError irecv_trigger_limera1n_exploit(RecoveryClientHandle client);
        
        RecoveryError irecv_usb_set_configuration(RecoveryClientHandle client, int configuration);
        
        RecoveryError irecv_usb_set_interface(RecoveryClientHandle client, int usbInterface, int usbAltInterface);
        
        int irecv_usb_control_transfer(RecoveryClientHandle client, char bmRequestType, char bRequest, ushort wValue, ushort wIndex, ref char data, ushort wLength, uint timeout);
        
        int irecv_usb_bulk_transfer(RecoveryClientHandle client, char endpoint, ref char data, int length, ref int transferred, uint timeout);
        
        RecoveryError irecv_device_event_subscribe(out RecoveryDeviceEventContextHandle context, RecoveryDeviceEventCallBack callback, System.IntPtr userData);
        
        RecoveryError irecv_device_event_unsubscribe(RecoveryDeviceEventContextHandle context);
        
        RecoveryError irecv_event_subscribe(RecoveryClientHandle client, RecoveryEventType type, RecoveryEventCallBack callback, System.IntPtr userData);
        
        RecoveryError irecv_event_unsubscribe(RecoveryClientHandle client, RecoveryEventType type);
        
        RecoveryError irecv_send_file(RecoveryClientHandle client, string filename, int dfuNotifyFinished);
        
        RecoveryError irecv_send_command(RecoveryClientHandle client, string command);
        
        RecoveryError irecv_send_buffer(RecoveryClientHandle client, ref char buffer, int length, int dfuNotifyFinished);
        
        RecoveryError irecv_recv_buffer(RecoveryClientHandle client, System.IntPtr buffer, int length);
        
        RecoveryError irecv_saveenv(RecoveryClientHandle client);
        
        RecoveryError irecv_getenv(RecoveryClientHandle client, string variable, out string value);
        
        RecoveryError irecv_setenv(RecoveryClientHandle client, string variable, string value);
        
        RecoveryError irecv_reboot(RecoveryClientHandle client);
        
        RecoveryError irecv_getret(RecoveryClientHandle client, ref uint value);
        
        RecoveryError irecv_get_mode(RecoveryClientHandle client, ref int mode);
        
        System.IntPtr irecv_get_device_info(RecoveryClientHandle client);
        
        RecoveryDeviceHandle irecv_devices_get_all();
        
        RecoveryError irecv_devices_get_device_by_client(RecoveryClientHandle client, out RecoveryDeviceHandle device);
        
        RecoveryError irecv_devices_get_device_by_product_type(string productType, out RecoveryDeviceHandle device);
        
        RecoveryError irecv_devices_get_device_by_hardware_model(string hardwareModel, out RecoveryDeviceHandle device);
    }
}
