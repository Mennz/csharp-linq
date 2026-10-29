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

var porCliente = pedidos
    .GroupBy(p => p.Cliente)
    .Select(g => new { Cliente = g.Key, Faturamento = g.Sum(p => p.Total) })
    .OrderByDescending(x => x.Faturamento);

Console.WriteLine("\nFaturamento por cliente:");
foreach (var c in porCliente)
{
    Console.WriteLine($"  {c.Cliente}: R$ {c.Faturamento}");
}

var todosItens = pedidos.SelectMany(p => p.Itens);
var produtoMaisVendido = todosItens
    .GroupBy(i => i.Produto)
    .Select(g => new { Produto = g.Key, Quantidade = g.Sum(i => i.Quantidade) })
    .OrderByDescending(x => x.Quantidade)
    .First();

Console.WriteLine($"\nProduto mais vendido: {produtoMaisVendido.Produto} ({produtoMaisVendido.Quantidade} unidades)");
