using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace boas_praticas_II_Alura.src.CAP7
{
    public class FinalizarPedido : IComando
    {
        private Pedido pedido;
        public FinalizarPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }
        public void Executa()
        {
            Console.WriteLine("Finalizando pedido de: {0}", pedido.Cliente);
            pedido.Finalizar();
        }
    }
}