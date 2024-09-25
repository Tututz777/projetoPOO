class BancoDeDados
{
    List<Roupa> roupas = new List<Roupa>();
    List<Pessoa> pessoas = new List<Pessoa>();

    public BancoDeDados()
    {
        Roupa roupas = new Roupa("Teaser", "Camisa", 3);
    }

    public void SalvarRoupa(Roupa roupa)
    {
        roupas.Add(roupa);
    }

    public void RemoverRoupa(Roupa roupa)
    {
        roupas.Remove(roupa);
    }

    public void ListarRoupas()
    {
        Console.Clear();
        for (int i = 0; i < roupas.Count; i++)
        {
            Console.WriteLine("Roupa " + (i + 1));
            Console.WriteLine("Marca: " + roupas[i].marca);
            Console.WriteLine("Tipo: " + roupas[i].tipo);
            Console.WriteLine("Quantidade: " + roupas[i].quantidade);
            Console.WriteLine("ID: " + roupas[i].GetID());
            Console.WriteLine();
        }
    }

    public void SalvarPessoa(Pessoa pessoa)
    {
        pessoas.Add(pessoa);
    }

    public void RemoverPessoa(Pessoa pessoa)
    {
        pessoas.Remove(pessoa);
    }
    
    public List<Roupa> getRoupas()
    {
        return roupas;
    }

    public List<Pessoa> getPessoas()
    {
        return pessoas;
    }
}