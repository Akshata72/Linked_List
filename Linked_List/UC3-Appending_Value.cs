using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
    public class LinkedList
    {
        public Node Head;
        public Node Tail;
        public LinkedList()
        {
            Head = null;
            Tail = null;
        }
        public void AddNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }
        }
        public void AppendNode(int data)
        {
            Node node = new Node(data);
            if (Head == null)
            {
                Head = Tail = node;
            }
            else
            {
                Tail.next = node;
                Tail = node;
            }
        }
        internal void Display()
        {
            Node temp = Head;
            if (temp == null)
            {
                Console.WriteLine("Linkedlist is empty");
            }
            else
                Console.WriteLine("Linked List as follows");
            while (temp != null)
            {
                Console.Write(temp.data);
                if (temp.next != null)
                {
                    Console.Write("->");
                }
                temp = temp.next;
            }
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Node node_1 = new Node(56);

            linkedList.AddNode(node_1);
            linkedList.Display();

            Console.WriteLine("\nEnter How many Numbers you like Append: "); int Number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Number; i++)
            {
                Console.WriteLine("\nEnter a number to Append");
                int data = int.Parse(Console.ReadLine());
                linkedList.AppendNode(data);
                linkedList.Display();

            }

        }
    }
}
