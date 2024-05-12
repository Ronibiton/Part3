using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class LinkedList
    {
        private Node _first { get; set; }
        private Node _last { get; set; }
        private int _minNode { get; set; }
        private int _maxNode { get; set; }


        public LinkedList(Node first)
        {
            _first = first;
            _last = first;
            _minNode = first.Value;
            _maxNode = first.Value;
        }

        //public bool hasNext()
        //{
        //    return _first.Next != null;

        //}

        //public void Append(Node newNode)
        //{
        //    Node position = _first;
        //    while(position.Next!=null)
        //        position = position.Next;
        //    position.Next = newNode;
        //}

        public void Append(Node newNode)
        {
            Node position = _last;
            _last = newNode;
            position.Next = _last;
            _minNode = Math.Min(newNode.Value,_minNode);
            _maxNode = Math.Max(newNode.Value, _maxNode);
        }

        public void Prepend(Node newNode)
        {
            Node position = _first;
            _first = newNode;
            _first.Next = position;
            _minNode = Math.Min(newNode.Value, _minNode);
            _maxNode = Math.Max(newNode.Value, _maxNode);
        }

        public int Pop()
        {
            Node position = _first;
            while (position.Next.Next != null)
                position = position.Next;
            int value = position.Next.Value;
            position.Next = position.Next.Next;
            //if(_maxNode == value)
            //{
            //    Sort();
            //    position = _first;
            //    while (position.Next!=null)
            //    {
            //        _maxNode = position.Value;
            //        Console.WriteLine(_maxNode);
            //    }
            //}
            //if (_minNode == value)
            //{
            //    Sort();
            //    _minNode = _first.Value;
            //    Console.WriteLine(_minNode);
            //}

            return value;
        }
        
        public int Unqueue()
        {
            int value = _first.Value;
            _first = _first.Next;
            return value;
        }


        //public IEnumerable<int> ToList()
        //{
        //    Node position = _first;
        //    while (position != null)
        //    {
        //        yield return position.Value;
        //        position = position.Next;
        //    }
        //    yield break;
        //}


        public IEnumerable<int> ToList()
        {
            Node position = _first;
            List<int> values = new List<int>();
            while (position != null)
            {
                values.Add(position.Value);
                position = position.Next;
            }
            return values;
        }



        public bool IsCircular()
        {
            Node position = _first.Next;
            while (position!=null)
            {
                if (position == _first)
                    return true;
                position = position.Next;
            }
            return false;
        }

        public void Remove( Node preNode,Node node) 
        {
            preNode.Next = node;
        }

        public void Sort()
        {
            IEnumerable<int> values = ToList();
            int[] arr = new int[values.Count()];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = values.ElementAt(i);
            }
            Array.Sort(arr);
            Node position = _first.Next;
            Node prePosition = _first;
            foreach(int num in arr)
            {
                if (prePosition.Value == num)
                {
                    Node node = prePosition;
                    _first = _first.Next;
                    node.Next = null;
                    Append(node);
                }
                else
                {
                    while (position != null && prePosition != null)
                    {
                        if (position.Value == num)
                        {
                            Node node = position;
                            Remove(prePosition, position.Next);
                            node.Next = null;
                            Append(node);
                            break;
                        }
                        position = position.Next;
                        prePosition = prePosition.Next;
                    }
                }
                position = _first.Next;
                prePosition = _first;
            }
        }



        public void Print()
        {
            Node position = _first;
            while (position != null && position.Next != _first)
            {
                Console.WriteLine(position.Value);
                position = position.Next;
            }
            if(position!=null)
                Console.WriteLine(position.Value);
        }

        //public void print()
        //{
        //    Node position = _first;
        //    while(position !=null)
        //    {
        //        Console.WriteLine(position.Value);
        //        position = position.Next;
        //    }
        //}
    }
}
