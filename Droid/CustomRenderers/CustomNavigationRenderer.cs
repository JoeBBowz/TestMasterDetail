// -----------------------------------------------------------------------
//  <copyright file="CustomNavigationRenderer.cs" company="Polaris, Inc.">
// 	Copyright Polaris Industries 2015.
//  </copyright>
// -----------------------------------------------------------------------

using System;
using Xamarin.Forms;
using Android.App;
using Android.Graphics.Drawables;
using Xamarin.Forms.Platform.Android;
using System.ComponentModel;
using TestMasterDetail.Droid;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(CustomNavigationRenderer))]

namespace TestMasterDetail.Droid
{
    public class CustomNavigationRenderer : NavigationRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<NavigationPage> e)
        {
            base.OnElementChanged (e);

            var actionBar = ((Activity)Context).ActionBar;
            actionBar.SetIcon (new ColorDrawable(Color.Transparent.ToAndroid()));
        }
    }
}

