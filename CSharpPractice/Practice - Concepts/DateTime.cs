using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Practice___Concepts
{
    public static class DateTime
    {
        public static void Execute() {
            Console.WriteLine("Enter a date");
            var userInput = Console.ReadLine();
            
            if(System.DateTime.TryParse(userInput, out var date))
            {
                var dateNow = System.DateTime.Today;
                var difference = dateNow - date;
                var message = difference.Days switch
                {
                    0 => "That day is today!",
                    <0 => $"{date.ToString("d")} will be in {Math.Abs(difference.Days)} days",
                    _ => $"{date.ToString("d")} was {difference.Days} days ago"
                };
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("Data invalid....");
            }

            if (userInput != "exit")
            {
                Execute();
            }
            
        }
    }
}
