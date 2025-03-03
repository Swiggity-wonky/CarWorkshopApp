using CarWorkshopApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace CarWorkshopApp.ViewModels
{
    public partial class TaskOverviewViewModel : ObservableObject
    {
        [ObservableProperty]
        private DateTime selectedDate = DateTime.Today;

        [ObservableProperty]
        private ObservableCollection<Task> tasks = new ObservableCollection<Task>();

        public TaskOverviewViewModel()
        {
            LoadAllTasks();
        }

        private void LoadAllTasks()
        {
            Tasks.Clear();
            foreach (var task in TaskService.GetAllTasks())
            {
                Tasks.Add(task);
            }
        }

        partial void OnSelectedDateChanged(DateTime oldValue, DateTime newValue)
        {
            FilterTasksByDate();
        }

        private void FilterTasksByDate()
        {
            Tasks.Clear();
            foreach (var task in TaskService.GetAllTasks().Where(t => t.DeliveryDate.Date == SelectedDate))
            {
                Tasks.Add(task);
            }
        }
    }
}