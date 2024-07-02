public class Empresa
{
    List<Funcionario> Funcionarios = new List<Funcionario>();
    
    public void AdicionarFuncionario(Funcionario Funcionario)
    {
        Funcionarios.Add(Funcionario);
    }

    public void RemoverFuncionario(int Matricula)
    {
        foreach (Funcionario funcionario in Funcionarios)
        {
            if (Matricula == funcionario.Matricula)
            {
                Funcionarios.Remove(funcionario);
                System.Console.WriteLine("Funcionario removido");
            }
        }
    }

    public void ExibirFuncionarios()
    {
        foreach(var Funcionario in Funcionarios)
        {
            System.Console.WriteLine($"Os funcionarios da lista atual são: {Funcionario}");
        }
        
    }
}