namespace CSharpPractice.Practice___Data_structures
{
    public class Queue
    {
        private Queue<Message> _messageQueue;

        public Queue()
        {
            _messageQueue = new Queue<Message>();
        }
        public void SendMessage(Message message)
        {
            _messageQueue.Enqueue(message);
        }

        public void SendMessagesToMe()
        {
            var message1 = new Message("Oli", "Kane", "Hey man");
            var message2 = new Message("Justin", "Kane", "Hi there!");
            var message3 = new Message("Nathan", "Kane", "Youtube videos are great for learning!");
            SendMessage(message1);
            SendMessage(message2);
            SendMessage(message3);
        }

        public void PrintMessages()
        {
            foreach(var message in _messageQueue)
            {
                Console.WriteLine($"Message received from {message.Sender}");
            }
        }

        public void ReadMessages()
        {
            //I know this can be achieved with a foreach loop but just wanted to try recursion
            if(_messageQueue.Count != 0) {
                var earliestMessage = _messageQueue.Dequeue();
                Console.WriteLine($"Read message saying \"{earliestMessage.Content}\" from {earliestMessage.Sender}");
                ReadMessages();
            }
        }
    }
}
