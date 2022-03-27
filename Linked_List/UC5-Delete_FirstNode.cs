using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList1
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
        public void DeleteFirstNode()
        {
            if (this.Head == null)
            {
                Console.WriteLine("Nothing to delete list is empty");
            }
            Node temp = this.Head;
            this.Head = this.Head.next;
            Console.WriteLine("\nRemove from linkedlist " + temp.data);
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
            linkedList.DeleteFirstNode();
            linkedList.Display();
        }
    }
}
