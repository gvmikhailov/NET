using System;

namespace Vebinar2
{
    public class DoublyLinkedList : IDoublyLinkedList
    {
        private Node _first;
        private Node _last;
        private Node _current;
        private int _counter;

        public DoublyLinkedList ()
        {
            _counter = 0;
            _first = _last = null;
        }

        public void AddNode(int value)
        {
            Node element = new Node();
            element.Value = value;
            if (_first == null)
            {
                _first = _last = element;
            }
            else
            {
                element.NextNode = null;
                element.PreviousNode = _last;
                _last = element;
            }
            _counter++;
        }

        public void AddNodeAfter(Node node, int value)
        {
            Node element = new Node();
            element.Value = value;
            element.PreviousNode = node;
            
            if (node == _last)
                element.NextNode = null;                
            else
                element.NextNode = node.NextNode;

            node.NextNode = element;
            _counter++;
        }

        public Node FindNode(int searchValue)
        {
            _current = _first;

            for (int i = 0; i < _counter; i++)
            {
                if (_current.Value == searchValue)
                    return _current;
                else
                    _current = _current.NextNode;
            }

            throw new Exception("Не найден элемент списка с заданым значением!");
        }

        public int GetCount()
        {
            return _counter;
        }

        public void RemoveNode(int index)
        {            
            if (index < 1 || index > _counter)
                throw new Exception("Неверный индекс!");
            else if (index == 1)
                RemoveNode(_first);
            else if (index == _counter)
                RemoveNode(_last);
            else
            {
                int count = 1;
                _current = _first;
                while (_current != null && count != index)
                {
                    _current = _current.NextNode;
                    count++;
                }
                RemoveNode(_current);
            }
        }

        public void RemoveNode(Node node) 
        {
            if (node.PreviousNode == null)
            {
                node.PreviousNode = null;
                node.NextNode = _first.NextNode;
                _first = node;
            }                
            else if (node.NextNode == null)
            {
                node.PreviousNode = _last.PreviousNode;
                node.NextNode = null;
                _last = node;
            }                
            else
            {
                node.PreviousNode.NextNode = node.NextNode;
                node.NextNode.PreviousNode = node.PreviousNode;
            }

            _counter--;
        }
    }
}
