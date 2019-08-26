using System;

using Xamarin.Forms;

namespace lands.Views
{
    public class LandPage : ContentPage
    {
        public LandPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

