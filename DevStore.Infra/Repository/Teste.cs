using DevStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevStore.Infra.Repository
{
    public class Teste
    {
        public static List<Product> RecuperarProdutos()
        {
            var context = new DataContexts.DevStoreDataContext();

            return context.Products.ToList();
        }
        
    }
}
