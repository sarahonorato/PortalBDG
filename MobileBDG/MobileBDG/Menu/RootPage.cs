using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileBDG.Menu
{
    public class RootPage : MasterDetailPage
    {
        MenuPage menuPage;

        public RootPage()
        {
            menuPage = new MenuPage();

            menuPage.Menu.ItemSelected +=
                (sender, e) => NavigateTo(e.SelectedItem as MenuItem);

            Master = menuPage;

            Detail = new NavigationPage(new Home());

            MasterBehavior = MasterBehavior.Popover;
        }

        void NavigateTo(MenuItem menu)
        {
            if (menu == null)
                return;

            Page displayPage = null;            

            switch (menu.TargetType.Name)
            {
                case "Home":
                case "Ouça":
                case "Playlists":
                default:
                    displayPage = (Page)Activator.CreateInstance(menu.TargetType);
                    break;       
            };

            try
            {          
                Detail = new NavigationPage(displayPage);
            }
            catch (Exception ex)
            {
                App.Current.MainPage.DisplayAlert("ERRO", "Erro " + ex.Message, "OK");
            }

            menuPage.Menu.SelectedItem = null;
            IsPresented = false;
        }
    }
}
