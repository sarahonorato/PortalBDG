using System.Collections.Generic;

namespace MobileBDG.Menu
{
    public class MenuListData : List<MenuItem>
    {
        public MenuListData()
        {
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
                Titulo = Resx.Menu.Videos,
                Icon = "ic_video.png",
                TargetType = typeof(Home)
            });
            this.Add(new MenuItem()
            {
                Titulo = "Rota BDG",
                Icon = "ic_rotabdg.png",
                TargetType = typeof(Home)
            });
            this.Add(new MenuItem()
            {
                Titulo = "BDG Live",
                Icon = "ic_bdglive.png",
                TargetType = typeof(Home)
            });
            this.Add(new MenuItem()
            {
                Titulo = Resx.Menu.Genres,
                Icon = "ic_estilos.png",
                TargetType = typeof(Home)
            });
            this.Add(new MenuItem()
            {
                Titulo = "Blog",
                Icon = "ic_blog.png",
                TargetType = typeof(Home)
            });
            this.Add(new MenuItem()
            {
                Titulo = Resx.Menu.Events,
                Icon = "ic_calendar.png",
                TargetType = typeof(Home)
            });
        }
    }
}
