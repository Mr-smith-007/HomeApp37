﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HomeApp.Pages;

namespace HomeApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GridPage(); //new AboutPage(); //new ClimatePage(); //new DevicesPage(); //new RoomsPage(); //new LoginPage(); //new LoadingPage(); //new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
