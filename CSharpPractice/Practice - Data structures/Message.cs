using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Practice___Data_structures
{
    public class Message
    {
        public string Sender { get; }
        public string Recipient { get; }
        public string Content { get; }

        public Message(string sender, string recipient, string content)
        {
            Sender = sender;
            Recipient = recipient;
            Content = content;
        }
    }
}
