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
        private Node _minNode { get; set; }
        private Node _maxNode { get; set; }


        public LinkedList(Node first)
        {
            _first = first;
            _last = first;
            _minNode = first;
            _maxNode = first;
        }  

        public void Append(Node newNode)
        {
            Node position = _last;
            _last = newNode;
            position.Next = _last;
            if (newNode.Value > _maxNode.Value)
                _maxNode = newNode;
            else if (newNode.Value < _minNode.Value)
                _minNode = newNode;
        }

        public void Prepend(Node newNode)
        {
            Node position = _first;
            _first = newNode;
            _first.Next = position;
            if(newNode.Value > _maxNode.Value)
                _maxNode = newNode;
            else if (newNode.Value < _minNode.Value)
                _minNode = newNode;
        }

        public int[] SortedArr()
        {
            IEnumerable<int> values = ToList();
            int[] arr = new int[values.Count()];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = values.ElementAt(i);
            }
            Array.Sort(arr);
            return arr;
        }


        public Node findMaxNode()
        {
            Sort();
            Node position = _first;
            while(position.Next != null)
            {
                position = position.Next;
            }
            return position;
        }

        public int Pop()
        {
            int value = _last.Value;
            Node position = _first;
            Console.WriteLine("old max >>>" + _maxNode.Value);
            while (position.Next!=_last)
            {
                position = position.Next;
            }
            position.Next = null;
            _last = position;
            
            if(value == _maxNode.Value)
            {
                _maxNode = findMaxNode();
                Console.WriteLine("max >>" + _maxNode.Value);
            }
            return value;
        }

        public int Unqueue()
        {
            int value = _first.Value;
            _first = _first.Next;
            Console.WriteLine("mmin:" + _minNode.Value);
            if (_minNode.Value == value)
            {
                Sort();
                _minNode = _first;
                Console.WriteLine("min>>>"+_minNode.Value);
            }
            Console.WriteLine("min:" + _minNode.Value);
            return value;

        }

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
            int[] arr = SortedArr();
            foreach(int num in arr)
            {
                Node position = _first.Next;
                Node prePosition = _first;
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
            }
        }


        public Node GetMaxNode()
        {
            return _maxNode;
        }

        public Node GetMinNode()
        {
            return _minNode;
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

    }
}
