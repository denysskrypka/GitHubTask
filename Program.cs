using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР3_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] array = new int[30];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }

            
            for (int i = 1; i < array.Length; i++)
            {
                int current = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > current)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = current;
            }

            
            Console.WriteLine("Відсортований масив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");


                Console.ReadLine();
            }


        }
    }
}
