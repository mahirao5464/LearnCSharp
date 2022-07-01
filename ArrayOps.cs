using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    public class ArrayOps
    {

        public static int[] EnterArrayElements(int length)
        {
            var arr = new int[length];
            Console.WriteLine($"Please enter {length} element saprated by comma(,)");
            p: var inputValues = Console.ReadLine();

            var inputArray = inputValues?.Split(',', StringSplitOptions.RemoveEmptyEntries);
            if (inputArray.Length != length)
            {
                Console.WriteLine($"Please enter {length} elements saprated by comma(,). You have entered {inputArray.Length} elements.");
                goto p;
            }

            var parsedArray = new int[length];
            int i = 0;
            foreach(var element in inputArray)
            {
                var isParsed = Int32.TryParse(element,out int result);
                if (isParsed)
                {
                    parsedArray[i] = result;
                }
                else
                {
                    throw new InvalidDataException($"entered element {element} is not valid");
                }
                i++;
            }

            return parsedArray.ToArray();
        }

        
        
        public static int GetSum(int[] arr)
        {
            ArrayValidator(arr);
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
        return sum;
        }

        public static int FindMax(int[] arr)
        {
            ArrayValidator(arr);
            int max = arr[0];
            foreach (var item in arr)
            {
                if(item > max)
                {
                    max = item;
                }
            }

            return max;

        }
        public static int FindMin(int[] arr)
        {
            ArrayValidator(arr);

            int min = arr[0];
            foreach (var item in arr)
            {
                if (item < min)
                {
                    min = item;
                }
            }

            return min;
        }

        private static void ArrayValidator(int[] arr) 
        {
            if (arr is null)
            {
                throw new ArgumentNullException("Array cannot be null");
            }
            if (arr.Length == 0)
            {
                throw new ArgumentException("At least one element is required in the array");
            }
        }
    }
}
