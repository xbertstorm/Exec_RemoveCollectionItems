using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_RemoveCollectionItems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> test = new List<int>();
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            test.Add(5);
            test.Add(10);
            test.Add(15);
            test.Add(20);
            test.Add(1);
            test.Add(2);

            foreach (var i in test)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            test.Remove(1);
            test.Remove(2);
            test.Remove(3);
            test.RemoveAt(6); 

            foreach (var i in test)
            {
                Console.WriteLine(i);
            }

            Console.Read();
        }
    }
}
