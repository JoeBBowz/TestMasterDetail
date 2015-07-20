// -----------------------------------------------------------------------
//  <copyright file="<file.name>.cs" company="Polaris, Inc.">
// 	Copyright Polaris Industries 2015.
//  </copyright>
// -----------------------------------------------------------------------
using System;

using Xamarin.Forms;

namespace TestMasterDetail
{
    public class App : Application
    {
        public App ()
        {
            // The root page of your application
            this.MainPage = new MasterDetailPageView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

