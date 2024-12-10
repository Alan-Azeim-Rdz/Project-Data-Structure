using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Data_Structure.Codes
{
    internal class Hash_TAble
    {
        public const int TableSize = 10;
        public Enlisted_Lists[] table;

        public Hash_TAble()
        {
            table = new Enlisted_Lists[TableSize];

            for (int i = 0; i < TableSize; i++)
            {
                table[i] = new Enlisted_Lists();
            }
        }

        // Función hash: toma la clave (key) y calcula el índice en la tabla
        private int GetHash(int key)
        {
            // buscamos en que cubeta tiene que estar el dato
            return (key % TableSize + TableSize) % TableSize;
        }

        // Insertar un valor en la tabla hash
        public void Insert(int key, string value)
        {
            int index = GetHash(key);

            // Revisamos si ya existe una clave con ese índice
            Node_HASH existingNode = table[index].Search(key);
            if (existingNode != null)
            {
                // Si la clave ya existe, actualizamos el valor
                Console.WriteLine($"Key {key} already exists. Updating value.");
                existingNode.Value = value; // Actualizamos el valor del nodo
                return;
            }

            table[index].AddLast(key, value);
        }

        // Buscar un valor en la tabla hash usando su clave
        public string Search(int key)
        {
            int index = GetHash(key);

            // Buscar en la lista enlazada en el índice
            Node_HASH foundNode = table[index].Search(key);
            if (foundNode != null)
            {
                return foundNode.Value; // Si encontramos la clave, devolvemos su valor
            }
            return null;
        }

        // Mostrar todos los elementos de la tabla hash
        public void Display()
        {
            for (int i = 0; i < TableSize; i++)
            {
                Console.Write($"Bucket {i}: ");
                table[i].Display();
            }
        }
    }
}
