using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace boas_praticas_II_Alura.src.CAP3
{
    public class Estado
    {
        public Contrato Contrato {get; private set;}

        public Estado (Contrato contrato)
        {
            this.Contrato = contrato;
        }
    }
}