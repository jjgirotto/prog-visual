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
