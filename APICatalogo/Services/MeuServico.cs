using APICatalogo.Services;

public class MeuServico : IMeuServico
{
    public string Saudadacao(string nome)
    {
        return $"Bem-vindo, {nome} \n\n {DateTime.UtcNow}";
    }
}