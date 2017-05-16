using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileBDG
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NovaConta : ContentPage
    {
        public NovaConta()
        {
            InitializeComponent();
            Traducao();
            ConfigCboSexo();
            ConfigCboPais();
        }

        private void Traducao()
        {
            lblTitulo.Text = Resx.Login.Title;
            lblCriarConta.Text = Resx.Login.TextCreateAccount;
            txtNome.Placeholder = Resx.Login.DataField_Name_Label;
            txtEmail.Placeholder = Resx.Login.DataField_Email_Label;
            txtSenha.Placeholder = Resx.Login.DataField_Password_Label;
            txtConfSenha.Placeholder = Resx.Login.DataField_PasswordConfirmation_Label;
            cboSexo.Title = Resx.Login.DataField_Gender_OptionDefault;
            txtDataNasc.Placeholder = Resx.Login.DataField_BirthDate_Label;
            cboPais.Title = Resx.Login.DataField_Country_OptionDefault;
            cboEstado.Title = Resx.Login.DataField_State_OptionDefault;
            btnCadastro.Text = Resx.Login.LabelSignUp;
            btnEntrar.Text = Resx.Login.TextAlreadyHaveAccount + " " + Resx.Login.TextLoginButton;
        }

        private async void btnOk_Clicked(object sender, EventArgs e)
        {
            try
            {
                await DisplayAlert("BDG", Resx.Login.ReturnSignUpSuccess, "Ok");
                Navigation.PushAsyncToPage(new Home(), this);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async void btnEntrar_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsyncToPage(new MainPage(), this);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private void ConfigCboSexo()
        {
            try
            {
                List<string> listaSexo = new List<string>();
                listaSexo.Add("Feminino");
                listaSexo.Add("Masculino");

                foreach (string opcao in listaSexo)
                {
                    cboSexo.Items.Add(opcao);
                }

                cboSexo.SelectedIndexChanged += (sender, args) =>
                {
                   
                };
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro", ex.Message, "OK");
            }
        }

        private void ConfigCboPais()
        {
            try
            {
                List<string> listaPais = new List<string>();
                listaPais.Add("Brasil");

                foreach (string opcao in listaPais)
                {
                    cboPais.Items.Add(opcao);
                }

                cboPais.SelectedIndexChanged += (sender, args) =>
                {
                    cboEstado.IsVisible = true;
                    ConfigCboEstado(1);
                };
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro", ex.Message, "OK");
            }
        }

        private void ConfigCboEstado(int IDPais)
        {
            try
            {
                List<string> listaEstado = new List<string>();
                listaEstado.Add("São Paulo");
                listaEstado.Add("Rio de Janeiro");

                foreach (string opcao in listaEstado)
                {
                    cboEstado.Items.Add(opcao);
                }

                cboEstado.SelectedIndexChanged += (sender, args) =>
                {

                };
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro", ex.Message, "OK");
            }
        }
    }
}
