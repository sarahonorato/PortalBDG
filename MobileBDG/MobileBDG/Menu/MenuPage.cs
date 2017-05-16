using Xamarin.Forms;

namespace MobileBDG.Menu
{
    public class MenuPage : ContentPage
    {
        public ListView Menu { get; set; }

        public MenuPage()
        {
            Title = "Menu";
            BackgroundColor = Color.FromHex("232C32");

            Menu = new MenuListView();

            var label = new Label
            {
                TextColor = Color.FromHex("7d94a4"),
                Text = Resx.Menu.Title,
                FontSize = 16,
                Margin = 2
            };            

            var layout = new StackLayout
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Padding = 5
            };

            layout.Children.Add(label);
            layout.Children.Add(Menu);

            Content = layout;
        }
    }
}
