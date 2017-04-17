using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<string> GenericList = new GenericList<string> { "one", "two", "three" };
            GenericList.Print();
            Console.ReadLine();

            GenericList.Remove("two");
            GenericList.Print();
            Console.ReadLine();

            string GenericString = GenericList.GenericString();
            Console.WriteLine(GenericString);
            Console.ReadLine();
        }
    }
}
