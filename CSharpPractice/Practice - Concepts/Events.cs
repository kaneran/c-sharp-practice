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
    }
}
