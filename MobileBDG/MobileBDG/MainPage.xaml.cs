using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileBDG
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnEntrar_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsyncToPage(new Home(), this);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnRecuperaSenha_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsyncToPage(new Home(), this);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnCriarConta_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsyncToPage(new Home(), this);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }
    }
}
