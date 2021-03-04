using System;

namespace StackGenericsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> values = new Stack<int>();
            Random rand = new Random();
            for(int i=0; i<10; i++)
            {
                values.Add(rand.Next(10));
            }

            foreach (int a in values)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine(values);
            Console.ReadLine();
        }
    }
}
