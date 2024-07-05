using System.ComponentModel.Design;

Empresa empresa = new Empresa();

bool Menu = true;
while (Menu)
{
    System.Console.WriteLine("");
    System.Console.WriteLine("SISTEMA DE GERENCIAMENTO DE FUNCIONÁRIOS");
    System.Console.WriteLine("SELECIONE A OPÇÃO DESEJADA:");
    System.Console.WriteLine("1. Adicionar um funcionário de tempo integral");
    System.Console.WriteLine("2. Adicionar um funcionário de meio periodo");
    System.Console.WriteLine("3. Remover um funcionário");
    System.Console.WriteLine("4. Exibir  informações de todos os funcionários");
    System.Console.WriteLine("5. Adicionar projeto(s) a um funcionário");
    System.Console.WriteLine("6. Sair do programa");
    System.Console.WriteLine("Selecione a opção desejada:");
    int opcao = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("");

    if  (opcao>=1 && opcao<=6)
    {
        switch (opcao)
        {
            case 1:
                System.Console.Write("Informe o nome do funcionário de tempo integral: ");
                string Nome = Console.ReadLine();
                System.Console.Write("Informe a matricula do funcionário de tempo integral: ");
                int Matricula = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("Informe o sálario do funcionário de tempo integral: ");
                double SalarioMensal = Convert.ToInt32(Console.ReadLine());
                Funcionario funcionario = new FuncionarioTempoIntegral(Nome, Matricula, SalarioMensal);
                empresa.AdicionarFuncionario(funcionario);
                break;
            case 2:
                System.Console.Write("Informe o nome do funcionário de meio periodo: ");
                string NomeMeioPeriodo = Console.ReadLine();
                System.Console.Write("Informe a matricula do funcionário de meio periodo: ");
                int MatriculaMeioPeriodo = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("Informe o sálario por hora do funcionário de meio periodo: ");
                double SalarioHora = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("Informe o número de horas trabalhadas do funcionário de meio periodo: ");
                double HorasTrabalhadas = Convert.ToInt32(Console.ReadLine());
                Funcionario funcionarioMeioPeriodo = new FuncionarioMeioPeriodo(NomeMeioPeriodo, MatriculaMeioPeriodo, SalarioHora, HorasTrabalhadas);
                empresa.AdicionarFuncionario(funcionarioMeioPeriodo);
                break;
            case 3:
                System.Console.Write("Informe o número da matricula do fúncionario a ser removido: ");
                int matriculaRemovida = Convert.ToInt32(Console.ReadLine());
                empresa.RemoverFuncionario(matriculaRemovida);
                break;
            case 4:
                empresa.ExibirFuncionarios();
                break;
            case 5:
                System.Console.Write("Informe o nome do novo projeto: ");
                string projeto = Console.ReadLine();
                System.Console.Write("Informe o nome do funcionario ao qual deseja adicionar o projeto: ");
                Nome = Console.ReadLine();
                break;
            case 6:
                Menu = false;
                break;
        }
    }
    else 
        System.Console.WriteLine("Opção Inválida!");
}