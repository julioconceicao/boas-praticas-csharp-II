﻿using System;
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
            Historico historico = new Historico();

            Contrato c = new Contrato(DateTime.Now, "Julio", TipoContrato.Novo);

            historico.Adiciona(c.SalvaEstado());

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());

            Console.WriteLine(historico.Pega(1).Contrato.Tipo);
        }
    }
}
