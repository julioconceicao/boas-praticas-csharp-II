using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace boas_praticas_II_Alura.src.CAP9
{
    public class EmpresaFacadeSingleton
    {
        private static EmpresaFacade facade = new EmpresaFacade();

        public EmpresaFacade Instancia
        {
            get{
                return facade;
            }
        }
    }
}