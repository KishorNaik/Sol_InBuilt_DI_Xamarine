﻿using Sol_Demo.Services;
using Sol_Demo.ViewModels;
using Sol_Demo.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sol_Demo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Register User Service
            DependencyService.Register<UserService>();

            MainPage = new MainPage();
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