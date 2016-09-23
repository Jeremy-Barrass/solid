﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingOpenClosedPrinciple
{
    class ProductConsole
    {
        public static void Main()
        {
            var product1 = new Product(4.52m);
            var product2 = new FeaturedProduct(3.99m);

            var products = new List<Product>();

            products.Add(product1);
            products.Add(product2);

            foreach (Product product in products)
            {
                product.Render();
            }


            Console.WriteLine("FINISHED......press any key");
            Console.ReadKey();
        
        }
    }
}
