using Xamarin.Forms;

namespace Xamarin_Forms_Controls.Views
{
    public class BoxViewPageView : ContentPage
    {
        public BoxViewPageView()
        {
            Label header = new Label
            {
                Text = "BoxView",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            BoxView boxView = new BoxView
            {
                Color = Color.Accent,
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    boxView
                }
            };
        }
    }
}
