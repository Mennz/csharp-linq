namespace PedidosLinq;

static class DadosExemplo
{
    public static List<Pedido> GerarPedidos()
    {
        return new List<Pedido>
        {
            new Pedido(1, "Ana", new DateTime(2026, 9, 2), new List<ItemPedido>
            {
                new ItemPedido("Teclado", 1, 150m),
                new ItemPedido("Mouse", 2, 60m),
            }),
            new Pedido(2, "Bruno", new DateTime(2026, 9, 5), new List<ItemPedido>
            {
                new ItemPedido("Monitor", 1, 900m),
            }),
            new Pedido(3, "Ana", new DateTime(2026, 9, 10), new List<ItemPedido>
            {
                new ItemPedido("Mouse", 1, 60m),
                new ItemPedido("Mousepad", 3, 25m),
            }),
            new Pedido(4, "Carla", new DateTime(2026, 9, 12), new List<ItemPedido>
            {
                new ItemPedido("Teclado", 2, 150m),
                new ItemPedido("Monitor", 1, 900m),
            }),
            new Pedido(5, "Bruno", new DateTime(2026, 9, 15), new List<ItemPedido>
            {
                new ItemPedido("Mousepad", 1, 25m),
            }),
            new Pedido(6, "Daniel", new DateTime(2026, 9, 20), new List<ItemPedido>
            {
                new ItemPedido("Mouse", 3, 60m),
                new ItemPedido("Teclado", 1, 150m),
            }),
            new Pedido(7, "Carla", new DateTime(2026, 9, 22), new List<ItemPedido>
            {
                new ItemPedido("Mousepad", 2, 25m),
            }),
            new Pedido(8, "Ana", new DateTime(2026, 9, 28), new List<ItemPedido>
            {
                new ItemPedido("Monitor", 2, 900m),
            }),
        };
    }
}
