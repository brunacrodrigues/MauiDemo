using MauiDataBinding.Pages;

namespace MauiDataBinding
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //return new Window(new AppShell());
            var pagina = new NotifyBinding();
            var navPage = new NavigationPage(pagina)
            {
                BarBackgroundColor = Colors.Blue,
                BarTextColor = Colors.White
            };
            return new Window(navPage);
        }
    }
}