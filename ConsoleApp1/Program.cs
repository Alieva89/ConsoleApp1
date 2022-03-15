using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<тип данных> name = new()

            List<int> notEvenList;
            List<int> evenList;
            List<int> result;

            notEvenList = Add10();
            evenList = Add10();

            result = Add10();

            int counter = 1;
            int counter2 = 0;

            Console.WriteLine("EvenList");
            foreach (var item in evenList)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("NotEvenList");
            foreach (var item in notEvenList)
            {
                Console.Write($"{item} ");
            }

            for (int i = 0; i < result.Count; i++)
            {            
                if (i % 2 == 0)
                {
                    result[i] = evenList[counter];
                    counter += 2;
                }
                else
                {
                    result[i] = notEvenList[counter2];
                    counter2++;
                }
            }

            Console.WriteLine("\nПосле");
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();
        }

        static List<int> Add10()
        {
            Random random = new Random();

            List<int> result = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                result.Add(random.Next(1,30));
            }

            return result;
        }
    }
}
