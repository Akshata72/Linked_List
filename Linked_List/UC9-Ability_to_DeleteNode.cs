using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkd_List
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
        public void DeleteNode()
        {
            if (this.Head.next.next == null)
            {
                Console.WriteLine("Nothing to delete list is empty");
            }
            Node temp = this.Head.next.next;
            this.Head.next.next = this.Head.next.next.next;

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
}

