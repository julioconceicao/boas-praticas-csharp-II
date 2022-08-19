using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace boas_praticas_II_Alura.src.CAP2
{
    public class NotasMusicais
    {
        private static IDictionary<string, INota> notas = new Dictionary<string, INota>(){
            {"do", new Do()},
            {"re", new Re()},
            {"mi", new Mi()},
            {"fa", new Fa()},
            {"sol", new Sol()},
            {"la", new La()},
            {"si", new Si()},
            {"pausa", new Pausa()}

        };
        public INota Pega(string nome)
        {
            return notas[nome];
        }
    }
}