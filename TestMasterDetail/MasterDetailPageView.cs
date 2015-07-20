// -----------------------------------------------------------------------
//  <copyright file="MasterDetailPageView.cs" company="Polaris, Inc.">
// 	Copyright Polaris Industries 2015.
//  </copyright>
// -----------------------------------------------------------------------
using System;

using Xamarin.Forms;
using System.Diagnostics;

namespace TestMasterDetail
{
    class MasterDetailPageView :  MasterDetailPage
    {
        public MasterDetailPageView()
        {
            Label header = new Label
            {                
                Text = "MasterDetailPage",
                HorizontalOptions = LayoutOptions.Center
            };

            // Assemble an array of NamedColor objects.
            NamedColor[] namedColors = 
            {
                new NamedColor("Aqua", Color.Aqua),
                new NamedColor("Black", Color.Black),
                new NamedColor("Blue", Color.Blue),
                new NamedColor("Gray", Color.Gray),
                new NamedColor("Green", Color.Green),
                new NamedColor("Lime", Color.Lime),
                new NamedColor("Maroon", Color.Maroon),
                new NamedColor("Navy", Color.Navy),
                new NamedColor("Olive", Color.Olive),
                new NamedColor("Purple", Color.Purple),
                new NamedColor("Red", Color.Red),
                new NamedColor("Silver", Color.Silver),
                new NamedColor("Teal", Color.Teal),
                new NamedColor("White", Color.White),
                new NamedColor("Yellow", Color.Yellow)
            };

            DataTemplate listCell = new DataTemplate(() => new TextCell());
            listCell.SetBinding(TextCell.TextProperty, "Name");

            // Create ListView for the master page.
            ListView listView = new ListView
            {
                ItemsSource = namedColors,
                ItemTemplate = listCell
            };

            // Create the master page with the ListView.
            this.Master = new ContentPage
            {
                Padding = new Thickness (20),
                Title = header.Text,
                Content = new StackLayout
                {
                    Children = 
                    {
                        header, 
                        listView
                    }
                }
            };

            this.Master.Icon = "Hamburger.png";
            this.Master.Title = string.Empty;

            // Create the detail page using NamedColorPage and wrap it in a
            // navigation page to provide a NavigationBar and Toggle button
            this.Detail = new NavigationPage(new ColorTabbedPage());

            // Define a selected handler for the ListView.
            listView.ItemSelected += (sender, args) =>
            {
                // Set the BindingContext of the detail page.
                this.Detail.BindingContext = args.SelectedItem;

                // Show the detail page.
                this.IsPresented = false;
            };

            // Initialize the ListView selection.
            listView.SelectedItem = namedColors[0];

            this.IsPresentedChanged += this.OnIsPresentedChanged;
        }

        public void OnIsPresentedChanged (object sender, EventArgs e)
        {
            Debug.WriteLine ("Here we go.");
        }
    }

    public class NamedColor 
    {
        public NamedColor (string name, Color color)
        {
            this.Name = name;
            this.TheColor = color;
        }

        public string Name { get; set; }

        public Color TheColor { get; set; }
    }
}

