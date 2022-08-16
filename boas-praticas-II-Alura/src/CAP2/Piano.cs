using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace boas_praticas_II_Alura.src.CAP2
{
    public class Piano
    {
        public void Toca(IList<INota> musica)
        {
            foreach(var nota in musica)
            {
                Console.Beep(nota.Frequencia, 200);
            }
        }
    }
}