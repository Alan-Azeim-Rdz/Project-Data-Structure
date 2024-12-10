using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project_Data_Structure.Codes.QueueClass;

namespace Project_Data_Structure.Formularios
{
    public partial class QueuePriorityFrom : Form
    {
        private VectorOfVectors_PQ<int> vectorOfVectorsPQ;
        private VectorOfLists_PQ<int> vectorOfListsPQ;
        private ListOfLists_PQ<int> listOfListsPQ;
        private ListOfVectors_PQ<int> listOfVectorsPQ;
        public QueuePriorityFrom()
        {
            InitializeComponent();
            vectorOfVectorsPQ = new VectorOfVectors_PQ<int>(3);
            vectorOfListsPQ = new VectorOfLists_PQ<int>(3);
            listOfListsPQ = new ListOfLists_PQ<int>(3);
            listOfVectorsPQ = new ListOfVectors_PQ<int>(3);
        }

        private void btnEnqueuePQ_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TextValue.Text, out int value))
            {
                int priority = Convert.ToInt32(txtPriority.Text);
                string selectedList = cmbTypeOfPQ.SelectedItem.ToString();
                switch (selectedList)
                {
                    case "Vector Of Vectors":
                        vectorOfVectorsPQ.Enqueue(value, priority);
                        UpdateListBox(ListBoxData, vectorOfVectorsPQ);
                        break;
                    case "Vector Of Lists":
                        vectorOfListsPQ.Enqueue(value, priority);
                        UpdateListBox(ListBoxData, vectorOfListsPQ);
                        break;
                    case "List Of Vectors":
                        listOfVectorsPQ.Enqueue(value, priority);
                        UpdateListBox(ListBoxData, listOfVectorsPQ);
                        break;
                    case "List Of Lists":
                        listOfListsPQ.Enqueue(value, priority);
                        UpdateListBox(ListBoxData, listOfListsPQ);
                        break;
                    default:
                        MessageBox.Show("Please select a queue type.");
                        break;
                }

                TextValue.Clear();
                TextValue.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer value.");
            }
        }

        private void btnDequeuePQ_Click(object sender, EventArgs e)
        {
            string selectedList = cmbTypeOfPQ.SelectedItem.ToString();
            switch (selectedList)
            {
                case "Vector Of Vectors":
                    if (vectorOfVectorsPQ.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value removed from the queue is: " + vectorOfVectorsPQ.Dequeue());
                    UpdateListBox(ListBoxData, vectorOfVectorsPQ);
                    break;
                case "Vector Of Lists":
                    if (vectorOfListsPQ.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value removed from the queue is: " + vectorOfListsPQ.Dequeue());
                    UpdateListBox(ListBoxData, vectorOfListsPQ);
                    break;
                case "List Of Vectors":
                    if (listOfVectorsPQ.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value removed from the queue is: " + listOfVectorsPQ.Dequeue());
                    UpdateListBox(ListBoxData, listOfVectorsPQ);
                    break;
                case "List Of Lists":
                    if (listOfListsPQ.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value removed from the queue is: " + listOfListsPQ.Dequeue());
                    UpdateListBox(ListBoxData, listOfListsPQ);
                    break;
            }
        }

        private void btnPeekPQ_Click(object sender, EventArgs e)
        {
            string selectedList = cmbTypeOfPQ.SelectedItem.ToString();
            switch (selectedList)
            {
                case "Vector Of Vectors":
                    if (vectorOfVectorsPQ.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value at the front of the queue is: " + vectorOfVectorsPQ.Peek());
                    break;
                case "Vector Of Lists":
                    if (vectorOfListsPQ.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value at the front of the queue is: " + vectorOfListsPQ.Peek());
                    break;
                case "List Of Vectors":
                    if (listOfVectorsPQ.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value at the front of the queue is: " + listOfVectorsPQ.Peek());
                    break;
                case "List Of Lists":
                    if (listOfListsPQ.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value at the front of the queue is: " + listOfListsPQ.Peek());
                    break;
            }
        }

        private void btnSizePQ_Click(object sender, EventArgs e)
        {
            string selectedList = cmbTypeOfPQ.SelectedItem.ToString();
            switch (selectedList)
            {
                case "Vector Of Vectors":
                    MessageBox.Show("The size of the queue is: " + vectorOfVectorsPQ.Size());
                    break;
                case "Vector Of Lists":
                    MessageBox.Show("The size of the queue is: " + vectorOfListsPQ.Size());
                    break;
                case "List Of Vectors":
                    MessageBox.Show("The size of the queue is: " + listOfVectorsPQ.Size());
                    break;
                case "List Of Lists":
                    MessageBox.Show("The size of the queue is: " + listOfListsPQ.Size());
                    break;
            }
        }
        private void UpdateListBox<T>(ListBox listBox, T queue) where T : class
        {
            listBox.Items.Clear();
            var items = (queue as dynamic).ToList();
            listBox.Items.AddRange(items.ToArray());
        }

    }
}
