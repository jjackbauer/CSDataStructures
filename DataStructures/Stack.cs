using System;
namespace CSDataStructures.DataStructures
{
    public class Stack
    {
         node top;

        public void push(object item)
        {
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
            return output;
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
}