using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HomeApp.Pages
{
    public class LoadingPage : ContentPage
    {
        public LoadingPage()
        {
            Label header = new Label() { Text = $"Запуск вашего первого приложения{Environment.NewLine} на Xamarin..." };
                        
            header.Opacity = 0;
            header.HorizontalTextAlignment = TextAlignment.Center;
            header.VerticalTextAlignment = TextAlignment.Center;
            header.FontSize = 21;
            
            header.FadeTo(1, 3000);

            
            this.Content = header;
        }
    }
}