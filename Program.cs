using System;
using CSDataStructures.DataStructures;

namespace CSDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
             var s = new Stack();
            s.push(1);
            s.push(100);
            s.push("AE");
            Console.WriteLine(s.pop());
            Console.WriteLine(s.pop());
            Console.WriteLine(s.pop());
        }
    }
}
