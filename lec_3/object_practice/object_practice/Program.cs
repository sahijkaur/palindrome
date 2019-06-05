using System;
using System.Reflection;

namespace object_practice
{
    class Program
    {
        Random rand;
        static void Main(string[] args)
        {
            int counter = 0;
            for (Console.WriteLine("loop 1"); Orange(); Console.WriteLine("loop 2"))
            {

                Console.WriteLine("iterations {0}", counter++);
                Console.Read();

                //   Console.WriteLine("Hello World!");
            }
        }

            static bool Orange()
        {
                int counter = 0;
                Console.WriteLine("i am orange method  {0}", counter++);
            Console.Read();
            Random rand = new Random();
            int r = rand.Next(1, 100);
            if(r>50)
            {
                return true;
            }
            return false;
        }

    }
}
