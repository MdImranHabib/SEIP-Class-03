using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> phoneBook = new Dictionary<string, int>();

            phoneBook.Add("one", 1);
            phoneBook.Add("two", 2);
            phoneBook.Add("three", 3);
            phoneBook.Add("four", 4);

            Console.WriteLine(phoneBook.Count);

            foreach (var item in phoneBook)
            {
                Console.WriteLine(phoneBook[item.Key]);
            }

            Console.ReadKey();
        }
    }
}
