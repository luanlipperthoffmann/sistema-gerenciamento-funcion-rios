Empresa empresa = new Empresa();


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

switch (opcao >=1 || opcao <=6)
{
    case 1:
        System.Console.WriteLine("Informe o nome do funcionário:");
        string Nome = Console.ReadLine();
        System.Console.WriteLine("Informe a matricula do funcionário:");
        int Matricula = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Informe o sálario do funcionário:");
        double SalarioMensal = Convert.ToInt32(Console.ReadLine());
        Funcionario funcionario = new FuncionarioTempoIntegral(Nome, Matricula, SalarioMensal);
        empresa.AdicionarFuncionario(funcionario);
        
    case 2:

    case 3:

    case 4:

    case 5:

    case 6:

}
