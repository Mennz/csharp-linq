using PedidosLinq;

var pedidos = DadosExemplo.GerarPedidos();

Console.WriteLine($"Total de pedidos: {pedidos.Count}");

// Where filtra, Select projeta so o que interessa
var pedidosGrandes = pedidos.Where(p => p.Total > 200).Select(p => p.Id);
Console.WriteLine("Pedidos acima de 200: " + string.Join(", ", pedidosGrandes));

var clientes = pedidos.Select(p => p.Cliente).Distinct();
Console.WriteLine("Clientes: " + string.Join(", ", clientes));
