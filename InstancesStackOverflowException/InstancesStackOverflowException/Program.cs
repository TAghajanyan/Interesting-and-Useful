using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstancesStackOverflowException
{
    class MyClass
    {
        public MyClass(int count)
        {
            count++;
            Console.WriteLine(count);
            MyClass my = new MyClass(count);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            MyClass myClass = new MyClass(count);
        }
    }
}
