using System;

namespace DSLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
           //Create a simple Linked List
           LinkedList list = new LinkedList();
           list.Append(56);
           list.Append(30);
           list.Append(70);
           list.Display();
        }
    }
}
