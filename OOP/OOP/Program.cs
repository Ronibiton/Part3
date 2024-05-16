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
            //Node n = new Node(5,null);
            //Node n2 = new Node(2, null);
            //Node n3 = new Node(1, null);
            //Node n4 = new Node(7, null);
            //Node n5 = new Node(12, null);
            //Node n6 = new Node(3, null);
            //Node n7 = new Node(9, null);
            //Node n8 = new Node(11, null);
            //Node n9 = new Node(111, null);
            //Node n10 = new Node(-4, null);
            //Node n11 = new Node(121, null);
            //Node n12 = new Node(-8, null);
            //LinkedList<Node> l = new LinkedList<Node>();
            //LinkedList l = new LinkedList(n);
            //Console.WriteLine() ;
            //l.Prepend(n3);
            //l.Append(n2);
            //l.Prepend(n4);
            //l.Append(n5);
            //l.Append(n6);
            //l.Append(n7);
            //l.Prepend(n8);
            //l.Append(n9);
            //l.Prepend(n10);
            //l.Append(n11);
            //l.Prepend(n12);
            //l.Print();
            //Console.WriteLine();
            //
            //l.Sort();
            //l.Print();
            //Console.WriteLine(l.Pop());
            //Console.WriteLine();
            //Console.WriteLine(l.GetMaxNode().Value);
            //Console.WriteLine(l.GetMinNode().Value);
            //Console.WriteLine();
            //l.Sort();
            //l.Print();
            //Console.WriteLine();
            //l.Pop();
            //l.Unqueue();
            //l.Pop();
            //l.Unqueue();
            //Console.WriteLine();
            //Console.WriteLine(l.GetMaxNode().Value);
            //Console.WriteLine(l.GetMinNode().Value);
            //Console.WriteLine();
            //l.Print();

            //l.Append(n4);
            //Console.WriteLine();

            //Node nn = l.findMaxNode();
            //Console.WriteLine("nn>>>>>"+  nn.Value);


            //Console.WriteLine(l.GetMaxNode().Value);
            //Console.WriteLine(l.GetMinNode().Value);
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

            NumericalExpression num = new NumericalExpression(13243500653);
            //Console.WriteLine(num.ConvertNumber());
            Console.WriteLine(num.ToString());
            Console.WriteLine(num.GetValue());
            //Console.WriteLine(NumericalExpression.SumLetters(5));
            //Console.WriteLine(NumericalExpression.SumLetters2(new NumericalExpression(5)));
            Console.WriteLine(NumericalExpression.SumLetters(5));
            Console.WriteLine(NumericalExpression.SumLetters2(new NumericalExpression(5)));
            Console.WriteLine(NumericalExpression.SumLetters3(new NumericalExpression(5)));
        }
    }
}
