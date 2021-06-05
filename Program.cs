using System;
using CSDataStructures.DataStructures;

namespace CSDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Stack();
            var q = new Queue();
            s.push(1);
            s.push(100);
            s.push("AE");
            s.save("Stack.txt");
            Console.WriteLine(s.pop());
            Console.WriteLine(s.pop());
            Console.WriteLine(s.pop());

            q.Enqueue(1);
            q.Enqueue(100);
            q.Enqueue("AE");
            q.save("Queue.txt");
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
        }
    }
}
