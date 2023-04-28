using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР3_3_завдання_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int maxSum = 0;
            int currentSum = 0;
            int startIndex = 0;
            int endIndex = 0;
            int[] arr = new int[100];
            Random rand = new Random();
            for(int i=0; i<arr.Length; i++) 
            {
                arr[i] = rand.Next(-150,100);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    currentSum += arr[i];
                    if (currentSum < maxSum || maxSum == 0)
                    {
                        maxSum = currentSum;
                        endIndex = i;
                    }
                }
                else
                {
                    currentSum = 0;
                }
            }

            
            Console.WriteLine("Неперервна послідовність додатних чисел з мінімальною сумою:");
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\nСума елементів: " + maxSum);

            Console.ReadLine();
        }
    }
}
