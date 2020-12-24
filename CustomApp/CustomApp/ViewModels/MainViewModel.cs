using CustomApp.Services;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomApp.ViewModels
{
	class MainViewModel
	{
        public DelegateCommand RotationCommand { get; set; }
        public MainViewModel()
        {
            RotationCommand = new DelegateCommand(() => {
                DependencyService.Get<IDeviceOrientationService>().GetOrientation();

            });
        }
    }
}
