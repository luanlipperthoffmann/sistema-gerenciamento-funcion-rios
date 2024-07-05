public class FuncionarioTempoIntegral : Funcionario, IBonus
{
    private double Salario;
    public FuncionarioTempoIntegral(string Nome, int Matricula, double Salario) : base(Nome, Matricula)
    {
        this.Salario = Salario;
    }

    public override double CalcularSalario()
    {
        return Salario;
    }

    public override void ExibirInformacoes()
    {
        System.Console.WriteLine($"Nome: {Nome}; \nMatricula: {Matricula}; \nSálario: {Salario}");
    }
    
    public double CalcularBonus()
    {
        return Salario*0.1;
    }
}