using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Data_Structure.Codes
{
    internal class Enlisted_Lists
    {
        private Node_HASH head;

        public Enlisted_Lists()
        {
            head = null;
        }

        // Método para agregar un nodo al final de la lista
        public void AddLast(int key, string value)
        {
            Node_HASH newNode = new Node_HASH(key, value);

            if (head == null)
            {
                // Si la lista está vacía, el nuevo nodo es el primero
                head = newNode;
            }
            else
            {
                Node_HASH current = head;
                // Recorrer hasta el final de la lista
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;  // Asignar el nuevo nodo al final
            }
        }


        // Método para buscar un nodo por clave
        public Node_HASH Search(int key)
        {
            Node_HASH current = head;

            while (current != null)
            {
                if (current.Key == key)
                {
                    return current;  // Si se encuentra la clave, devolver el nodo
                }
                current = current.Next;
            }

            return null;  // Si no se encuentra la clave, devolver null
        }

        // Método para eliminar un nodo por clave
        public bool Remove(int key)
        {
            if (head == null) return false;  // Si la lista está vacía, no se puede eliminar

            // Si el nodo a eliminar es el primero
            if (head.Key == key)
            {
                head = head.Next;  // Mover la cabeza al siguiente nodo
                return true;
            }

            Node_HASH current = head;
            while (current.Next != null)
            {
                if (current.Next.Key == key)
                {
                    current.Next = current.Next.Next;  // Eliminar el nodo
                    return true;
                }
                current = current.Next;
            }

            return false;  // Si no se encuentra la clave
        }

        // Método para mostrar todos los nodos de la lista
        public void Display()
        {
            Node_HASH current = head;
            while (current != null)
            {
                Console.Write($"[{current.Key}, {current.Value}] ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
