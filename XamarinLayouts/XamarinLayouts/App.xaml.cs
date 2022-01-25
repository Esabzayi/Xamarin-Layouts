﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinLayouts
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AbsolutePage();
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
