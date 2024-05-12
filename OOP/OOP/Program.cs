using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace OOP
{
    class Program
    {



        static void Main(string[] args)
        {
            Node n = new Node(5,null);
            Node n2 = new Node(2, null);
            Node n3 = new Node(1, null);
            Node n4 = new Node(7, null);
            Node n5 = new Node(12, null);
            Node n6 = new Node(3, null);
            Node n7 = new Node(9, null);
            Node n8 = new Node(11, null);
            Node n9 = new Node(111, null);
            Node n10 = new Node(-4, null);
            //LinkedList<Node> l = new LinkedList<Node>();
            LinkedList l = new LinkedList(n);
            Console.WriteLine() ;
            l.Prepend(n3);
            l.Append(n2);
            l.Prepend(n4);
            l.Append(n5);
            l.Append(n6);
            l.Append(n7);
            l.Prepend(n8);
            l.Append(n9);
            l.Prepend(n10);
            l.Print();
            //Console.WriteLine();
            //
            //l.Sort();
            //l.Print();
            //Console.WriteLine(l.Pop());
            l.Pop();
            l.Unqueue();
            l.Print();
            
            //l.Append(n4);
            Console.WriteLine();
            //int x = l.Pop();
            //int y = l.Unqueue();
            //Console.WriteLine(l.IsCircular());
            //l.Print();
            //l.Sort();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Console.WriteLine();
            //l.Print();

            //Console.WriteLine( l.ToList());

            //foreach (int num in l.ToList())
            //{
            //    Console.WriteLine(num) ;
            //}

            //Node X = l.Sort();
            //while(X!=null)
            //{
            //    Console.WriteLine(X.Value);
            //}

            //Console.WriteLine("here" + x);
            //Console.WriteLine("heree" + y);

            //Console.WriteLine(l.ToList());
        }
    }
}
