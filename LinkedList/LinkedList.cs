using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LinkedList
{
    internal class LinkedList
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
        public void Display()
        {
            Node temp = Head;
            if (temp == null)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine("linked list is");

            }
            while (temp != null)
            {
                Console.Write(temp.data);
                if (temp.next != null)
                {
                    Console.Write(" ->");
                }
                temp = temp.next;
            }
        }
        public void AppendNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.next = node;
                Tail = node;
            }
        }
        public void AddNodeatStart(Node node)
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
        public void DeleteNodeatFirst()
        {
            if (this.Head == null)
            {
                Console.WriteLine("Nothing to delete list is empty");
            }
            Node temp = this.Head;
            this.Head = this.Head.next;
            Console.WriteLine(" delete first node" + temp.data);
        }
        public void DeleteEndNode()
        {
            if (this.Head == null)
            {
                Console.WriteLine("Nothing to delete list is empty");
            }
            else
            {
                if (Head == null)
                {
                    Console.WriteLine("Nothing To Delete");
                    return;
                }
                Node temp = Head;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                Console.WriteLine("Remove node from last = " + temp.next.data);
                temp.next = null;
            }
        }
        public bool search(int data)
        {
            Node temp = this.Head;
            while (temp != null)
            {
                if (temp.data == data)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }
        public void AddSpecificNode(Node node, int position)
        {

            if (position < 1)
            {
                Console.WriteLine("enter the position you want to add number");
            }
            else if (position == 1)
            {
                node.next = Head;
                Head = node;
            }
            else
            {
                Node temp = Head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }
                if (temp != null)
                {
                    node.next = temp.next;
                    temp.next = node;
                }

            }
        }
        public void DeleteSpecificNode(int del_newdata)
        {
            if (this.Head == null)
            {
                Console.WriteLine("Nothing to delete list is empty");
            }
            else
            {
                if (Head == null)
                {
                    Console.WriteLine("Nothing To Delete");
                }
                Node temp = Head;
                while (temp != null)
                {
                    if (temp.next.data == del_newdata)
                    {
                        temp.next = temp.next.next;
                        break;
                    }
                    temp = temp.next;
                }
            }
        }
    }
}
