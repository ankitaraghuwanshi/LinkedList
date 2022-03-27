using System;
namespace LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Node node_1 = new Node(22);
            Node node_2 = new Node(23);
            Node node_3 = new Node(24);

            linkedList.AddNode(node_1);
            linkedList.AddNode(node_2);
            linkedList.AddNode(node_3);
            linkedList.Display();

            Node node4 = new Node(30);
            linkedList.AppendNode(node4);
            linkedList.Display();

            Node node5 = new Node(46);
            linkedList.AddNodeatStart(node5);
            linkedList.Display();

            linkedList.DeleteNodeatFirst();
            linkedList.Display();

            linkedList.DeleteEndNode();
            linkedList.Display();

            Console.WriteLine("Enter Node you want to Search");
            int data = int.Parse(Console.ReadLine());
            bool res = linkedList.search(data);
            if (res == true)
            {
                Console.WriteLine("Data is found");
            }
            else
            {
                Console.WriteLine(" node found ");
            }

            Node node_6 = new Node(40);    
            linkedList.Display();
            Console.WriteLine("Enter position you want to add number");
            int data1 = int.Parse(Console.ReadLine());
            linkedList.AddSpecificNode(node_6, data1);
            linkedList.Display();

            Console.WriteLine("Select node for deletion"); 
            data = int.Parse(Console.ReadLine());
            linkedList.DeleteSpecificNode(data);
            linkedList.Display();
        }
    }
}
