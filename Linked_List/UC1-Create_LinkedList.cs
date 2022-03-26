using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
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
            linkedList.Display();
        }
    }
}
