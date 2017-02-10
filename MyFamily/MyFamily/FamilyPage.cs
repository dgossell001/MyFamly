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
            FormattedString fstFamilyText = new FormattedString();

            fstFamilyText.Spans.Add(new Span
            {
                Text = "\nParents\n",
                FontAttributes = FontAttributes.Bold,
                ForegroundColor = Color.Yellow
            });

            fstFamilyText.Spans.Add(new Span
            {
                Text = "Me (David) - Too many years to count.\nJoni - Information withheld by request.\n\n",
                FontAttributes = FontAttributes.Italic,
                ForegroundColor = Color.White
            });

            fstFamilyText.Spans.Add(new Span
            {
                Text = "Children\n",
                FontAttributes = FontAttributes.Bold,
                ForegroundColor = Color.Yellow
            });

            fstFamilyText.Spans.Add(new Span
            {
                Text = "Cory - 25 years\nJohn - 23 years\nHallie - 17 years\n\n",
                FontAttributes = FontAttributes.Italic,
                ForegroundColor = Color.White
            });

            fstFamilyText.Spans.Add(new Span
            {
                Text = "Grandson\n",
                FontAttributes = FontAttributes.Bold,
                ForegroundColor = Color.Yellow
            });

            fstFamilyText.Spans.Add(new Span
            {
                Text = "Tyrann - 11 months",
                FontAttributes = FontAttributes.Italic,
                ForegroundColor = Color.White
            });

            Label lblFamily = new Label();

            lblFamily.FormattedText = fstFamilyText;
            lblFamily.HorizontalOptions = LayoutOptions.Center;
            lblFamily.FontFamily = "Times New Roman";

            StackLayout stlLayout = new StackLayout();
            stlLayout.Children.Add(lblFamily);
            stlLayout.BackgroundColor = Color.Blue;

            this.Content = stlLayout;
        }
    }
}
