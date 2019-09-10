using System;
using System.Threading;

namespace Arrays_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new CircularLinkedList<int>();
            lista.AddLast(0);
            lista.AddFirst(1);
            lista.AddLast(7);
            lista.AddLast(9);

            foreach(int i in lista)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);

            }
            Console.WriteLine("Hello World!");
        }
    }
}
