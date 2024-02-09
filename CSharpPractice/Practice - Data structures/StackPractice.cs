using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Practice___Data_structures
{
    public static class StackPractice
    {
        //Example arr = [15,8,4,10]
        //Output
        //4 -> 10
        //8 -> 10
        //10 -> -1
        //15 -> -1
        //LIFO
        //when iterating over each number in the array, if the current element is less that the top of the stack then add it
        //any remaining elements in the stack after iterating over the array should be given -1
        //Notes:
        //If the current value in the array is greater than the value of the top of the stack then we have found the next greater value for the top of the stack e.g in the above example, when we iterate over 10 in the array
        //cause 10 is greater than the top of the stack being 4, we now know that 10 is the next number greatest to 4
        public static void PrintNumbersGreaterThanCurentOnTheRightSide(int[] arr)
        {
            //Check if arr has elements
            if(arr.Length == 0) return;


            Stack<int> stack = new Stack<int>();
            stack.Push(arr[0]);

            for (int i =1; i< arr.Length;  i++)
            {
                var next = arr[i];
                if (stack.Count > 0)
                {
                    int popped = stack.Pop();
                    while (popped < arr[i])
                    {
                        Console.WriteLine($"{popped} --> {arr[i]}");
                        if (stack.Count == 0) break;
                        popped = stack.Pop();
                    }
                    if(popped > arr[i])
                    {
                        stack.Push(popped);
                    }
                }
                stack.Push(arr[i]);
            }
            while(stack.Count > 0)
            {
                Console.WriteLine($"{stack.Pop()} --> -1");
            }
        }
    }
}
