using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Practice___Data_structures
{
    public static class Tuple
    {
        public static void Test()
        {
            (string, string) tuple1 = ("Hello", "World");
            Console.WriteLine(tuple1.Item1);

            var tuple2 = ( name: "bob", age: 31);
            Console.WriteLine(tuple2.name);

            ValueTuple<string, string> tuple3 = ("Testing", "Tuples!");
            Console.WriteLine(tuple3.Item1);

            (string name, int score, string rank) person = ("Speedy", 99, "Commander");
            Console.WriteLine(person.score);

            //Destructuring
            (string name, int age, string rank) = GetPerson();
            Console.WriteLine("{0} is {1} at {2}", name, rank, age);
        }

        public static (string name, int age, string rank) GetPerson() => (name: "Storm", age: 39, rank:"General");
    }
}
