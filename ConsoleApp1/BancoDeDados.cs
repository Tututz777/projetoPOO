class BancoDeDados
{
    List<Roupa> roupas = new List<Roupa>();

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
    /*public List<Carro> getCarros()
    {
        return carros;
    }
    */
}