using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Data_Structure.Codes
{
    internal class Node
    {
        public int Value { get; set; }
        public Node? Next { get; set; }
        public Node()
        {
            Value = 0;
            Next = null;
        }
        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }

    internal class DoublyNode
    {
        public int Value { get; set; }
        public DoublyNode? Next { get; set; }
        public DoublyNode? Prev { get; set; }

        public DoublyNode()
        {
            Value = 0;
            Next = null;
            Prev = null;
        }

        public DoublyNode(int value)
        {
            Value = value;
            Next = null;
            Prev = null;
        }
    }
    internal class Node_HASH
    {
        public int Key;  // Clave del par clave-valor
        public string Value;  // Valor asociado a la clave
        public Node_HASH Next;  // Apuntador al siguiente nodo

        public Node_HASH(int key, string value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
}
