namespace PedidosLinq;

class ItemPedido
{
    public string Produto { get; set; }
    public int Quantidade { get; set; }
    public decimal PrecoUnitario { get; set; }

    public ItemPedido(string produto, int quantidade, decimal precoUnitario)
    {
        Produto = produto;
        Quantidade = quantidade;
        PrecoUnitario = precoUnitario;
    }

    public decimal Subtotal => Quantidade * PrecoUnitario;
}
