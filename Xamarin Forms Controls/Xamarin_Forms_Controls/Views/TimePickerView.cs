using Xamarin.Forms;

namespace Xamarin_Forms_Controls.Views
{
    public class TimePickerView : ContentPage
    {
        public TimePickerView()
        {
            Label header = new Label
            {
                Text = "TimePicker",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            TimePicker timePicker = new TimePicker
            {
                Format = "T",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    timePicker
                }
            };
        }
    }
}
