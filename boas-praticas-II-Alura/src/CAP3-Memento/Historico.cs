using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace boas_praticas_II_Alura.src.CAP3
{
    public class Historico
    {
        private IList<Estado> Estados = new List<Estado>();

        public void Adiciona (Estado estado)
        {
            this.Estados.Add(estado);
        }
        public Estado Pega(int indice)
        {
            return Estados[indice]
;        }
    }
}