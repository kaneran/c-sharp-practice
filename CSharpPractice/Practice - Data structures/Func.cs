using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Practice___Data_structures
{
    public class Func
    {
        public Func<string> michaelRule { get; }

        public string getMichaelRule() => "infinity";

        public Func()
        {
            michaelRule = getMichaelRule;
        }

        public void executeMichaelRule(Func<string> michaelRule)
        {
            var output = michaelRule();
            
            Console.WriteLine($"If the sin of 4v4v4v4 equals 1, then Michael equals {output}! Hahah, this isn't a real equation but a meme from https://www.youtube.com/watch?v=hr3S5sxZIh8&t=62s");
        }
    }
}
