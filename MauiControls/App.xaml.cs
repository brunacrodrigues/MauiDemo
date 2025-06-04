using MauiControls.Pages;

namespace MauiControls
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //var minhaPagina = new MinhaPagina();

            //var navPage = new NavigationPage(minhaPagina);


            //navPage.BarBackgroundColor = Colors.Yellow;
            //navPage.BarTextColor = Colors.Blue;
            var pagina = new MauiSetValueControls();
            var navPage = new NavigationPage(pagina)
            {
                BarBackgroundColor = Colors.Blue,
                BarTextColor = Colors.White
            };
            return new Window(navPage);

            //var window = new Window(new MauiCommandControls());


            //return window;
        }
    }
}