using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileBDG.Menu
{
    public class MenuListData : List<MenuItem>
    {
        public MenuListData()
        {
            this.Add(new MenuItem()
            {
                Titulo = Resx.Resources.Home,
                Icon = "ic_home.png",
                TargetType = typeof(MainPage)
            });

            this.Add(new MenuItem()
            {
                Titulo = Resx.Resources.MeuBDG,
                Icon = "ic_user.png",
                TargetType = typeof(MainPage)
            });

            this.Add(new MenuItem()
            {
                Titulo = Resx.Resources.Ouca,
                Icon = "ic_headphone.png",
                TargetType = typeof(MainPage)
            });
            this.Add(new MenuItem()
            {
                Titulo = Resx.Resources.Playlists,
                Icon = "ic_playlist.png",
                TargetType = typeof(MainPage)
            });
            this.Add(new MenuItem()
            {
                Titulo = Resx.Resources.Videos,
                Icon = "ic_video.png",
                TargetType = typeof(MainPage)
            });
            this.Add(new MenuItem()
            {
                Titulo = Resx.Resources.Rota,
                Icon = "ic_rotabdg.png",
                TargetType = typeof(MainPage)
            });
            this.Add(new MenuItem()
            {
                Titulo = Resx.Resources.BDGLive,
                Icon = "ic_bdglive.png",
                TargetType = typeof(MainPage)
            });
            this.Add(new MenuItem()
            {
                Titulo = Resx.Resources.Estilos,
                Icon = "ic_estilos.png",
                TargetType = typeof(MainPage)
            });
            this.Add(new MenuItem()
            {
                Titulo = Resx.Resources.Blog,
                Icon = "ic_blog.png",
                TargetType = typeof(MainPage)
            });
            this.Add(new MenuItem()
            {
                Titulo = Resx.Resources.Eventos,
                Icon = "ic_calendar.png",
                TargetType = typeof(MainPage)
            });
        }
    }
}
