using System;
namespace CSDataStructures.DataStructures
{
    public class Stack
    {
         node top;
         int size;
        public Stack()
        {
            size=0;
        }
        public void push(object item)
        {
            size++;
            top = new node(top,item);
        }
        public object pop()
        {
            if(top == null)
            {
                throw new InvalidOperationException("The Stack is empty");
            }
            object output = top.current;
            node next = top.next;
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

            return;
        }
    }
    public class node
    {
        public object current;
        public node next;

        public node(node proximo,object item)
        {
            this.next = proximo;
            this.current=item;
        }

    }
}