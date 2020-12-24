using CustomApp.iOS.Services;
using CustomApp.Services;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

[assembly: Dependency(typeof(DeviceOrientationService))]
namespace CustomApp.iOS.Services
{
    public class DeviceOrientationService : IDeviceOrientationService
    {
        public DeviceOrientation GetOrientation()
        {
            var currentOrientation = UIApplication.SharedApplication.StatusBarOrientation;
            bool isPortrait = currentOrientation == UIInterfaceOrientation.Portrait || currentOrientation == UIInterfaceOrientation.PortraitUpsideDown;

            return !isPortrait ? DeviceOrientation.Landscape : DeviceOrientation.Portrait;

        }
    }
}