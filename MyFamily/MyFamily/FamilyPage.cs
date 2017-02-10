using System;
using System.Collections;
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
            StackLayout stlMainLayout = new StackLayout();

            string strName = "";
            SortedDictionary<int, string> sdcNames = new SortedDictionary<int, string>();
            string strRole = "";
            SortedDictionary<int, string> sdcRoles = new SortedDictionary<int, string>();
            Color clrFground = Color.Black;
            SortedDictionary<int, Color> sdcFgrounds = new SortedDictionary<int, Color>();
            Color clrBground = Color.White;
            SortedDictionary<int, Color> sdcBgrounds = new SortedDictionary<int, Color>();

            int intRelativeCount = 2;
            
            // Load some dictionaries with the relative's role, name, and display colors
            for (int i=1; i<=intRelativeCount; i++)
            {
                switch (i)
                {
                    case 1:
                        strName = "John Gossell, Jr.";
                        strRole = "David's Paternal Grandfather";
                        clrFground = Color.Red;
                        clrBground = Color.White;
                        break;
                    case 2:
                        strName = "Agnes Gossell";
                        strRole = "David's Paternal Grandmother";
                        clrFground = Color.Yellow;
                        clrBground = Color.Black;
                        break;
                    default:
                        break;
                }

                sdcNames.Add(i, strName);
                sdcRoles.Add(i, strRole);
                sdcFgrounds.Add(i, clrFground);
                sdcBgrounds.Add(i, clrBground);
            }

            // create formatted string for each relative's role and name,
            //  then put the formatted sting into a label
            for (int i = 1; i <+ intRelativeCount; i++)
            {
                FormattedString fstFamilyText = new FormattedString();

                //Add a span for the relative's role
                fstFamilyText.Spans.Add(new Span
                {
                    Text = sdcRoles[i],
                    FontAttributes = FontAttributes.Bold,
                    ForegroundColor = sdcFgrounds[i],
                    BackgroundColor = sdcBgrounds[i]
                });

                //Add a span for the relative's name
                fstFamilyText.Spans.Add(new Span
                {
                    Text = sdcNames[i],
                    FontAttributes = FontAttributes.Italic,
                    ForegroundColor = sdcFgrounds[i],
                    BackgroundColor = sdcBgrounds[i]
                });

                // Add a span as a spacer
                fstFamilyText.Spans.Add(new Span
                {
                    Text = "SPACER",
                    ForegroundColor = sdcBgrounds[i],
                    BackgroundColor = sdcBgrounds[i]
                });

                Label lblFamilyLabel = (new Label
                {
                    FormattedText = fstFamilyText
                });
            }
            
            this.Content = stlMainLayout;
        }
    }
}
