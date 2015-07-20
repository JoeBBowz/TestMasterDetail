// -----------------------------------------------------------------------
//  <copyright file="<file.name>.cs" company="Polaris, Inc.">
// 	Copyright Polaris Industries 2015.
//  </copyright>
// -----------------------------------------------------------------------
using System;

using Xamarin.Forms;

namespace TestMasterDetail
{
    public class ColorTabbedPage : TabbedPage
    {
        public ColorTabbedPage ()
        {
            var blankPage = new ContentPage 
            {
                Title = "Blank Page",
                Content = new Label
                {
                    Text = "Blank Page"
                }
            };

            this.Children.Add (new NamedColorPage ());
            this.Children.Add (blankPage);
        }
    }
}


