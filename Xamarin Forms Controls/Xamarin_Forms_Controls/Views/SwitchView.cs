using System;
using Xamarin.Forms;

namespace Xamarin_Forms_Controls.Views
{
    public class SwitchView : ContentPage
    {
        Label label;

        public SwitchView()
        {
            Label header = new Label
            {
                Text = "Switch",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            Switch switcher = new Switch
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            switcher.Toggled += switcher_Toggled;

            label = new Label
            {
                Text = "Switch is now False",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    switcher,
                    label
                }
            };
        }

        void switcher_Toggled(object sender, ToggledEventArgs e)
        {
            label.Text = String.Format("Switch is now {0}", e.Value);
        }
    }
}