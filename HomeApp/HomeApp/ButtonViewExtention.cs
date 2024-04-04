using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;
using Xamarin.Forms.Xaml;

namespace HomeApp
{
    public class ButtonViewExtention : IMarkupExtension
    {
        public ButtonStyle ButtonStyle { get; set; }
                
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            switch (ButtonStyle)
            {
                case ButtonStyle.Default:
                    return 0;
                case ButtonStyle.SemiRound:
                    return 15;
                case ButtonStyle.Round:
                    return 30;
                default:
                    return 0;
            }
        }
    }

    public enum ButtonStyle
    {
        Default,
        SemiRound,
        Round
    }
}
