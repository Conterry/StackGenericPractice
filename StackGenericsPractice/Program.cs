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


            Persone people1 = new Persone("John", 93000);
            Persone people2 = new Persone("Fill", 74000);
            Persone people3 = new Persone("Bill Gates", 1400000);

            Stack<Persone> people = new Stack<Persone>();
            people.Add(people1);
            people.Add(people2);
            people.Add(people3);

            foreach (Persone a in people)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
        }
    }
}
