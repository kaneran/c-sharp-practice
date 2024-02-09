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
        //n = 1,  print 1
        //n = 2,  print 1, 10
        //n = 4,  print 1, 10 , 11 , 100
        //n = 5,  print 1, 10 , 11, 100, 101, 110, 111
        //pattern, after adding current number, the next number would add a 0 and then the number after that would add a 1
        //i.e if current number was 101 then the next numbers would be 110 and 1011
        //i.e 110 , next numbers would be 1100 and 1101

        public void PrintBinaryNumbers(int n)
        {
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(1);
            for(int i = 0; i < n; i++)
            {
                var number = numbers.Dequeue();
                Console.WriteLine(number);
                numbers.Enqueue(number * 10);
                numbers.Enqueue((number * 10)+ 1);
            }

        }
    }
}
