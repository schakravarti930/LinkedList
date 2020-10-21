using System;

namespace DSLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
           //Create a simple Linked List
           SortedLinkedList list = new SortedLinkedList();
           list.Add(32);
           list.Add(12);
           list.Add(434);
           list.Add(0);
           list.Display();
           System.Console.WriteLine(list.Size());
        }
    }
}
