using System;
namespace CSDataStructures.DataStructures
{
    public class Queue
    {
        Node first;
        Node last;
        int size;
        public Queue()
        {
            size=0;
        }
        public void Enqueue(object item)
        {
            var aux = new Node(null, item);
            if(size == 0)
            {
                first = aux;
                last = first;
            }
            else
            {
                last.next=aux;
                last = aux;
            }
            size++;
        }
        public object Dequeue()
        {  
            if(size ==0)
            {
                throw new InvalidOperationException("The Queue is empty");
            }
           
                object aux = first.getCurrent();
                Node next = first.getNext();
                first = next;

                if(size == 1)
                    last=null;
            
                size--;

                return aux;
        }
        public void save(string filename)
        {
            using (System.IO.TextWriter w = System.IO.File.CreateText(filename))
            {
                var aux = new Queue();

                while(this.size > 0 )
                {
                    object first = this.Dequeue();
                    aux.Enqueue(first);
                    w.WriteLine(first);
                    
                }
                while(aux.size > 0 )
                    this.Enqueue(aux.Dequeue());
                
            }
        }
    }
}