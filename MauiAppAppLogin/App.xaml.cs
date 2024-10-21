
namespace MauiAppAppLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            string? usuario_logado = null;

            Task.Run(async () =>
            {
                usuario_logado = await SecureStorage.Default.GetAsync("usuario_logado");
                
                if (usuario_logado == null) 
                {
                    MainPage = new Login();

                }else 
                {
                    MainPage = new Protegida();
                }
            });

            MainPage = new Login();// Alterando new AppShell e Adicionando tela inicial como new Login
        }
        //ajustando a dimensão da minha tela de login
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
        
        
            window.Width = 400;//largura da tela
            window.Height = 600;//Altura da tela

            return window;


        }
    }//Fecha classe
}//Fecha namespace
