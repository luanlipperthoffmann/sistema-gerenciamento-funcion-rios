public class FuncionarioTempoIntegral : Funcionario
{
    private double SalarioMensal;
    public new string Nome;
    public new int Matricula;

    public FuncionarioTempoIntegral(string Nome, int Matricula, double SalarioMensal) : base(Nome, Matricula)
    {
        this.Nome = Nome;
        this.Matricula = Matricula;
        this.SalarioMensal = SalarioMensal;
    }

    public new double CalcularSalario()
    {
        return SalarioMensal;
    }

    public new void ExibirInformacoes()
    {
        System.Console.WriteLine($"Nome: {Nome}; \nMatricula: {Matricula}; \nSálario: {SalarioMensal}");
    }
    
    public double CalcularBonus()
    {
        return SalarioMensal*0.1;
    }
}