using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> aQ = new Queue<int>(); // it is called as generic class here.
            Queue bQ = new Queue();         //it can store multiple data of multiple type.

            aQ.Enqueue(10);
            aQ.Enqueue(9);
            aQ.Enqueue(8);
            aQ.Enqueue(7);
            aQ.Enqueue(6);
            aQ.Enqueue(5);

            Console.WriteLine(aQ.Count);
            Console.WriteLine(aQ.Peek());
            Console.WriteLine(aQ.Dequeue());

            Console.ReadKey();
        }
    }
}
