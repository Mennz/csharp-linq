namespace PedidosLinq;

class Pedido
{
    public int Id { get; set; }
    public string Cliente { get; set; }
    public DateTime Data { get; set; }
    public List<ItemPedido> Itens { get; set; }

    public Pedido(int id, string cliente, DateTime data, List<ItemPedido> itens)
    {
        Id = id;
        Cliente = cliente;
        Data = data;
        Itens = itens;
    }

    public decimal Total => Itens.Sum(item => item.Subtotal);
}
