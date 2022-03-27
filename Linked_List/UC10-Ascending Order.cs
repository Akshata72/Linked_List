using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
public class SortedLinkedList
{
    public Node Head;
    public Node Tail;
    public SortedLinkedList()
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
    public void AccedingOrder()
    {
        int i;
        int[] a = new int[30];
        a[1] = 30;
        a[2] = 45;
        a[3] = 70;
        a[4] = 40;
        for (i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 4 - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }
        Console.Write("\nAscending Sort : ");
        for (i = 1; i <= 4; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.ReadKey();
    }
}

class program
{
    static void Main(string[] args)
    {
        SortedLinkedList sortedLinkedList = new SortedLinkedList();
        Node node_4 = new Node(56);
        Node node_3 = new Node(30);
        Node node_2 = new Node(40);
        Node node_1 = new Node(70);
        sortedLinkedList.AddNode(node_1);
        sortedLinkedList.AddNode(node_2);
        sortedLinkedList.AddNode(node_3);
        sortedLinkedList.AddNode(node_4);
        sortedLinkedList.Display();

        Console.WriteLine("\nEnter 1 for Ascending order: ");
        int Ans = int.Parse( Console.ReadLine());
        if (Ans == 1)
        {
            sortedLinkedList.AccedingOrder();
            sortedLinkedList.Display();
        }
        else
            Console.WriteLine("Data not in Ascendind Order: ");
        sortedLinkedList.Display();
    }
}
