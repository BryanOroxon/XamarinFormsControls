using Xamarin.Forms;

namespace Xamarin_Forms_Controls.Views
{
    public class WebViewPageView : ContentPage
    {
        public WebViewPageView()
        {
            Label header = new Label
            {
                Text = "WebView",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            WebView webView = new WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "https://xamarin.com",
                },
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    webView
                }
            };
        }
    }
}