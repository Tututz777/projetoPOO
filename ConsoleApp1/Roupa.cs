class Roupa
{
    public string marca;
    public string tipo;
    public int quantidade;
    private string ID;

    public Roupa(string marca, string tipo, int quantidade)
    {
        this.marca = marca;
        this.tipo = tipo;
        this.quantidade = quantidade;
        ID = Guid.NewGuid().ToString();
    }

    public string GetID()
    {
        return ID;
    }

}