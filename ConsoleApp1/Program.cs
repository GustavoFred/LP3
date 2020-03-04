using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] a = { "1", "2", "3" };

            foreach( string nome in a)
            {
                Console.WriteLine(nome);
            }
            Console.ReadKey();

        }
    }
}
