// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace boas_praticas_II_Alura.src.CAP1
// {
//     static void Main(string[] args)
//     {
//         //Chama a conexão com o Database através da classe ConnectionFactory
//         IDbConnection conexao = new ConnectionFactory().GetConnection();

//         IDbCommand comando = conexao.CreateCommand();
//         comando.CommandText = "select * from tabela ";

//     }
// }