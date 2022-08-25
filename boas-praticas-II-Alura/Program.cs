using System.Net;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using boas_praticas_II_Alura.src.CAP1;
using boas_praticas_II_Alura.src.CAP2;
using boas_praticas_II_Alura.src.CAP3;

namespace boas_praticas_II_Alura
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpf = "1234";

            EmpresaFacade facade = new EmpresaFacadeSingleton().Instancia;
            Cliente cliente = facade.BuscaCliente(cpf);
            
            var fatura = facade.CriaFatura(cliente, 500);
            facade.GeraCobranca(tipo.Boleto, fatura);

        }
    }
}
