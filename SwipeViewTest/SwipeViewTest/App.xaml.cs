﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SwipeViewTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new Scrollview());
            MainPage = new Scrollview();

            //MainPage = new Benefits();

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