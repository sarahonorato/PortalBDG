using Android.App;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Graphics.Drawables;
using MobileBDG.Droid.Renderer;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(CustomNavigationRenderer))]
namespace MobileBDG.Droid.Renderer
{
    //Customiza o botão do menu no Android
    public class CustomNavigationRenderer : NavigationRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<NavigationPage> e)
        {
            base.OnElementChanged(e);
            e.NewElement.BarBackgroundColor = Color.FromHex("f05050");
            AddAppIconFromActionBar();
        }
        void AddAppIconFromActionBar()
        {
            var actionBar = ((Activity)Context).ActionBar;
            actionBar.SetIcon(Resource.Drawable.ic_menubar);
        }
    }
}