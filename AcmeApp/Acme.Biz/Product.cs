using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    class Product
    {
        public Product()
        {
            string[] colorOptions = { "Red", "Espresso", "White", "Navy" };
            var redIndex = Array.IndexOf(colorOptions, "Red");
            colorOptions.SetValue("Blue", 3);
        }

        public Product(int productId, 
                       string productName,
                       string description): this()
        {

        }
    }
}
