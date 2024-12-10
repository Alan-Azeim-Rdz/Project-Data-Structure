using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Data_Structure.Codes
{
    internal class SearchAlgorithmos
    {

        public static int SequentialSearch(int[] array, int key)
        {
            // Recorrer el arreglo elemento por elemento
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key) // Comparar el valor actual con la clave buscada
                {
                    return i + 1;
                }
            }

            return -1;

        }


        public static int BinarySearch(int[] array, int key)
        {
            int left = 0;
            int right = array.Length - 1;


            while (left <= right)
            {
                int mid = left + (right - left) / 2; // Calcular el índice medio

                if (array[mid] == key)
                {
                    return mid; // Retorna la posición si se encuentra el elemento
                }
                else if (array[mid] < key)
                {
                    left = mid + 1; // Buscar en la mitad derecha
                }
                else
                {
                    right = mid - 1; // Buscar en la mitad izquierda
                }
            }

            return -1; // Retorna -1 si no se encuentra el elemento
        }
    }
}
