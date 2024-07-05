public class Empresa
{
    List<Funcionario> Funcionarios = new List<Funcionario>();
    
    public void AdicionarFuncionario(Funcionario Funcionario)
    {
        Funcionarios.Add(Funcionario);
    }

    public void RemoverFuncionario(int Matricula)
    {
        for (int i=0; i <Funcionarios.Count; i++)
        {
            if (Funcionarios [i].Matricula == Matricula)
            {
                Funcionarios.RemoveAt(i);
            }
        }
    }

    public void ExibirFuncionarios()
    {
        System.Console.WriteLine("OS FUNCIONÁRIO DA LISTA ATUAL SÃO:");
        foreach(var Funcionario in Funcionarios)
        {
            System.Console.WriteLine($"Matricula: {Funcionario.Matricula}, Nome: {Funcionario.Nome}, Sálario: {Funcionario.CalcularSalario()}");
        }
    }
}