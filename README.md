# Pedidos LINQ

Programa de console em C# que simula uma lista de pedidos (cada um com cliente, data
e uma lista de itens) e usa LINQ para tirar informações dela: faturamento total,
ticket médio, faturamento por cliente e o produto mais vendido.

## O que pratiquei

- `Where` e `Select` para filtrar e projetar
- `OrderBy` / `OrderByDescending` para ordenar
- `Sum`, `Average` e `First` para agregações simples
- `GroupBy` para agrupar pedidos por cliente e itens por produto
- `SelectMany` para juntar os itens de todos os pedidos numa lista só

## Como rodar

```
dotnet run
```
