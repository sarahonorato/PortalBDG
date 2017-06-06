
using MobileBDG.Models;
using MobileBDG.Util;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace MobileBDG
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        bool alertShown = false;

        public Home()
        {
            InitializeComponent();
            Traducao();
        }

        private void Traducao()
        {
            BarraBusca.Placeholder = Resx.Shared.Strings.TextSearchField;
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsyncToPage(new Video(), this);
        }

        private async Task BarraBusca_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
               // ListaHome.BeginRefresh();

                //if (string.IsNullOrWhiteSpace(e.NewTextValue))
                //    ListaHome.ItemsSource = _container.Employees;
                //else
                //    ListaHome.ItemsSource = _container.Employees.Where(i => i.Name.Contains(e.NewTextValue));

                //ListaHome.EndRefresh();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }


        protected async override void OnAppearing()
        {
            base.OnAppearing();

            if (Constants.RestUrl.Contains("developer.xamarin.com"))
            {
                if (!alertShown)
                {
                    await DisplayAlert(
                        "Hosted Back-End",
                        "This app is running against Xamarin's read-only REST service. To create, edit, and delete data you must update the service endpoint to point to your own hosted REST service.",
                        "OK");
                    alertShown = true;
                }
            }

            listView.ItemsSource = await App.TodoManager.GetTasksAsync();
        }

        void OnAddItemClicked(object sender, EventArgs e)
        {
            var todoItem = new TodoItem()
            {
                ID = Guid.NewGuid().ToString()
            };
            //var todoPage = new TodoItemPage(true);
            //todoPage.BindingContext = todoItem;
            //Navigation.PushAsync(todoPage);
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var todoItem = e.SelectedItem as TodoItem;
            //var todoPage = new TodoItemPage();
            //todoPage.BindingContext = todoItem;
            //Navigation.PushAsync(todoPage);
        }
    }
}
