using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Practice___Data_structures
{
    public class LinkedList
    {
        private LinkedList<string> _londonBridgesList;

        public LinkedList()
        {
            _londonBridgesList = new LinkedList<string>();
        }

        public void PopulateLondonBridgeList()
        {
            _londonBridgesList.AddFirst("London Bridge");
            _londonBridgesList.AddFirst("Southwark Bridge");
            _londonBridgesList.AddFirst("Blackfriars Bridge");
            _londonBridgesList.AddFirst("Waterloo Bridge");
        }

        public void AddBridge(string bridge)
        {
            var firstBridge = _londonBridgesList.First();
            LinkedListNode<string> node = _londonBridgesList.Find(firstBridge);
            _londonBridgesList.AddBefore(node, bridge);
        }

        public void PrintLondonBridgeList()
        {
            foreach(var bridge in _londonBridgesList)
            {
                Console.WriteLine(bridge);
            }
        }
    }
}
