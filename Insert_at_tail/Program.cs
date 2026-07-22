namespace Insert_at_head
{
    class Node
    {
        public int val;
        public Node next;

        public Node(int val)
        {
            this.val = val;
            this.next = null;
        }
    }

    internal class Program
    {
        static Node InsertAtHead(Node head,int val)
        {
            Node newnode = new Node(val);
            newnode.next = head;
            head = newnode;
            return head;
        }
        static void PrintLinkedList(Node head)
        {
            Node tmp = head;
            while (tmp != null)
            {
                Console.WriteLine(tmp.val);
                tmp = tmp.next;
            }
        }
        static void Main(string[] args)
        {
            Node head = new Node(10);
            Node a = new Node(20);
            Node b = new Node(30);


            head.next = a;
            a.next = b;
            head = InsertAtHead(head, 100);
            PrintLinkedList(head);
        }
    }
}
