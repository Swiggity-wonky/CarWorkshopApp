using CarWorkshopApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CarWorkshopApp.ViewModels
{
    public partial class BookTaskViewModel : ObservableObject
    {
        [ObservableProperty]
        private Task task = new Task();

        [RelayCommand]
        private void SaveTask()
        {
            TaskService.AddTask(Task);
        }
    }
}