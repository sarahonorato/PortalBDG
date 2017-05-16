using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;

using Xamarin.Forms;

namespace MobileBDG
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // This lookup NOT required for Windows platforms - the Culture will be automatically set
            if (Device.OS == TargetPlatform.iOS || Device.OS == TargetPlatform.Android)
            {
                // determine the correct, supported .NET culture
                var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
                // set the RESX for resource localization
                Resx.Embed.Culture = ci;
                Resx.Login.Culture = ci;
                Resx.Menu.Culture = ci;
                Resx.ProfileEdit.Culture = ci;
                Resx.ProfileEditAlbum.Culture = ci;
                Resx.ProfileEditArtist.Culture = ci;
                Resx.ProfileEditEvent.Culture = ci;
                Resx.ProfileEditSong.Culture = ci;
                Resx.ProfileEditVideo.Culture = ci;
                Resx.ProfileEditUser.Culture = ci;
                Resx.ProfileEditEvent.Culture = ci;
                Resx.SearchResults.Culture = ci;
                Resx.Shared.Strings.Culture = ci;
                Resx.Models.EditAlbumValidation.Culture = ci;
                Resx.Models.EditArtistValidation.Culture = ci;
                Resx.Models.EditEventValidation.Culture = ci;
                Resx.Models.EditMusicValidation.Culture = ci;
                Resx.Models.EditPlaylistValidation.Culture = ci;
                Resx.Models.EditProfileSecutityValidation.Culture = ci;
                Resx.Models.EditSongValidation.Culture = ci;
                Resx.Models.EditVideoValidation.Culture = ci;
                Resx.Models.SignUpFormValidation.Culture = ci;
                DependencyService.Get<ILocalize>().SetLocale(ci); // set the Thread for locale-aware methods
            }

            MainPage = new Menu.RootPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}