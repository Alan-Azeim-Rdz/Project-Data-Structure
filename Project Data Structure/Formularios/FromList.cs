using Project_Data_Structure.Codes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project_Data_Structure.Codes.List;

namespace Project_Data_Structure.Formularios
{
    public partial class FromList : Form
    {
        LinkedList linkedList;
        DoublyLinkedList doublyLinkedList;
        CircularLinkedList circularLinkedList;
        DoublyCircularLinkedList doublyCircularLinkedList;
        public FromList()
        {
            InitializeComponent();
            linkedList = new LinkedList();
            doublyLinkedList = new DoublyLinkedList();
            circularLinkedList = new CircularLinkedList();
            doublyCircularLinkedList = new DoublyCircularLinkedList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValue.Text, out int value))
            {
                string selectedList = cmbListType.SelectedItem.ToString();
                switch (selectedList)
                {
                    case "Simple Linked List":
                        linkedList.Add(new Node(value));
                        UpdateListBox(lstSimpleLinkedList, linkedList.GetHead());
                        break;
                    case "Doubly Linked List":
                        doublyLinkedList.Add(new DoublyNode(value));
                        UpdateListBox(lstSimpleLinkedList, doublyLinkedList.GetHead());
                        break;
                    case "Circular Linked List":
                        circularLinkedList.Add(new Node(value));
                        UpdateListBox(lstSimpleLinkedList, circularLinkedList.GetHead());
                        break;
                    case "Doubly Circular Linked List":
                        doublyCircularLinkedList.Add(new DoublyNode(value));
                        UpdateListBox(lstSimpleLinkedList, doublyCircularLinkedList.GetHead());
                        break;
                }

                txtValue.Clear();
                txtValue.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer value.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValue.Text, out int value))
            {
                string selectedList = cmbListType.SelectedItem.ToString();
                switch (selectedList)
                {
                    case "Simple Linked List":
                        linkedList.Remove(value);
                        UpdateListBox(lstSimpleLinkedList, linkedList.GetHead());
                        break;
                    case "Doubly Linked List":
                        doublyLinkedList.Remove(value);
                        UpdateListBox(lstSimpleLinkedList, doublyLinkedList.GetHead());
                        break;
                    case "Circular Linked List":
                        circularLinkedList.Remove(value);
                        UpdateListBox(lstSimpleLinkedList, circularLinkedList.GetHead());
                        break;
                    case "Doubly Circular Linked List":
                        doublyCircularLinkedList.Remove(value);
                        UpdateListBox(lstSimpleLinkedList, doublyCircularLinkedList.GetHead());
                        break;
                }
                txtValue.Clear();
                txtValue.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer value.");
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            string selectedList = cmbListType.SelectedItem.ToString();
            int count = 0;
            switch (selectedList)
            {
                case "Simple Linked List":
                    count = linkedList.Count();
                    break;
                case "Doubly Linked List":
                    count = doublyLinkedList.Count();
                    break;
                case "Circular Linked List":
                    count = circularLinkedList.Count();
                    break;
                case "Doubly Circular Linked List":
                    count = doublyCircularLinkedList.Count();
                    break;
            }
            MessageBox.Show($"The list has {count} elements.");
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValue.Text, out int value))
            {
                string selectedList = cmbListType.SelectedItem.ToString();
                bool contains = false;
                switch (selectedList)
                {
                    case "Simple Linked List":
                        contains = linkedList.Contains(value);
                        break;
                    case "Doubly Linked List":
                        contains = doublyLinkedList.Contains(value);
                        break;
                    case "Circular Linked List":
                        contains = circularLinkedList.Contains(value);
                        break;
                    case "Doubly Circular Linked List":
                        contains = doublyCircularLinkedList.Contains(value);
                        break;
                }
                if (contains)
                {
                    MessageBox.Show("The list contains the value.");
                }
                else
                {
                    MessageBox.Show("The list does not contain the value.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer value.");
            }
        
        }
        private void UpdateListBox(ListBox listBox, object head)
        {
            listBox.Items.Clear();

            if (head is Node headNode)
            {
                // Lista simple o lista simple circular
                Node current = headNode;

                do
                {
                    listBox.Items.Add(current.Value);
                    current = current.Next;
                } while (current != null && current != headNode); // Para manejar tanto listas simples como circulares
            }
            else if (head is DoublyNode headDoubleNode)
            {
                // Lista doble o lista doble circular
                DoublyNode current = headDoubleNode;

                do
                {
                    listBox.Items.Add(current.Value);
                    current = current.Next;
                } while (current != null && current != headDoubleNode);
            }
        }
    }
}
