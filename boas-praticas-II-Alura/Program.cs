using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using boas_praticas_II_Alura.src.CAP7;

namespace boas_praticas_II_Alura
{
    class Program
    {
        static void Main(string[] args)
        {
            FilaDeTrabalho fila = new FilaDeTrabalho();
            Pedido pedido1 = new Pedido("Mauricio", 100.0, Status.Novo);
            Pedido pedido2 = new Pedido("Marcelo", 200.0, Status.Novo);

            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));

            fila.Adiciona(new FinalizarPedido(pedido1));
            fila.Adiciona(new FinalizarPedido(pedido2));

            fila.Processa();
        }
    }
}
