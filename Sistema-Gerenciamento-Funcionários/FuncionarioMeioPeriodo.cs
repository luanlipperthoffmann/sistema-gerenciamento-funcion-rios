public class FuncionarioMeioPeriodo : Funcionario
{
    private double SalarioHora;
    private double HorasTrabalhadas;
    public new string Nome;
    public new int Matricula;
    public FuncionarioMeioPeriodo(string Nome, int Matricula, double SalarioHora, double HorasTrabalhadas) : base(Nome, Matricula)
    {
        this.Nome = Nome;
        this.Matricula = Matricula;
        this.SalarioHora = SalarioHora;
        this.HorasTrabalhadas = HorasTrabalhadas;
    }

    public new double CalcularSalario()
    {
        return SalarioHora*HorasTrabalhadas;
    }

    public new void ExibirInformacoes() 
    {
        System.Console.WriteLine($"Nome: {Nome}; \nMatricula: {Matricula}; \nSálario por Hora: {SalarioHora}; \nHoras Trabalahadas: {HorasTrabalhadas}");
    }

    public double CalcularBonus()
    {
        return CalcularBonus()*0.05;
    }
}