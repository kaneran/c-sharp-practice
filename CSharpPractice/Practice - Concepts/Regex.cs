using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpPractice.Practice___Concepts
{
    public static class Regex
    {
        public static void Execute()
        {
            Console.WriteLine("Please enter a date in US format MM/DD/YYYY");
            var userInput = Console.ReadLine();
            if(DateOnly.TryParse(userInput, out var date))
            {
                //Execute a regex to see if the date is in US format
                var regex = new System.Text.RegularExpressions.Regex(@"(0[1-9]|1[1,2])\/(0[1-9]|[12][0-9]|3[01])\/(19|20)\d{2}");
                //var output = regex.Replace(userInput, new MatchEvaluator(FormatDate));

                if (regex.IsMatch(userInput))
                {
                    var usDate = userInput;
                    var pieces = usDate.Split('/');
                    string day = pieces[1], month = pieces[0], year = pieces[2];
                    Console.WriteLine($"{day}-{month}-{year} - EU Date");
                }
               
                else
                {
                    Console.WriteLine($"The date entered wasn't in US format");
                }
            }
            else
            {
                Console.WriteLine("That's not a valid date");
            }
        }

        private static string FormatDate(Match match)
        {
            if (match.Success)
            {
                var usDate = match.Value;
                var pieces = usDate.Split('/');
                string day = pieces[1], month = pieces[0], year = pieces[2];
                return $"{day}-{month}-{year}";
            } else
            {
                return "";
            }
        }
    }
}
