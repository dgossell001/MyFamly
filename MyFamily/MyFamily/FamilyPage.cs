using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MyFamily
{
    public class FamilyPage : ContentPage
    {
        public FamilyPage()
        {
            StackLayout stlLayout = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "My Family"
                    }
                }
            };

            this.Content = stlLayout;
        }
    }
}
