// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace boas_praticas_II_Alura.src.CAP2
// {
//     public class cap2-program
//     {
//                 static void Main(string[] args)
//         {
//             NotasMusicais notas = new NotasMusicais();

//             IList<INota> musica = new List<INota>(){
//             notas.Pega("do"),
//             notas.Pega("re"),
//             notas.Pega("mi"),
//             notas.Pega("fa"),
//             notas.Pega("pausa"),
//             notas.Pega("fa"),
//             notas.Pega("fa"),
            
            
//             notas.Pega("pausa"),

//             notas.Pega("do"),
//             notas.Pega("re"),
//             notas.Pega("do"),
//             notas.Pega("re"),
//             notas.Pega("pausa"),
//             notas.Pega("re"),
//             notas.Pega("re"),
//             notas.Pega("pausa"),

//             notas.Pega("do"),
//             notas.Pega("sol"),
//             notas.Pega("fa"),
//             notas.Pega("mi"),
//             notas.Pega("pausa"),
//             notas.Pega("mi"),
//             notas.Pega("mi"),
//             notas.Pega("pausa"),

//             notas.Pega("do"),
//             notas.Pega("re"),
//             notas.Pega("mi"),
//             notas.Pega("fa"),
//             notas.Pega("pausa"),
//             notas.Pega("fa"),
//             notas.Pega("fa")

//             };
//             Piano piano = new Piano();
//             piano.Toca(musica);
//         }
//     }
// }