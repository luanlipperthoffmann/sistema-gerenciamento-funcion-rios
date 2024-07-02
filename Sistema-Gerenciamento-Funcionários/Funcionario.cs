public abstract class Funcionario
{
    public string Nome;
    public int Matricula;
    public double Salario;

    public Funcionario(string Nome, int Matricula)
    {
        this.Nome = Nome;
        this.Matricula = Matricula;
    }

    public double CalcularSalario()
    {
        return Salario;
    }

    public void ExibirInformacoes()
    {
        System.Console.WriteLine($"Nome: {Nome}; \nMatricula: {Matricula}; \nSálario: {Salario}");
    }

    public void AdicionarProjeto()
    {
        List<string> Projeto = new List<string>();
    }
}