using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практичне_завдання_5
{
    enum Software
    {
        Chrome = 1,
        Firefox,
        Edge,
        Safari,
        VisualStudio,
        IntelliJIDEA,
        Eclipse,
        PyCharm
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Список програмних продуктів:");
            foreach (Software s in Enum.GetValues(typeof(Software)))
            {
                Console.WriteLine($"{(int)s} - {s}");
            }

            Console.Write("Введіть номери програмних продуктів: ");
            string input = Console.ReadLine();

            string[] numbers = input.Split(',');
            Console.WriteLine("\nСписок обранних браузерів:");
            foreach (string number in numbers)
            {
                int n = int.Parse(number);
                if (n >= 1 && n <= 4)
                {
                    Software s = (Software)n;
                    Console.WriteLine(s);
                }
            }

            Console.WriteLine("\nСписок обранних IDE:");
            foreach (string number in numbers)
            {
                int n = int.Parse(number);
                if (n >= 5 && n <= 8)
                {
                    Software s = (Software)n;
                    Console.WriteLine(s);
                }
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n\nАвтор: Скрипка Денис");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
