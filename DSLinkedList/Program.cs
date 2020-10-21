using System;

namespace DSLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
           //Create a simple Linked List
           Node head = new Node(56);
           head.next = new Node(30);
           head.next.next = new Node(70);
        }
    }
}
