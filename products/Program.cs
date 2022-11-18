using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<products> products = new List<products>
            { 
                new products("Chicken","450",10, 14),
                new products("Cucumber","90",5,2),
                new products("Tomatoes","110",10, 9),
                new products("Coca-cola","150",12,13),
                new products($"Apple","75",38,15),
            };
            var first = products.Where(item => item.dodo>=item.expirationdate).ToList();
            foreach(var item in first)
            {
                Console.WriteLine($"Cрок годности истек у: {item.name}");

            }
            Console.ReadKey();
        }
    }
}
