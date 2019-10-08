using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> aStack = new Stack<int>(); // it is called as generic class here.
            Stack bStack = new Stack();          //it can store multiple data of multiple type.

            aStack.Push(10);
            aStack.Push(9);
            aStack.Push(8);
            aStack.Push(7);
            aStack.Push(6);
            aStack.Push(5);

            Console.WriteLine(aStack.Count);
            Console.WriteLine(aStack.Peek());
            Console.WriteLine(aStack.Pop());
            
            Console.ReadKey();
        }   
    }       
}           
