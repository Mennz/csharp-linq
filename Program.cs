using PedidosLinq;

var pedidos = DadosExemplo.GerarPedidos();

Console.WriteLine($"Total de pedidos: {pedidos.Count}");
