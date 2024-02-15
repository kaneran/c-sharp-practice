using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Practice___Concepts
{
    public class Interfaces
    {
        class NumberGenerator : IRandomisable
        {
            public double GetRandomNumber(double upperBound)
            {
                Random random = new Random();
                return random.NextDouble() * (upperBound);
            }
        }

        interface IRandomisable
        {
            double GetRandomNumber(double upperBound);
        }

        public static void Execute()
        {
            var userInput = "";
            var numberGenerator = new NumberGenerator();

            do
            {
                Console.WriteLine("Enter a number for the upper bound:");
                userInput = Console.ReadLine();
                if(Double.TryParse(userInput, out double result))
                {
                    var randomNumber = numberGenerator.GetRandomNumber(result);
                    Console.WriteLine("Random number between 0 and upper bound: {0}", randomNumber);
                }
            } while (!userInput.Equals("exit",StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
