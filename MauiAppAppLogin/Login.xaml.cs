namespace MauiAppAppLogin;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {

		try
		{

			List<DadosUsuario> lista_usuarios = new List<DadosUsuario>() //Definir a lista de usuario no Array de objeto
			{
				new DadosUsuario() // posição 1 daa lista
				{
					Usuario = "jose",// Primeiro usuario
					Senha = "123"
				},
				new DadosUsuario() // Posição 2 
				{
                    Usuario = "maria",//Usuario 2
					Senha = "321"
				}
			};

			DadosUsuario dados_digitados = new DadosUsuario()// Objeto criado Dados digitados pelo usuario
			{
				Usuario = txt_usuario.Text,// dados digitados do Entry
				Senha = txt_senha.Text // dados digitados do Entry
			};

			//LINQ
			//IF  "i=> Para cada" item da lista eu vou verifica se o que foi digitado como usuario e senha exite em algum item da lista
			if (lista_usuarios.Any(
				i => (dados_digitados.Usuario == i.Usuario && dados_digitados.Senha == i.Senha) ))
			{
				await SecureStorage.Default.SetAsync("usuario_logado", dados_digitados.Usuario);

				App.Current.MainPage = new Protegida();

			}
			else 
			{
				throw new Exception("Usuário ou senha incorretos.");
			}
		

		}
		catch (Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "Fechar");

		}
    }
}