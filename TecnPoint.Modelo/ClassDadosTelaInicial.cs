namespace TecnPoint.Modelo.ClassDadosTelaInicial;

public class ClassDadosTelaInicial
{
    private string _nome;
    private string _email;

    public ClassDadosTelaInicial(string nome, string email) 
    {
        _email = email;
        _nome = nome;
    }

    public string Nome 
    {
        get { return _nome; }
        set { _nome = value; }
    }
    public string Email 
    {
        get { return _email; }
        set { _email = value; }
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Nome: {_nome}\nEmail: {_email}");
    }
}


