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
            ConfigCboSexo();
            ConfigCboPais();
        }

        private async void btnOk_Clicked(object sender, EventArgs e)
        {
            try
            {
                await DisplayAlert("BDG", "Cadastro finalizado com sucesso!", "Ok");
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
