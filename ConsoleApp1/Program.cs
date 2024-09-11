class Program
{

    static ConsoleKeyInfo opcao = new ConsoleKeyInfo();
    static BancoDeDados banco = new BancoDeDados();
    static void Main()
    {
        while (opcao.Key != ConsoleKey.Escape)
        {
            Console.Clear();
            Console.WriteLine("Bem vindo! ao melhor brechó do Brasil!");
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Gerenciar Roupas");
            Console.WriteLine("ESC - Sair");

            opcao = Console.ReadKey();

            if (opcao.Key == ConsoleKey.D1)
            {
                Console.Clear();
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Adicionar Roupa");
                Console.WriteLine("2 - Remover Roupa");
                Console.WriteLine("3 - Listar Roupas");
                Console.WriteLine("4 - Voltar");

                opcao = Console.ReadKey();

                switch (opcao.Key)
                {
                    case ConsoleKey.D1:
                        AdicionarRoupaMenu();
                        break;
                    case ConsoleKey.D2:
                        //RemoverCarroMenu();
                        break;
                    case ConsoleKey.D3:
                        banco.ListarRoupas();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                        break;
                }

            }
            else if (opcao.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Adicionar pessoa");
                Console.WriteLine("2 - Remover pessoa");
                Console.WriteLine("3 - Listar Pessoas");
                Console.WriteLine("4 - Voltar");

                opcao = Console.ReadKey();

                switch (opcao.Key)
                {
                    case ConsoleKey.D1:
                        //AdicionarPessoaMenu();
                        break;
                    case ConsoleKey.D2:
                        //RemoverPessoaMenu();
                        break;
                    case ConsoleKey.D3:
                        banco.ListarRoupas();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                        break;
                }
            }
        }
    }

    static void AdicionarRoupaMenu()
    {
        Console.Clear();
        Console.WriteLine("Digite a marca da roupa:");
        string marca = Console.ReadLine();
        Console.WriteLine("Digite o tipo de roupa:");
        string tipo = Console.ReadLine();
        Console.WriteLine("Digite a quantidade de peças disponiveis:");
        int quantidade = int.Parse(Console.ReadLine());

        Roupa roupa = new Roupa(marca, tipo, quantidade);
        banco.SalvarRoupa(roupa);
    }

}