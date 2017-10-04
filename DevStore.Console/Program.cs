using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevStore.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = DevStore.Infra.Repository.Teste.RecuperarProdutos();
        }
    }
}
