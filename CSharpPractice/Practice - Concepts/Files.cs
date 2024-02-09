using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Practice___Concepts
{
    public static class Files
    {
        public static void CreateFile(string fileName)
        {
            string[] trades = new string[] { "Apple : 1000", "Google : 15000" };
            if(!File.Exists(fileName))
            {
                File.Create(fileName);
            }

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine($"{"Name",-7} {"Amount",7}");
                foreach (var trade in trades)
                {
                    var data = trade.Split(':');
                    sw.WriteLine($"{data[0], -7} {data[1], 7}");
                }
            }
        }
    }
}
