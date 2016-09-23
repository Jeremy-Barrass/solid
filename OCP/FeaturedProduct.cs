using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingOpenClosedPrinciple
{
    class FeaturedProduct : Product
    {
        public override void Render()
        {
            Console.WriteLine("******* WOO HOOO *******");
            Console.WriteLine("******* FEATURED PRODUCT HERE **********");
            Console.WriteLine("******* I COST £{0} **********", _price);
        }
    }
}
