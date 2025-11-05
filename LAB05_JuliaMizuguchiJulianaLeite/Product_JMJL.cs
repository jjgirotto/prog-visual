using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB05_JuliaMizuguchiJulianaLeite
{
    public class Product_JMJL
    {
        public int ProductId_JMJL { get; set; }
        public string ProductName_JMJL { get; set; }
        public string Category_JMJL { get; set; }
        public decimal UnitPrice_JMJL { get; set; }
        public int UnitsInStock_JMJL { get; set; }

        
        public override bool Equals(Object obj)
        {
            //Is null (como o objeto que invoca não pode ser null)
            if (Object.ReferenceEquals(null, obj))
            {
                return false;
            }
            //Is the same object
            if (Object.ReferenceEquals(this, obj))
            {
                return true;
            }
            // Not same type
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            //Is the same type -> podemos fazer cast seguro
            Product_JMJL p = obj as Product_JMJL;
            return int.Equals(ProductId_JMJL, p.ProductId_JMJL);
        }

        public override int GetHashCode()
        {
            return ProductId_JMJL.GetHashCode();
        }

        override
            public string ToString()
        {
            return "ID: " + ProductId_JMJL +
                   ", Name: " + ProductName_JMJL +
                   ", Category: " + Category_JMJL +
                   ", Price: " + UnitPrice_JMJL +
                   ", Stock: " + UnitsInStock_JMJL;
        }
    }
}
