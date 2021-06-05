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
            var aux =top.current;
            node proximo = top.next;
            top = proximo;
            return aux;
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