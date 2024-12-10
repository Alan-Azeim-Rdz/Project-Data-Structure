using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_Data_Structure.Codes
{
    internal class QueueClass
    {
        //Cola Estatica
        public class StaticQueue
        {
            private int[] elements; // Arreglo para almacenar elementos de la cola
            private int front;      // Índice del primer elemento de la cola
            private int rear;       // Índice del último elemento de la cola
            private int count;      // Número de elementos en la cola

            public int Capacity { get; } // Capacidad máxima de la cola

            public StaticQueue(int capacity)
            {
                Capacity = capacity;
                elements = new int[capacity];
                front = 0;
                rear = -1;
                count = 0;
            }

            // Método para agregar un número a la cola
            public void Enqueue(int number)
            {
                if (count == Capacity)
                {
                    MessageBox.Show("The Queueu is full.");
                    return;
                }

                rear = (rear + 1) % Capacity;
                elements[rear] = number;
                count++;
            }

            // Método para eliminar y devolver el número al frente de la cola
            public int Dequeue()
            {
                if (IsEmpty())
                {
                    MessageBox.Show("The Queueu is empty.");
                }

                int number = elements[front];
                front = (front + 1) % Capacity;
                count--;
                return number;
            }

            // Método para ver el número al frente de la cola sin eliminarlo
            public int Peek()
            {
                if (IsEmpty())
                {
                    MessageBox.Show("The Queueu is empty.");
                }

                return elements[front];
            }

            // Método para verificar si la cola está vacía
            public bool IsEmpty()
            {
                return count == 0;
            }

            // Método para verificar si la cola está llena
            public bool IsFull()
            {
                return count == Capacity;
            }

            //method to get size of the queue
            public int Size()
            {
                return count;
            }
        }

        //Cola dinamica
        public class DynamicQueue
        {
            private Node front; // Nodo al frente de la cola
            private Node rear;  // Nodo al final de la cola
            private int count;  // Número de elementos en la cola

            public int Count => count;

            public DynamicQueue()
            {
                front = null;
                rear = null;
                count = 0;
            }

            // Método para agregar un número a la cola
            public void Enqueue(int number)
            {
                Node newNode = new Node(number);

                if (IsEmpty())
                {
                    front = rear = newNode;
                }
                else
                {
                    rear.Next = newNode;
                    rear = newNode;
                }

                count++;
            }

            // Método para eliminar y devolver el número al frente de la cola
            public int Dequeue()
            {
                if (IsEmpty())
                {
                    MessageBox.Show("The Queueu is empty.");
                }

                int data = front.Value;
                front = front.Next;

                if (front == null)
                {
                    rear = null; // La cola queda vacía
                }

                count--;
                return data;
            }

            // Método para ver el número al frente de la cola sin eliminarlo
            public int Peek()
            {
                if (IsEmpty())
                {
                    MessageBox.Show("The Queueu is empty.");
                }

                return front.Value;
            }

            // Método para verificar si la cola está vacía
            public bool IsEmpty()
            {
                return front == null;
            }

            //method to get size of the queue
            public int Size()
            {
                return count;
            }
        }

        //Cola Circular
        internal class CircularQueue
        {
            private int[] array;
            private int front;
            private int rear;
            private int count;
            public int Capacity { get; }

            // Constructor para inicializar la cola circular con un tamaño determinado
            public CircularQueue(int capacity)
            {
                Capacity = capacity;
                array = new int[capacity];
                front = 0;
                rear = -1;
                count = 0;
            }

            // Método para agregar un elemento al final de la cola
            public void Enqueue(int value)
            {
                if (count == Capacity)
                {
                    MessageBox.Show("The Queueu is full.");
                    return;
                }

                rear = (rear + 1) % Capacity;  // Mover el índice rear de forma circular
                array[rear] = value;
                count++;
            }

            // Método para eliminar un elemento del frente de la cola
            public int Dequeue()
            {
                if (IsEmpty())
                {
                    MessageBox.Show("The Queueu is empty.");
                }

                int dequeuedValue = array[front];
                front = (front + 1) % Capacity;  // Mover el índice front de forma circular
                count--;
                return dequeuedValue;
            }

            // Método para ver el valor del frente de la cola sin eliminarlo
            public int Peek()
            {
                if (IsEmpty())
                {
                    MessageBox.Show("The Queueu is empty.");
                }

                return array[front];
            }

            // Método para obtener el número de elementos en la cola
            public int Size()
            {
                return count;
            }

            // Método para verificar si la cola está vacía
            public bool IsEmpty()
            {
                return count == 0;
            }

            // Método para verificar si la cola está llena
            public bool IsFull()
            {
                return count == Capacity;
            }
        }
        internal class DoubleEndedStaticQueue
        {
            private int[] array;
            private int front;
            private int rear;
            private int size;
            private int capacity;

            public DoubleEndedStaticQueue(int capacity)
            {
                this.capacity = capacity;
                array = new int[capacity];
                front = -1;
                rear = -1;
                size = 0;
            }

            // Verifica si la cola está vacía
            public bool IsEmpty()
            {
                return size == 0;
            }

            // Verifica si la cola está llena
            public bool IsFull()
            {
                return size == capacity;
            }

            // Inserta un elemento en el frente de la cola
            public void InsertFront(int value)
            {
                if (size == array.Length)
                {
                    MessageBox.Show("The Double Queueu is full.");
                    return;
                }

                // Mover todos los elementos una posición hacia atrás
                for (int i = size - 1; i >= 0; i--)
                {
                    array[i + 1] = array[i];
                }

                // Insertar el valor al frente
                array[0] = value;
                if (front == -1) front = 0;
                rear = (rear + 1) % array.Length;
                size++;
            }

            // Inserta un elemento en el final de la cola
            public void InsertRear(int value)
            {
                if (IsFull())
                {
                    MessageBox.Show("The Double Queueu is full.");
                    return;
                }

                if (rear == -1) // Si la cola está vacía
                {
                    front = 0;
                    rear = 0;
                }
                else
                {
                    rear = (rear + 1) % capacity; // Mover el índice del final hacia adelante
                }

                array[rear] = value;
                size++;
            }

            // Elimina un elemento del frente de la cola
            public int DeleteFront()
            {
                if (IsEmpty())
                {
                    MessageBox.Show("The Double Queueu is empty.");
                    return -1;
                }

                int value = array[front];
                if (front == rear) // Si hay un solo elemento
                {
                    front = -1;
                    rear = -1;
                }
                else
                {
                    front = (front + 1) % capacity; // Mover el índice del frente hacia adelante
                }

                size--;
                return value;
            }

            // Elimina un elemento del final de la cola
            public int DeleteRear()
            {
                if (IsEmpty())
                {
                    MessageBox.Show("The Double Queueu is empty.");
                    return -1;
                }

                int value = array[rear];
                if (front == rear) // Si hay un solo elemento
                {
                    front = -1;
                    rear = -1;
                }
                else
                {
                    rear = (rear - 1 + capacity) % capacity; // Mover el índice del final hacia atrás
                }

                size--;
                return value;
            }

            // Ver el valor en el frente sin eliminarlo
            public int GetFront()
            {
                if (IsEmpty())
                {
                    MessageBox.Show("The Double Queueu is empty.");
                    return -1;
                }
                return array[front];
            }

            // Ver el valor en el final sin eliminarlo
            public int GetRear()
            {
                if (IsEmpty())
                {
                    MessageBox.Show("The Double Queueu is empty.");
                    return -1;
                }
                return array[rear];
            }

            // Obtener el tamaño actual de la cola
            public int Size()
            {
                return size;
            }

            public List<int> GetQueueElements()
            {
                List<int> elements = new List<int>();

                if (front != -1)
                {
                    for (int i = front; i <= rear; i++)
                    {
                        elements.Add(array[i]);
                    }
                }

                return elements;
            }
        }


        internal class DoubleEndedDynamicQueue
        {
            private DoublyNode front;  // Frente de la cola
            private DoublyNode back;   // Final de la cola
            private int size;    // Tamaño de la cola

            public DoubleEndedDynamicQueue()
            {
                front = null;
                back = null;
                size = 0;
            }

            // Agregar un elemento al frente de la cola
            public void InsertFront(int value)
            {
                DoublyNode newNode = new DoublyNode(value);

                if (IsEmpty())
                {
                    front = back = newNode;  // Si la cola está vacía, el nuevo nodo es tanto el frente como el final
                }
                else
                {
                    newNode.Next = front;
                    front.Prev = newNode;
                    front = newNode;
                }

                size++;
            }

            // Agregar un elemento al final de la cola
            public void InsertRear(int value)
            {
                DoublyNode newNode = new DoublyNode(value);

                if (IsEmpty())
                {
                    front = back = newNode;  // Si la cola está vacía, el nuevo nodo es tanto el frente como el final
                }
                else
                {
                    newNode.Prev = back;
                    back.Next = newNode;
                    back = newNode;
                }

                size++;
            }

            // Eliminar un elemento del frente de la cola
            public int DeleteFront()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("Queue is empty.");
                }

                int frontValue = front.Value;
                front = front.Next;

                if (front != null)
                {
                    front.Prev = null;
                }
                else
                {
                    back = null;  // Si la cola queda vacía, el final también debe ser nulo
                }

                size--;
                return frontValue;
            }

            // Eliminar un elemento del final de la cola
            public int DeleteRear()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("Queue is empty.");
                }

                int backValue = back.Value;
                back = back.Prev;

                if (back != null)
                {
                    back.Next = null;
                }
                else
                {
                    front = null;  // Si la cola queda vacía, el frente también debe ser nulo
                }

                size--;
                return backValue;
            }

            // Ver el elemento del frente de la cola sin eliminarlo
            public int GetFront()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("Queue is empty.");
                }

                return front.Value;
            }

            // Ver el elemento del final de la cola sin eliminarlo
            public int GetRear()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("Queue is empty.");
                }

                return back.Value;
            }

            // Obtener el tamaño de la cola
            public int Size()
            {
                return size;
            }

            // Verificar si la cola está vacía
            public bool IsEmpty()
            {
                return size == 0;
            }

            public List<int> GetQueueElements()
            {
                List<int> elements = new List<int>();
                DoublyNode current = front;

                while (current != null)
                {
                    elements.Add(current.Value);
                    current = current.Next;
                }

                return elements;
            }

        }
        public class VectorOfVectors_PQ<T>
        {
            public T[][] _queue;
            public int _maxPriority;

            // Constructor, initialize with max priority level
            public VectorOfVectors_PQ(int maxPriority)
            {
                _maxPriority = maxPriority;
                _queue = new T[maxPriority + 1][];  // Array of arrays
                for (int i = 0; i <= maxPriority; i++)
                {
                    _queue[i] = new T[0];  // Initialize each inner array as an empty array
                }
            }

            // Enqueue an item with a specified priority
            public void Enqueue(T item, int priority)
            {
                if (priority < 0 || priority > _maxPriority)
                {
                    MessageBox.Show("Priority out of range.");
                    return;
                }

                // Resize the array at the given priority index to accommodate the new item
                Array.Resize(ref _queue[priority], _queue[priority].Length + 1);
                _queue[priority][_queue[priority].Length - 1] = item;
            }

            // Dequeue the item with the highest priority (largest priority value)
            public T Dequeue()
            {
                // Find the highest non-empty priority array
                for (int i = _maxPriority; i >= 0; i--)
                {
                    if (_queue[i].Length > 0)
                    {
                        T item = _queue[i][0];
                        // Shift all items down in the array (like removing the first element)
                        for (int j = 0; j < _queue[i].Length - 1; j++)
                        {
                            _queue[i][j] = _queue[i][j + 1];
                        }
                        Array.Resize(ref _queue[i], _queue[i].Length - 1);  // Remove last item (after shift)
                        return item;
                    }
                }

                throw new InvalidOperationException("Queue is empty.");
            }

            // Peek the item with the highest priority (without removing it)
            public T Peek()
            {
                for (int i = _maxPriority; i >= 0; i--)
                {
                    if (_queue[i].Length > 0)
                    {
                        return _queue[i][0];
                    }
                }

                throw new InvalidOperationException("Queue is empty.");
            }

            // Check if the priority queue is empty
            public bool IsEmpty()
            {
                for (int i = 0; i <= _maxPriority; i++)
                {
                    if (_queue[i].Length > 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            // Return the number of elements in the priority queue
            public int Size()
            {
                int size = 0;
                for (int i = 0; i <= _maxPriority; i++)
                {
                    size += _queue[i].Length;
                }
                return size;
            }

            public List<string> ToList()
            {
                var result = new List<string>();
                for (int i = _queue.Length - 1; i >= 0; i--)
                {
                    foreach (var item in _queue[i])
                    {
                        result.Add($"Priority {i}: {item}");
                    }
                }
                return result;
            }
        }
        public class VectorOfLists_PQ<T>
        {
            private List<T>[] _priorityLists;

            // Maximum priority level supported
            private int _maxPriority;

            // Constructor
            public VectorOfLists_PQ(int maxPriority)
            {
                // Validate max priority
                if (maxPriority < 0)
                    throw new ArgumentException("Max priority must be non-negative.");

                // Initialize the array of lists
                _maxPriority = maxPriority;
                _priorityLists = new List<T>[maxPriority + 1];

                // Initialize each list
                for (int i = 0; i <= maxPriority; i++)
                {
                    _priorityLists[i] = new List<T>();
                }
            }

            // Add an item with specified priority
            public void Enqueue(T item, int priority)
            {
                // Validate priority range
                if (priority < 0 || priority > _maxPriority)
                {
                    MessageBox.Show("Priority out of range.");
                    return;
                }

                // Add item to the appropriate priority list
                _priorityLists[priority].Add(item);
            }

            // Remove and return the highest priority item
            public T Dequeue()
            {
                // Find the highest non-empty priority list
                for (int i = _maxPriority; i >= 0; i--)
                {
                    if (_priorityLists[i].Count > 0)
                    {
                        // Get the first item in the list
                        T item = _priorityLists[i][0];

                        // Remove the first item
                        _priorityLists[i].RemoveAt(0);

                        return item;
                    }
                }

                // If no items found, throw an exception
                throw new InvalidOperationException("Queue is empty.");
            }

            // View the highest priority item without removing it
            public T Peek()
            {
                // Find the highest non-empty priority list
                for (int i = _maxPriority; i >= 0; i--)
                {
                    if (_priorityLists[i].Count > 0)
                    {
                        return _priorityLists[i][0];
                    }
                }

                // If no items found, throw an exception
                throw new InvalidOperationException("Queue is empty.");
            }

            // Check if the queue is empty
            public bool IsEmpty()
            {
                // Check if all priority lists are empty
                for (int i = 0; i <= _maxPriority; i++)
                {
                    if (_priorityLists[i].Count > 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            // Get the total number of items in the queue
            public int Size()
            {
                int totalSize = 0;

                // Sum the sizes of all priority lists
                for (int i = 0; i <= _maxPriority; i++)
                {
                    totalSize += _priorityLists[i].Count;
                }

                return totalSize;
            }

            // Optional: Clear the entire queue
            public void Clear()
            {
                // Clear each list in the array
                for (int i = 0; i <= _maxPriority; i++)
                {
                    _priorityLists[i].Clear();
                }
            }

            public List<string> ToList()
            {
                var result = new List<string>();
                for (int i = _priorityLists.Length - 1; i >= 0; i--)
                {
                    foreach (var item in _priorityLists[i])
                    {
                        result.Add($"Priority {i}: {item}");
                    }
                }
                return result;
            }
        }
        public class ListOfLists_PQ<T>
        {
            // Vector of Vectors, where each index represents a priority level.
            private List<List<T>> _queue;
            private int _maxPriority;

            // Constructor, initialize with max priority level.
            public ListOfLists_PQ(int maxPriority)
            {
                _maxPriority = maxPriority;
                _queue = new List<List<T>>(new List<T>[maxPriority + 1]); // +1 because index starts at 0
                for (int i = 0; i <= maxPriority; i++)
                {
                    _queue[i] = new List<T>();
                }
            }

            // Enqueue an item with a specified priority
            public void Enqueue(T item, int priority)
            {
                if (priority < 0 || priority > _maxPriority)
                {
                    MessageBox.Show("Priority out of range.");
                    return;
                }

                _queue[priority].Add(item);
            }

            // Dequeue the item with the highest priority (largest priority value)
            public T Dequeue()
            {
                // Find the highest non-empty priority list
                for (int i = _maxPriority; i >= 0; i--)
                {
                    if (_queue[i].Count > 0)
                    {
                        T item = _queue[i][0];
                        _queue[i].RemoveAt(0); // Remove the item
                        return item;
                    }
                }

                throw new InvalidOperationException("Queue is empty.");
            }

            // Peek the item with the highest priority (without removing it)
            public T Peek()
            {
                for (int i = _maxPriority; i >= 0; i--)
                {
                    if (_queue[i].Count > 0)
                    {
                        return _queue[i][0];
                    }
                }

                throw new InvalidOperationException("Queue is empty.");
            }

            // Check if the priority queue is empty
            public bool IsEmpty()
            {
                for (int i = 0; i <= _maxPriority; i++)
                {
                    if (_queue[i].Count > 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            // Return the number of elements in the priority queue
            public int Size()
            {
                int size = 0;
                for (int i = 0; i <= _maxPriority; i++)
                {
                    size += _queue[i].Count;
                }
                return size;
            }

            public List<string> ToList()
            {
                var result = new List<string>();
                for (int i = _queue.Count - 1; i >= 0; i--)
                {
                    foreach (var item in _queue[i])
                    {
                        result.Add($"Priority {i}: {item}");
                    }
                }
                return result;
            }
        }
        public class ListOfVectors_PQ<T>
        {
            private List<T[]> _queue;
            private int _maxPriority;

            public ListOfVectors_PQ(int maxPriority)
            {
                _maxPriority = maxPriority;
                _queue = new List<T[]>(maxPriority + 1);
                for (int i = 0; i <= maxPriority; i++)
                {
                    _queue.Add(new T[0]);
                }
            }

            public void Enqueue(T item, int priority)
            {
                if (priority < 0 || priority > _maxPriority)
                {
                    MessageBox.Show("Priority out of range.");
                    return;
                }

                // Create a new array with increased size and copy existing elements
                T[] currentArray = _queue[priority];
                Array.Resize(ref currentArray, currentArray.Length + 1);
                currentArray[currentArray.Length - 1] = item;
                _queue[priority] = currentArray;
            }

            public T Dequeue()
            {
                for (int i = _maxPriority; i >= 0; i--)
                {
                    if (_queue[i].Length > 0)
                    {
                        T item = _queue[i][0];

                        // Create a new smaller array to remove the first element
                        T[] currentArray = _queue[i];
                        T[] newArray = new T[currentArray.Length - 1];

                        // Copy elements after the first one
                        Array.Copy(currentArray, 1, newArray, 0, newArray.Length);

                        _queue[i] = newArray;
                        return item;
                    }
                }
                throw new InvalidOperationException("Queue is empty.");
            }

            // Rest of the methods remain the same as in your original implementation
            public T Peek()
            {
                for (int i = _maxPriority; i >= 0; i--)
                {
                    if (_queue[i].Length > 0)
                    {
                        return _queue[i][0];
                    }
                }
                throw new InvalidOperationException("Queue is empty.");
            }

            public bool IsEmpty()
            {
                for (int i = 0; i <= _maxPriority; i++)
                {
                    if (_queue[i].Length > 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            public int Size()
            {
                int size = 0;
                for (int i = 0; i <= _maxPriority; i++)
                {
                    size += _queue[i].Length;
                }
                return size;
            }

            public List<string> ToList()
            {
                var result = new List<string>();
                for (int i = _queue.Count - 1; i >= 0; i--)
                {
                    foreach (var item in _queue[i])
                    {
                        result.Add($"Priority {i}: {item}");
                    }
                }
                return result;
            }

        }
   
    }

}
