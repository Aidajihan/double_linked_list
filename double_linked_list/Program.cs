using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_linked_list
{
    class Node
    {
        /*Node class represents the node of doubly lingked list
         * it consist of the information part and links to
         * it succeding and preceeding
         * in terms of next and previous */
        public int noMhs;
        public string name;
        //point to the succending node
        public Node next;
        //point to the precceending node
        public Node prev;

    }
    class DoubleLinkedList
    {
        Node START;

        //constructor
        public DoubleLinkedList()
        {
            START = null;
        }
        public void addNode()
        {
            
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
