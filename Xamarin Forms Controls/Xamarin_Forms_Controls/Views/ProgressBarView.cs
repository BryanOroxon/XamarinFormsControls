using System;
using Xamarin.Forms;

namespace Xamarin_Forms_Controls.Views
{
    public class ProgressBarView : ContentPage
    {
        ProgressBar progressBar;
        bool isActiveWindow;

        public ProgressBarView()
        {
            Label header = new Label
            {
                Text = "ProgressBar",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            progressBar = new ProgressBar
            {
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    progressBar
                }
            };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            isActiveWindow = true;
            Device.StartTimer(TimeSpan.FromSeconds(0.1), TimerCallback);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            isActiveWindow = false;
        }

        bool TimerCallback()
        {
            progressBar.Progress += 0.01;
            return isActiveWindow || progressBar.Progress == 1;
        }
    }
}