public abstract class Funcionario
{
    public string Nome;
    public int Matricula;

    public Funcionario(string Nome, int Matricula)
    {
        this.Nome = Nome;
        this.Matricula = Matricula;
    }

    public abstract double CalcularSalario();

    public abstract void ExibirInformacoes();

    public static string AdicionarProjeto(string Projeto)
    {
        List<string> Projetos = new List<string>();
        Projetos.Add(Projeto);
        return "Pojeto Adicionado com Sucesso";
    }
    public static string AdicionarProjeto(List<string> Projetos)
    {
        List<string> Projeto = new List<string>();
        Projeto.Add(Projetos.ToString());
        return "Pojeto Adicionado com Sucesso";
    }
}