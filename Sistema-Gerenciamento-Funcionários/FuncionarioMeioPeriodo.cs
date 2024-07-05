public class FuncionarioMeioPeriodo : Funcionario
{
    public double SalarioHora;
    public double HorasTrabalhadas;
    public FuncionarioMeioPeriodo(string Nome, int Matricula, double SalarioHora, double HorasTrabalhadas) : base(Nome, Matricula)
    {
        this.SalarioHora = SalarioHora;
        this.HorasTrabalhadas = HorasTrabalhadas;
    }

    public override double CalcularSalario()
    {
        return SalarioHora*HorasTrabalhadas;
    }

    public override void ExibirInformacoes() 
    {
        System.Console.WriteLine($"Nome: {Nome}; \nMatricula: {Matricula}; \nSálario: {SalarioHora}");
    }

    public double CalcularBonus()
    {
        return CalcularSalario()*0.05;
    }
}