using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist
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
        public void AddBetweenNode(int data)
        {
            Node node = new Node(data);
            Node node_1 = new Node(70);
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Head.next = node;
                Head.next.next = node_1;
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
            Node node_2 = new Node(56);
            Node node_1 = new Node(70);
            linkedList.AddNode(node_1);
            linkedList.AddNode(node_2);
            linkedList.Display();
            Console.WriteLine("\nEnter a Value for Adding between 56 & 70 :");
            int node = int.Parse(Console.ReadLine());
            linkedList.AddBetweenNode(node);
            linkedList.Display();
        }
    }
}
