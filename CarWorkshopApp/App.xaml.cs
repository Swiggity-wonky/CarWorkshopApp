using Microsoft.Maui;

namespace CarWorkshopApp
{
    public partial class App : Application
    {
        [Obsolete]
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }
    }
}

// Luqman update