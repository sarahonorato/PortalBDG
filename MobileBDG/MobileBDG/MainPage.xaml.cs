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
            Traducao();
        }

        private void Traducao()
        {
            lblTitulo.Text = Resx.Login.Title;
            txtUsuario.Placeholder = Resx.Login.DataField_Email_Label;
            txtSenha.Placeholder = Resx.Login.DataField_Password_Label;
            btnEntrar.Text = Resx.Login.TextLoginButton;
            btnRecupera.Text = Resx.Login.TextForgotPasswordButton;
            btnCriarConta.Text = Resx.Login.TextDontHaveAccount + " " + Resx.Login.LabelSignUp;
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
                Navigation.PushAsyncToPage(new NovaConta(), this);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }
    }
}
