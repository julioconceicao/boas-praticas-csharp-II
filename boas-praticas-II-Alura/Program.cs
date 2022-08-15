using System;
using System.Data;
using System.Data.SqlClient;
using boas_praticas_II_Alura.src.CAP1;

namespace boas_praticas_II_Alura
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chama a conexão com o Database através da classe ConnectionFactory
            IDbConnection conexao = new ConnectionFactory().GetConnection();
            
            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "select * from tabela ";

        }
    }
}
