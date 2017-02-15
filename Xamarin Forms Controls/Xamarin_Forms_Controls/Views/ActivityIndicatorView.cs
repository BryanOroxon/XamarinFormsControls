using Xamarin.Forms;

namespace Xamarin_Forms_Controls.Views
{
    public class ActivityIndicatorView : ContentPage
    {
        public ActivityIndicatorView()
        {
            Label header = new Label
            {
                Text = "ActivityIndicator",
                FontSize = 40,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            ActivityIndicator activityIndicator = new ActivityIndicator
            {
                Color = Device.OnPlatform(Color.Black, Color.Default, Color.Default),
                IsRunning = true,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Content = new StackLayout
            {
                Children =
                {
                    header,
                    activityIndicator
                }
            };
        }
    }
}