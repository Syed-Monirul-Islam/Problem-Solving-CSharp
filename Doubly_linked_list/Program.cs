namespace Doubly_linked_list
{
    class Node
    {
        public int val;
        public Node next;
        public Node prev;

        public Node(int val)
        {
            this.val = val;
            this.next = null;
            this.prev = null;
        }
    }
    internal class Program
    {
        static void PrintForward(Node head)
        {
            Node tmp = head;
            while(tmp!=null)
            {
                Console.Write(tmp.val + " ");
                tmp = tmp.next;
            }
            Console.WriteLine();
        }
        static void PrintBackward(Node tail)
        {
            Node tmp = tail;
            while(tmp != null)
            {
                Console.Write(tmp.val + " ");
                tmp = tmp.prev;
            }
        }
        static void Main(string[] args)
        {
            Node head = new Node(10);
            Node a = new Node(20);
            Node tail = new Node(30);

            head.next = a;
            a.prev = head;

            a.next = tail;
            tail.prev = a;

            PrintForward(head);
            PrintBackward(tail);
        }
    }
}
