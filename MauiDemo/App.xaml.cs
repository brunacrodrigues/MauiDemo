namespace MauiDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            
            var minhaPagina = new MinhaPagina();

            var navPage = new NavigationPage(minhaPagina);

            
            navPage.BarBackgroundColor = Colors.Yellow;
            navPage.BarTextColor = Colors.Blue;

            var window = new Window(new AbsoluteLayoutDemo());


            return window;
        }
    }
}