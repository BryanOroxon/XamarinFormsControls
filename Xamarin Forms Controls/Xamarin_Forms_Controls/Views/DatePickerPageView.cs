using Xamarin.Forms;

namespace Xamarin_Forms_Controls.Views
{
    public class DatePickerPageView : ContentPage
    {
        public DatePickerPageView()
        {
            Label header = new Label
            {
                Text = "DatePicker",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            DatePicker datePicker = new DatePicker
            {
                Format = "D",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    datePicker
                }
            };
        }
    }
}
