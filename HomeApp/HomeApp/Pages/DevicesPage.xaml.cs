﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DevicesPage : ContentPage
	{
		public DevicesPage ()
		{
			InitializeComponent();
            GetDevices();
        }

        public void GetDevices()
        {            
            var homeDevices = new List<string>()
           {
               "Чайник",
               "Стиральная машина",
               "Посудомоечная машина",
               "Мультиварка",
               "Водонагреватель",
               "Плита",
               "Микроволновая печь",
               "Духовой шкаф",
               "Холодильник",
               "Увлажнитель воздуха",
               "Телевизор",
               "Пылесос",
               "Музыкальный центр",
               "Компьютер",
               "Игровая консоль"
           };
                        
            var innerStack = new StackLayout();
                        
            foreach (string deviceName in homeDevices)
            {
                var deviceLabel = new Label() { Text = $"   {deviceName}", FontSize = 17 };
                innerStack.Children.Add(new Label());
                innerStack.Children.Add(deviceLabel);
            }
                        
            scrollView.Content = innerStack;

        }
    }
}