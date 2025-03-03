using CarWorkshopApp.Views;
using Microsoft.Maui.Controls;

namespace CarWorkshopApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private async void OnBookTaskClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BookTaskPage());
        }

        private async void OnTaskOverviewClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TaskOverviewPage());
        }

        private async void OnInvoiceClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InvoicePage());
        }
    }
}