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
    public partial class FromQueue : Form
    {
        StaticQueue staticQueue;
        DynamicQueue dynamicQueue;
        CircularQueue circularQueue;


        public FromQueue()
        {
            InitializeComponent();
            staticQueue = new StaticQueue(8);
            dynamicQueue = new DynamicQueue();
            circularQueue = new CircularQueue(8);

        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtNumberAdd.Text, out int value))
            {
                string selectedList = ComboboxType.SelectedItem.ToString();
                switch (selectedList)
                {
                    case "Static":
                        staticQueue.Enqueue(value);
                        Updeat(staticQueue, lstQueues);
                        LabelSizeArreglo.Text = Convert.ToString(staticQueue.Size());
                        break;
                    case "Dynamic":
                        dynamicQueue.Enqueue(value);
                        Updeat(dynamicQueue, lstQueues);
                        LabelSizeArreglo.Text = Convert.ToString(dynamicQueue.Size());
                        break;
                    case "Circular":
                        circularQueue.Enqueue(value);
                        Updeat(circularQueue, lstQueues);
                        LabelSizeArreglo.Text = Convert.ToString(circularQueue.Size());
                        break;
                    default:
                        MessageBox.Show("Please select a queue type.");
                        break;
                }
               
                TxtNumberAdd.Clear();
                TxtNumberAdd.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer value.");
            }
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedList = ComboboxType.SelectedItem.ToString();

                switch (selectedList)
                {
                    case "Static":
                        if (staticQueue.IsEmpty()) // Método personalizado para verificar si la cola está vacía
                        {
                            MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        MessageBox.Show("The value removed from the queue is: " + staticQueue.Dequeue());
                        Updeat(staticQueue, lstQueues);
                        LabelSizeArreglo.Text = Convert.ToString(staticQueue.Size());
                        break;

                    case "Dynamic":
                        if (dynamicQueue.IsEmpty())
                        {
                            MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        MessageBox.Show("The value removed from the queue is: " + dynamicQueue.Dequeue());
                        Updeat(dynamicQueue, lstQueues);
                        LabelSizeArreglo.Text = Convert.ToString(dynamicQueue.Size());
                        break;

                    case "Circular":
                        if (circularQueue.IsEmpty())
                        {
                            MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        MessageBox.Show("The value removed from the queue is: " + circularQueue.Dequeue());
                        Updeat(circularQueue, lstQueues);
                        LabelSizeArreglo.Text = Convert.ToString(circularQueue.Size());
                        break;
                }

                TxtNumberAdd.Clear();
                TxtNumberAdd.Focus();
            }
            catch (Exception ex)
            {
                // Manejo general de errores inesperados
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPeek_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedList = ComboboxType.SelectedItem.ToString();
                switch (selectedList)
                {
                    case "Static":
                        if (staticQueue.IsEmpty())
                        {
                            MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        MessageBox.Show("The value at the front of the queue is: " + staticQueue.Peek());
                        break;
                    case "Dynamic":
                        if (dynamicQueue.IsEmpty())
                        {
                            MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        MessageBox.Show("The value at the front of the queue is: " + dynamicQueue.Peek());
                        break;
                    case "Circular":
                        if (circularQueue.IsEmpty())
                        {
                            MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        MessageBox.Show("The value at the front of the queue is: " + circularQueue.Peek());
                        break;
                }
            }
            catch (Exception ex)
            {
                // Manejo general de errores inesperados
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSize_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedList = ComboboxType.SelectedItem.ToString();
                switch (selectedList)
                {
                    case "Static":
                        MessageBox.Show("The size of the queue is: " + staticQueue.Size());
                        break;
                    case "Dynamic":
                        MessageBox.Show("The size of the queue is: " + dynamicQueue.Size());
                        break;
                    case "Circular":
                        MessageBox.Show("The size of the queue is: " + circularQueue.Size());
                        break;
                }
            }
            catch (Exception ex)
            {
                // Manejo general de errores inesperados
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Updeat(object queue, ListBox listBox)
        {
            listBox.Items.Clear();

            if (queue is StaticQueue staticQueue)
            {
                StaticQueue tempQueue = new StaticQueue(staticQueue.Capacity);

                while (!staticQueue.IsEmpty())
                {
                    int value = staticQueue.Dequeue();
                    listBox.Items.Add(value);
                    tempQueue.Enqueue(value);
                }

                // Restaurar los elementos a la cola estática
                while (!tempQueue.IsEmpty())
                {
                    staticQueue.Enqueue(tempQueue.Dequeue());
                }
            }
            else if (queue is DynamicQueue dynamicQueue)
            {
                DynamicQueue tempQueue = new DynamicQueue();

                while (!dynamicQueue.IsEmpty())
                {
                    int value = dynamicQueue.Dequeue();
                    listBox.Items.Add(value);
                    tempQueue.Enqueue(value);
                }

                // Restaurar los elementos a la cola dinámica
                while (!tempQueue.IsEmpty())
                {
                    dynamicQueue.Enqueue(tempQueue.Dequeue());
                }
            }
            else if (queue is CircularQueue circularQueue)
            {
                CircularQueue tempQueue = new CircularQueue(circularQueue.Capacity);

                while (!circularQueue.IsEmpty())
                {
                    int value = circularQueue.Dequeue();
                    listBox.Items.Add(value);
                    tempQueue.Enqueue(value);
                }

                // Restaurar los elementos a la cola circular
                while (!tempQueue.IsEmpty())
                {
                    circularQueue.Enqueue(tempQueue.Dequeue());
                }
            }
        }

        private void ComboboxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboboxType.SelectedItem)
            {
                case "Static":
                    LabelSizeArreglo.Text = Convert.ToString(staticQueue.Size());
                    return;
                case "Dynamic":
                    LabelSizeArreglo.Text = Convert.ToString(dynamicQueue.Size());
                    return ;
                case "Circular":
                    LabelSizeArreglo.Text = Convert.ToString(circularQueue.Size());
                    return ;

            }
        }
    }
}
