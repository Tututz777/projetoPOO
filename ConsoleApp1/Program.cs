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
            Console.WriteLine("2 - Gerenciar Pessoas");
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
                        RemoverRoupaMenu();
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
                Console.WriteLine("3 - Voltar");

                opcao = Console.ReadKey();

                switch (opcao.Key)
                {
                    case ConsoleKey.D1:
                        AdicionarPessoaMenu();
                        break;
                    case ConsoleKey.D2:
                        RemoverPessoaMenu();
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

    static void RemoverRoupaMenu()
    {
        Console.Clear();
        Console.WriteLine("Digite o ID da peça que você deseja remover");

        string id = Console.ReadLine();

        Roupa roupa = banco.getRoupas().Find(roupa => roupa.GetID() == id);

        if(roupa == null)
        {
            Console.WriteLine("Roupa não encontrada");
        }

        else
        {
            Console.WriteLine("Roupa removida com sucesso");
            banco.RemoverRoupa(roupa);
        }

    }

    static void AdicionarPessoaMenu()
    {
        Console.Clear();
        Console.WriteLine("Digite o nome da Pessoa:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o CPF:");
        string cpf = Console.ReadLine();
        Console.WriteLine("Digite a idade:");
        int idade = int.Parse(Console.ReadLine());

        Pessoa pessoa = new Pessoa(nome, cpf, idade);
        banco.SalvarPessoa(pessoa);
    } 

    static void RemoverPessoaMenu()
    {
        Console.Clear();
        Console.WriteLine("Digite o cpf da pessoa que você deseja remover:");
        string cpf = Console.ReadLine();

        Pessoa pessoa = banco.getPessoas().Find(pessoa => pessoa.cpf == cpf);

        if (pessoa == null)
        {
            Console.WriteLine("Pessoa não encontrada");
            System.Threading.Thread.Sleep(1000);
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"{pessoa.nome} removido(a) com sucesso");
            banco.RemoverPessoa(pessoa);
            System.Threading.Thread.Sleep(2000);
        }
    }

}