using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace boas_praticas_II_Alura.src.CAP7
{
    public class Pedido
    {
        public string Cliente { get; private set; }

        public double Valor { get; private set; }

        public DateTime DataFinalizacao { get; private set; }

        public Status Status { get; private set; }

        public Pedido(string cliente, double valor, Status status)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.Status = Status.Novo;
        }

        public void Paga()
        {
            this.Status = Status.Pago;
        }

        public void Finalizar()
        {
            this.Status = Status.Entregue;
            this.DataFinalizacao = DateTime.Now;
        }
    }
}