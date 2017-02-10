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

            int intRelativeCount = 19;
            
            // Load some dictionaries with the relative's role, name, and display colors
            for (int i=1; i<=intRelativeCount; i++)
            {
                switch (i)
                {
                    case 1:
                        strName = "David Gossell";
                        strRole = "Me, myself, and I";
                        clrFground = Color.Red;
                        clrBground = Color.White;
                        break;
                    case 2:
                        strName = "Joni Gossell";
                        strRole = "Who would've have guessed I'd find a wife.";
                        clrFground = Color.Yellow;
                        clrBground = Color.Black;
                        break;
                    case 3:
                        strName = "John Gossell, Jr.";
                        strRole = "David's Paternal Grandfather";
                        clrFground = Color.Navy;
                        clrBground = Color.Yellow;
                        break;
                    case 4:
                        strName = "Agnes Giossell";
                        strRole = "David's Paternal Grandmother";
                        clrFground = Color.Green;
                        clrBground = Color.Silver;
                        break;
                    case 5:
                        strName = "Charles Buhl";
                        strRole = "David's Maternal Grandfather";
                        clrFground = Color.Navy;
                        clrBground = Color.Yellow;
                        break;
                    case 6:
                        strName = "Martha Buhl";
                        strRole = "David's Maternal Grandmother";
                        clrFground = Color.Green;
                        clrBground = Color.Silver;
                        break;
                    case 7:
                        strName = "Joseph Plutowski";
                        strRole = "Joni's Paternal Grandfather";
                        clrFground = Color.Red;
                        clrBground = Color.White;
                        break;
                    case 8:
                        strName = "Helen Plutowski";
                        strRole = "Joni's Paternal Grandmother";
                        clrFground = Color.Yellow;
                        clrBground = Color.Black;
                        break;
                    case 9:
                        strName = "John Breidenbach";
                        strRole = "Joni's Maternal Grandfather";
                        clrFground = Color.Navy;
                        clrBground = Color.Yellow;
                        break;
                    case 10:
                        strName = "Ethel Breidenbach";
                        strRole = "Joni's Maternal Grandmother";
                        clrFground = Color.Green;
                        clrBground = Color.Silver;
                        break;
                    case 11:
                        strName = "Roy Gossell";
                        strRole = "David's Father";
                        clrFground = Color.Red;
                        clrBground = Color.White;
                        break;
                    case 12:
                        strName = "Joann Gossell";
                        strRole = "David's Mother";
                        clrFground = Color.Yellow;
                        clrBground = Color.Black;
                        break;
                    case 13:
                        strName = "Raymond Plutowski";
                        strRole = "Joni's Father";
                        clrFground = Color.Navy;
                        clrBground = Color.Yellow;
                        break;
                    case 14:
                        strName = "Rose Ann Plutowski";
                        strRole = "Joni's Mother";
                        clrFground = Color.Green;
                        clrBground = Color.Silver;
                        break;
                    case 15:
                        strName = "Cory Gossell";
                        strRole = "Our oldest daughter";
                        clrFground = Color.Green;
                        clrBground = Color.Silver;
                        break;
                    case 16:
                        strName = "John Gossell";
                        strRole = "Our son";
                        clrFground = Color.Red;
                        clrBground = Color.White;
                        break;
                    case 17:
                        strName = "Hallie Gossell";
                        strRole = "Our youngest daughter";
                        clrFground = Color.Yellow;
                        clrBground = Color.Black;
                        break;
                    case 18:
                        strName = "Tyrann Owen";
                        strRole = "Our grandson/John's son";
                        clrFground = Color.Navy;
                        clrBground = Color.Yellow;
                        break;
                    case 19:
                        strName = "Ellie";
                        strRole = "Hallie's BFF who is like one of our family";
                        clrFground = Color.Green;
                        clrBground = Color.Silver;
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
            for (int i = 1; i <= intRelativeCount; i++)
            {
                FormattedString fstFamilyText = new FormattedString();

                //Add a span for the relative's role
                fstFamilyText.Spans.Add(new Span
                {
                    Text = sdcRoles[i] + ":\n",
                    FontAttributes = FontAttributes.Bold,
                    ForegroundColor = sdcFgrounds[i]
                });

                //Add a span for the relative's name
                fstFamilyText.Spans.Add(new Span
                {
                    Text = sdcNames[i],
                    FontAttributes = FontAttributes.Italic,
                    ForegroundColor = sdcFgrounds[i]
                });

                Label lblFamilyLabel = (new Label
                {
                    FormattedText = fstFamilyText,
                    TextColor = sdcBgrounds[i],
                    BackgroundColor = sdcBgrounds[i]
                });

                stlMainLayout.Children.Add(lblFamilyLabel);
            }

            // Put the stack layout into a scrollview
            this.Content = new ScrollView
            {
                Content = stlMainLayout
            };
        }
    }
}
