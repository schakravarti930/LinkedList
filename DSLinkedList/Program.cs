using System;

namespace DSLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
           //Create a simple Linked List
           LinkedList list = new LinkedList();
           list.Add(70);
           list.Add(30);
           list.Add(56);
           list.Display();
        }
    }
}
