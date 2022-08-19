using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace boas_praticas_II_Alura.src.CAP7
{
    public class PagaPedido : IComando
    {
        private Pedido pedido;
        
        public PagaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }
        public void Executa()
        {
            Console.WriteLine("Pagando pedido de: {0}", pedido.Cliente);
            pedido.Paga();
        }
    }
}