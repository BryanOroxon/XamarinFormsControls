using Xamarin.Forms;

namespace Xamarin_Forms_Controls.Views
{
    public class MainView : ContentPage
    {
        public MainView()
        {
            Label header = new Label
            {
                Text = "Xamarin.Forms Controls",
                FontSize = 40,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            Button activityIndicator = new Button
            {
                Text = " ActivityIndicator ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };

            activityIndicator.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new ActivityIndicatorView());

            Button boxView = new Button
            {
                Text = " BoxView ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };

            boxView.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new BoxViewPageView());

            Button button = new Button
            {
                Text = " Button ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };

            button.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new ButtonView());

            Button datePicker = new Button
            {
                Text = " DatePicker ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };

            datePicker.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new DatePickerPageView());

            Button editor = new Button
            {
                Text = " Editor ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };

            editor.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new EditorView());

            Button entry = new Button
            {
                Text = " Entry ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };

            entry.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new EntryView());

            Button image = new Button
            {
                Text = " Image ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };

            image.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new ImageView());

            Button label = new Button
            {
                Text = " Label ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };

            label.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new LabelView());

            Button listView = new Button
            {
                Text = " ListView ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };

            listView.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new ListViewPageView());

            Button picker = new Button
            {
                Text = " Picker ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };

            picker.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new PickerView());

            Button progressBar = new Button
            {
                Text = " Progress Bar ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };

            progressBar.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new ProgressBarView());

            Button searchBar = new Button
            {
                Text = " SearchBar ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };

            searchBar.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new SearchBarView());

            Button slider = new Button
            {
                Text = " Slider ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };

            slider.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new SliderView());

            Button stepper = new Button
            {
                Text = " Stepper ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };

            stepper.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new StepperView());

            Button switchView = new Button
            {
                Text = " Switch ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };

            switchView.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new SwitchView());

            Button timePicker = new Button
            {
                Text = " TimePicker ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };

            timePicker.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new TimePickerView());

            Button webView = new Button
            {
                Text = " WebView ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };

            webView.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new WebViewPageView());

            Content = new StackLayout
            {
                Children =
                {
                    header,
                    activityIndicator,
                    boxView,
                    button,
                    datePicker,
                    editor,
                    entry,
                    image,
                    label,
                    listView,
                    picker,
                    progressBar,
                    searchBar,
                    slider,
                    stepper,
                    switchView,
                    timePicker,
                    webView
                }
            };
        }
    }
}