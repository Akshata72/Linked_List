using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkdList
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
        public bool search(int Value)
        {
            Node temp = this.Head;
            while (temp != null)
            {
                if (temp.data == Value)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }
        public void InsertNode(int data)
        {
            Node node = new Node(data);
            Node node_1 = new Node(70);
            Node node_2 = new Node(30);
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Head.next = node_2;
                Head.next.next = node;
                Head.next.next.next = node_1;
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
            Node node_3 = new Node(56);
            Node node_2 = new Node(30);
            Node node_1 = new Node(70);
            linkedList.AddNode(node_1);
            linkedList.AddNode(node_2);
            linkedList.AddNode(node_3);
            linkedList.Display();
            Console.WriteLine("\nEnter number to Search");
            int Value = int.Parse(Console.ReadLine());
            if (linkedList.search(Value) != null)
            {
                Console.WriteLine("Node found");
            }
            else
            {
                Console.WriteLine("Node not found");
            }
            linkedList.Display();

            Console.WriteLine("\nEnter a Value for Inserting after 30 :");
            int node = int.Parse(Console.ReadLine());
            linkedList.InsertNode(node);
            linkedList.Display();
        }
    }
}
