using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomApp.Effects
{
    public class FocusEntryEffect : RoutingEffect
    {
        public FocusEntryEffect() : base($"CustomApp.{nameof(FocusEntryEffect)}")
        {
        }
    }
}
