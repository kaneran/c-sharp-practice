using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Practice___Concepts
{
    public static class Events
    {
        private static event Action<string> bookedPlaneTicket; 

        private static void bookPlaneSeat(string test)
        {
            Console.WriteLine("Booking plane seat.." + test);
        }

        private static void offerDiscount(string test) {
            Console.WriteLine("Here's a discount! " + test);
        }

        public static void TestEvent()
        {
            bookedPlaneTicket += bookPlaneSeat;
            bookedPlaneTicket.DynamicInvoke("for user xyz");
            bookedPlaneTicket -= bookPlaneSeat;
        }


        private delegate void DepositAdded(decimal amount);

        private static event DepositAdded depositAddedEvent;

        public static void PiggyBankChallenge() {
            decimal currentAmount = 0;
            string userInput = "";
            //depositAddedEvent += new DepositAdded(updatePiggyBank);
            //depositAddedEvent += new DepositAdded(checkPiggyBankBalance);

            depositAddedEvent += (amount) => Console.WriteLine("Balance amount is: {0}", amount);

            depositAddedEvent += (amount) => { if (amount >= 500) Console.WriteLine("You reached the goal of £500"); };


            do
            {
                Console.WriteLine("Enter an amount to deposit");
                var amount = Console.ReadLine();
                userInput = amount;
                if(!userInput.Equals("exit")){
                    currentAmount += decimal.Parse(amount);
                    depositAddedEvent(currentAmount);
                }
                
            } while (!userInput.Equals("exit"));
        }

        public static void updatePiggyBank(decimal amount)
        {
            Console.WriteLine("Balance amount is: {0}", amount);
        }

        public static void checkPiggyBankBalance(decimal amount)
        {
            if (amount >= 500)
            {
                Console.WriteLine("You reached the goal of £500");
            }
        }
    }
}
