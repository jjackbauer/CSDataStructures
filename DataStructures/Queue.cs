using System;
namespace CSDataStructures.DataStructures
{
    public class Queue
    {
        Node frist;
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
                frist = aux;
                last = frist;
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
           
                var aux = frist.current;
                frist = frist.next;

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
                    w.WriteLine(frist);
                    aux.Enqueue(first);
                }
                while(aux.size > 0 )
                    this.Enqueue(aux.Dequeue());
                
            }
        }
    }
}