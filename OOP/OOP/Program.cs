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
            LinkedList l = new LinkedList(n);

            l.Prepend(n3);
            l.Append(n2);
            l.Prepend(n4);
            l.Print();

            Console.WriteLine();

            l.Sort();
            l.Print();
            l.Pop();
            l.Unqueue();

            Console.WriteLine();
            l.Print();
            Console.WriteLine();

            l.Append(n4);
            l.Print();
            Console.WriteLine();


            NumericalExpression num = new NumericalExpression(123456789);

            Console.WriteLine(num.ToString());
            Console.WriteLine(NumericalExpression.SumLetters(5));
            Console.WriteLine(NumericalExpression.SumLetters(new NumericalExpression(5)));
            
        }
    }
}
