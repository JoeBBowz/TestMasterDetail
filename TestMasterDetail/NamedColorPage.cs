// -----------------------------------------------------------------------
//  <copyright file="<file.name>.cs" company="Polaris, Inc.">
// 	Copyright Polaris Industries 2015.
//  </copyright>
// -----------------------------------------------------------------------
using System;

using Xamarin.Forms;

namespace TestMasterDetail
{
    public class NamedColorPage : ContentPage
    {
        public NamedColorPage ()
        {
            this.ColorName = new Label ();
            this.ColorName.SetBinding (Label.TextProperty, "Name");

            this.Title = "Named Color Page";

            Content = new StackLayout { 
                Children = 
                {
                    this.ColorName
                }
            };
        }
          
        public Label ColorName { get; set; }
    }
}


