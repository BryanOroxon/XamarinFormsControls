using System;
using Xamarin.Forms;

namespace Xamarin_Forms_Controls.Views
{
    public class ImageView : ContentPage
    {
        public ImageView()
        {
            Label header = new Label
            {
                Text = "Image",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            Image image = new Image
            {
                Source =
                    Device.OnPlatform(ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")),
                                      ImageSource.FromFile("ide_xamarin_studio.png"),
                                      ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png"))),
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Content = new StackLayout
            {
                Children =
                {
                    header,
                    image
                }
            };
        }
    }
}