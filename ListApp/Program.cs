using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> aList = new List<int>();

            aList.Add(5);
            aList.Add(1);
            aList.Add(6);
            aList.Add(7);
            aList.Add(8);
            aList.Add(2);
            aList.Add(5);
            aList.Add(4);

            aList.Remove(6);
            aList.RemoveAt(3);

            aList.Sort();
            aList.Reverse();

            foreach (var numbers in aList)
            {
                Console.WriteLine(numbers);
            }

            Console.ReadKey();
        }
    }
}
