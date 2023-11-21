using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo
{
    internal class Program
    {
        public void Add()
        {
            int a = 10, b = 20, c;
            c = a + b;
            Console.WriteLine("Add="+c);
        }
        static void Main()
        {
            Program p = new Program();
            p.Add();
            Console.ReadLine();
        }
    }
}
