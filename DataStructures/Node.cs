namespace CSDataStructures.DataStructures
{
    public class Node
    {
        public object current;
        public Node next;

        public Node(Node next,object item)
        {
            this.next = next;
            this.current=item;
        }
    }
}