using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Array Size: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());

            string[] studentName = new string[arraySize];
            
            for(int i = 0; i < studentName.Length; i++)
            {
                Console.Write("Enter " + i + " student name: ");
                studentName[i] = Console.ReadLine();
            }

            for(int i = 0; i < studentName.Length; i++)
            {
                Console.WriteLine(i + " student's name is: " + studentName[i]);
            }

            Console.ReadKey();
        }
    }
}
