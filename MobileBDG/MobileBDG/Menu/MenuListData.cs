using System.Collections.Generic;
using System.Globalization;
using Xamarin.Forms;

namespace MobileBDG.Menu
{
    public class MenuListData : List<MenuItem>
    {
        public MenuListData()
        {
            CultureInfo ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();

            this.Add(new MenuItem()
            {
                Titulo = Resx.Menu.Home,
                Icon = "ic_home.png",
                TargetType = typeof(Home)
            });

            this.Add(new MenuItem()
            {
                Titulo = Resx.Menu.MyBDG,
                Icon = "ic_user.png",
                TargetType = typeof(MainPage)
            });

            this.Add(new MenuItem()
            {
                Titulo = Resx.Menu.Listen,
                Icon = "ic_headphone.png",
                TargetType = typeof(Home)
            });

            this.Add(new MenuItem()
            {
                Titulo = Resx.Menu.Playlist,
                Icon = "ic_playlist.png",
                TargetType = typeof(Home)
            });

            this.Add(new MenuItem()
            {
                Titulo = Resx.Menu.Genres,
                Icon = "ic_estilos.png",
                TargetType = typeof(Home)
            });

            if (ci.Name == "pt-BR") {
                this.Add(new MenuItem()
                {
                    Titulo = "Rota BDG",
                    Icon = "ic_rotabdg.png",
                    TargetType = typeof(Home)
                });
            }
        }
    }
}
