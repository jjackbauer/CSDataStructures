using System;
namespace CSDataStructures.DataStructures
{
    public class Stack
    {
         Node top;
         int size;
        public Stack()
        {
            size=0;
        }
        public void push(object item)
        {
            size++;
            top = new Node(top,item);
        }
        public object pop()
        {
            if(top == null)
            {
                throw new InvalidOperationException("The Stack is empty");
            }
            object output = top.getCurrent();
            Node next = top.getNext();
            top = next;
            size--;
            return output;
        }
        public void save(string filename)
        {
             using (System.IO.TextWriter w = System.IO.File.CreateText(filename))
            {
                var aux = new Stack();
                while(this.size > 0 )
                {  
                    object top = this.pop();
                    aux.push(top);
                    w.WriteLine(top);
                }

                while(aux.size > 0 )
                    this.push(aux.pop());
            }
        }
    }
}