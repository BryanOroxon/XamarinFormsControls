using Xamarin.Forms;

namespace Xamarin_Forms_Controls.Views
{
    public class EntryView : ContentPage
    {
        public EntryView()
        {
            Label header = new Label
            {
                Text = "Entry",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            Content = new StackLayout
            {
                Children =
                {
                    header,
                    new Entry
                    {
                        Keyboard = Keyboard.Email,
                        Placeholder = "Email",
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    },
                    new Entry
                    {
                        Keyboard = Keyboard.Text,
                        Placeholder = "Password",
                        IsPassword = true,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    },
                    new Entry
                    {
                        Keyboard = Keyboard.Telephone,
                        Placeholder = "Teléfono",
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}