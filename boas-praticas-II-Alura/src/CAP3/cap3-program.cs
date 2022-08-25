// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace boas_praticas_II_Alura.src.CAP3
// {
//     public class cap3-program
//     {
//         static void Main(string[] args)
//         {
//             Historico historico = new Historico();

//             Contrato c = new Contrato(DateTime.Now, "Julio", TipoContrato.Novo);

//             historico.Adiciona(c.SalvaEstado());

//             c.Avanca();
//             historico.Adiciona(c.SalvaEstado());

//             c.Avanca();
//             historico.Adiciona(c.SalvaEstado());

//             Console.WriteLine(historico.Pega(1).Contrato.Tipo);
//         }
//     }
// }