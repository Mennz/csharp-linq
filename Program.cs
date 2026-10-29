using PedidosLinq;

var pedidos = DadosExemplo.GerarPedidos();

Console.WriteLine($"Total de pedidos: {pedidos.Count}");

// Where filtra, Select projeta so o que interessa
var pedidosGrandes = pedidos.Where(p => p.Total > 200).Select(p => p.Id);
Console.WriteLine("Pedidos acima de 200: " + string.Join(", ", pedidosGrandes));

var clientes = pedidos.Select(p => p.Cliente).Distinct();
Console.WriteLine("Clientes: " + string.Join(", ", clientes));

var pedidosPorData = pedidos.OrderBy(p => p.Data);
Console.WriteLine("\nPedidos em ordem de data:");
foreach (var p in pedidosPorData)
{
    Console.WriteLine($"  #{p.Id} {p.Data:dd/MM} {p.Cliente} - R$ {p.Total}");
}

var faturamentoTotal = pedidos.Sum(p => p.Total);
var ticketMedio = pedidos.Average(p => p.Total);
Console.WriteLine($"\nFaturamento total: R$ {faturamentoTotal}");
Console.WriteLine($"Ticket medio: R$ {ticketMedio:F2}");
