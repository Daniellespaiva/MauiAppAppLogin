namespace MauiAppAppLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
        //ajustando a dimensão da minha tela de login
        protected override Window CreateWindow(IActivationState activation)
        {
            var window = base.CreateWindow(activation);

            window.Width = 400;//largura da tela
            window.Height = 600;//Altura da tela

            return window;


        }
    }//Fecha classe
}//Fecha namespace
