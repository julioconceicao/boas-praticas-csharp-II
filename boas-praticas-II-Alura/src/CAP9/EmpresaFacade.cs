using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace boas_praticas_II_Alura.src.CAP9
{
    public class EmpresaFacade
    {
        public Cliente BuscaCliente(string cpf)
        {
            return new ClienteDAO().BuscaPorCpf(cpf);
        }

        public Fatura CriaFatura(Cliente cliente, double valor)
        {
            return new Fatura(cliente, valor);
        }

        public Cobranca GeraCobranca(Tipo tipo, Fatura fatura)
        {
            GeraCobranca cobranca = new Cobranca(tipo, fatura);
            cobranca.Emite();
        }
    
        public ContatoCliente FazContato(Cliente cliente, Cobranca cobranca)
        {
            ContatoCliente contato = new ContatoCliente(cliente, cobranca);
            contato.Dispara();
            return contato;
        }    
    }
}