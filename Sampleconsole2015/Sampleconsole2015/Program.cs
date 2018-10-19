using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampleconsole2015
{
    public class Program
    {
        public int a = 10, b = 100, c = 0;
        static void Main(string[] args)
        {
            MyClass MC = new MyClass();
            MC.c = MC.add(10, 200);
            Console.WriteLine("My Result is : "+ MC.c.ToString());
            Console.ReadLine(); 
        }

        public int  add (int a , int b)
        {
            return a * b;


        }
    }
}
