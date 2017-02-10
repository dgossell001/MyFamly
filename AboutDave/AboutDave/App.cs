using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AboutDave
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            string strTimeOfDay = "morning";
            DateTime dtCurrent = DateTime.Now;
            int intHour = dtCurrent.Hour;

            if(11 < intHour & intHour < 17) { strTimeOfDay = "afternoon"; } // noon to 4:59 PM is afternoon
            if ( 17 <= intHour & intHour <= 24) { strTimeOfDay = "evening"; } // 5PM to midnight is evening
            if (intHour < 2) { strTimeOfDay = "evening"; }    // midnight to 1:59 is evening

            string strMessage = "Good " + strTimeOfDay + ". My name is Dave(id).";
            strMessage += "\nI am 6', 2\" tall and weigh a bit";
            strMessage += " more than I'd like.";
            strMessage += "\nI've been around long enough to remember when";
            strMessage += " the \"shell\" WAS the user interface.";

            var content = new ContentPage
            {
                Title = "AboutDave",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = strMessage
                        }
                    }
                }
            };

            MainPage = new NavigationPage(content);
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
