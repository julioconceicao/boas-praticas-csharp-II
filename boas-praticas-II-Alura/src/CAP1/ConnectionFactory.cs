using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace boas_praticas_II_Alura.src.CAP1
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection conexao = new SqlConnection();
            conexao.ConnectionString = "User Id=root;Password:;Server=localhost;Database=meuBanco";
            conexao.Open();
            
            return conexao;
        }
    }
}