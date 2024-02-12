using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Practice___Concepts
{
    public static class Delegates
    {
        public delegate double ShippingPrice(double price);

        public static void Execute()
        {
            ShippingPrice zone1 = delegate (double price)
            {
                return Math.Round(price * 0.25,2);
            };
            ShippingPrice zone2 = delegate (double price)
            {
                return Math.Round(price * 0.12 + 25,2);
            };

            ShippingPrice zone3 = delegate (double price)
            {
                return Math.Round(price * 0.08,2);
            };
            ShippingPrice zone4 = delegate (double price)
            {
                return Math.Round(price * 0.04 + 25, 2);
            };

            bool doExit = false;
            while (!doExit)
            {
                Console.WriteLine("What is the destination zone?");
                var zone = Console.ReadLine();
                if (!zone.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("What is the item price?");
                    var price = Double.Parse(Console.ReadLine());
                    var shippingPrice = zone switch
                    {
                        "zone1" => zone1(price),
                        "zone2" => zone2(price),
                        "zone3" => zone3(price),
                        "zone4" => zone4(price),
                        _ => 0
                    };

                    Console.WriteLine($"The shipping fees are: {shippingPrice}");
                }
                else {
                    doExit = !doExit;
                }
            }
        }
    }
}
