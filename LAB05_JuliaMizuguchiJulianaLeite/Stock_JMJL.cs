using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB05_JuliaMizuguchiJulianaLeite
{
    internal class Stock_JMJL : Dictionary<Product_JMJL, int>
    {


        public void Venda_JMJL(Product_JMJL product_JMJL, int quantidade_JMJL)
        {
            this[product_JMJL] -= quantidade_JMJL;
            product_JMJL.UnitsInStock_JMJL -= quantidade_JMJL;
        }
    }
}
