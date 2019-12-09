﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aurora.Devices;

namespace Device_Example
{
    public class ExampleDevice : Aurora.Devices.Device
    {
        protected override string DeviceName => "Example Device";

        public override bool Initialize()
        {
            Log("Initializing example!");

            return isInitialized = true;
        }

        public override void Shutdown()
        {
            Log("Shutting down example!");

            isInitialized = false;
        }

        public override bool UpdateDevice(Dictionary<DeviceKeys, System.Drawing.Color> keyColors, DoWorkEventArgs e, bool forced = false)
        {
            //Log("Updating!");
            return true;
        }
    }
}
