namespace EventoApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Configurar navegação
            MainPage = new NavigationPage(new MainPage());
        }
    }
}

