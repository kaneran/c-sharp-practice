using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Practice___Data_structures
{
    public static class ArrayPractice
    {

        //in place array solution
        public static int[] RotateArray(int[] numbers)
        {
            int temp = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length - 1)
                {
                    numbers[numbers.Length - 1] = temp;
                }
                else if (temp != -1)
                {
                    int temp2 = numbers[numbers.Length - i - 2];
                    numbers[numbers.Length - i - 2] = temp;
                    temp = temp2;
                }
                else
                {
                    temp = numbers[numbers.Length - i - 2];
                    numbers[numbers.Length - i - 2] = numbers[numbers.Length - i - 1];
                }
            }
            return numbers;
        }

        //new array
        public static int[] RotateArray2(int[] numbers)
        {
            int[] rotateArray = new int[numbers.Length];
            //set i = 1 instead of 0 as setting to 0 will result in index out of bound error
            for(int i = 1; i < numbers.Length; i++)
            {
                //rotateArray[0] = numbers[1]
                //rotateArray[1] = numbers[2]
                rotateArray[i - 1] = numbers[i];
            }
            rotateArray[numbers.Length - 1] = numbers[0];
            return rotateArray;
        }
    }
}
