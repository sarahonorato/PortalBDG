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
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            Traducao();
        }

        private void Traducao() {
            BarraBusca.Placeholder = Resx.Shared.Strings.TextSearchField;
        }

        private async Task BarraBusca_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                ListaHome.BeginRefresh();

                //if (string.IsNullOrWhiteSpace(e.NewTextValue))
                //    ListaHome.ItemsSource = _container.Employees;
                //else
                //    ListaHome.ItemsSource = _container.Employees.Where(i => i.Name.Contains(e.NewTextValue));

                ListaHome.EndRefresh();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async Task ListaHome_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            try
            {
                //var selectedItem = (Employee)e.Item;

                //var employeePage = new EmployeePage(selectedItem);
                //await Navigation.PushAsync(employeePage, true);

                //ListaHome.SelectedItem = null;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }

        private async Task ListaHome_Refreshing(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }
    }
}
