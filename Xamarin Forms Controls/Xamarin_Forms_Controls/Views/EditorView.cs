using Xamarin.Forms;

namespace Xamarin_Forms_Controls.Views
{
    public class EditorView : ContentPage
    {
        public EditorView()
        {
            Label header = new Label
            {
                Text = "Editor",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            Editor editor = new Editor
            {
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            Content = new StackLayout
            {
                Children =
                {
                    header,
                    editor
                }
            };
        }
    }
}
