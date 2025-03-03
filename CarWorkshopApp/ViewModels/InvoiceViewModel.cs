using CarWorkshopApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CarWorkshopApp.ViewModels
{
    public partial class InvoiceViewModel : ObservableObject
    {
        [ObservableProperty]
        private Invoice invoice = new Invoice();

        [RelayCommand]
        private void SaveInvoice()
        {
            InvoiceService.AddInvoice(Invoice);
        }
    }
}