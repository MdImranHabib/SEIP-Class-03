using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList nameList = new ArrayList();
            nameList.Add(4);
            nameList.Add("Imran");
            nameList.Add("Habib");
            nameList.Add(4.5);
            nameList.Add("Imran");

            nameList.Remove("Imran");

            for (int i = 0; i < nameList.Count; i++)
            {
                Console.WriteLine(nameList[i]);
            }

            Console.ReadKey();
        }
    }
}
