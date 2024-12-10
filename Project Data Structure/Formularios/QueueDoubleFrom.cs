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
    public partial class QueueDoubleFrom : Form
    {
        DoubleEndedStaticQueue doubleEndedStaticQueue;
        DoubleEndedDynamicQueue doubleEndedDynamicQueue;
        public QueueDoubleFrom()
        {
            InitializeComponent();
            doubleEndedStaticQueue = new DoubleEndedStaticQueue(8);
            doubleEndedDynamicQueue = new DoubleEndedDynamicQueue();
        }

        private void btnInserFront_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDQValue.Text, out int value))
            {
                string selectedList = cmbDQType.SelectedItem.ToString();
                switch (selectedList)
                {
                    case "Static":
                        doubleEndedStaticQueue.InsertFront(value); // Insertar al final de la cola estática

                        // Limpiar y actualizar el ListBox para la cola estática
                        ListQueueData.Items.Clear();
                        foreach (var item in doubleEndedStaticQueue.GetQueueElements()) // Obtener elementos de la cola estática
                        {
                            ListQueueData.Items.Add(item);  // Agregar cada elemento al ListBox de la cola estática
                        }
                        break;
                    case "Dynamic":
                        doubleEndedDynamicQueue.InsertFront(value); // Inserta el valor al frente de la cola dinámica

                        // Limpiar y actualizar el ListBox para la cola dinámica
                        ListQueueData.Items.Clear();
                        foreach (var item in doubleEndedDynamicQueue.GetQueueElements())
                        {
                            ListQueueData.Items.Add(item);  // Agregar cada elemento al ListBox de la cola dinámica
                        }
                        break;
                    default:
                        MessageBox.Show("Please select a double queue type.");
                        break;
                }

                txtDQValue.Clear();
                txtDQValue.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer value.");
            }
        }

        private void btnGetFront_Click(object sender, EventArgs e)
        {
            string selectedList = cmbDQType.SelectedItem.ToString();
            switch (selectedList)
            {
                case "Static":
                    if (doubleEndedStaticQueue.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value at the front of the queue is: " + doubleEndedStaticQueue.GetFront());
                    break;
                case "Dynamic":
                    if (doubleEndedDynamicQueue.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value at the front of the queue is: " + doubleEndedDynamicQueue.GetFront());
                    break;
            }
        }
        

        private void btnInsertRear_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDQValue.Text, out int value))
            {
                string selectedList = cmbDQType.SelectedItem.ToString();
                switch (selectedList)
                {
                    case "Static":
                        doubleEndedStaticQueue.InsertRear(value); // Insertar al final de la cola estática
                        // Limpiar y actualizar el ListBox para la cola estática
                        ListQueueData.Items.Clear();
                        foreach (var item in doubleEndedStaticQueue.GetQueueElements()) // Obtener elementos de la cola estática
                        {
                            ListQueueData.Items.Add(item);  // Agregar cada elemento al ListBox de la cola estática
                        }
                        break;
                    case "Dynamic":
                        doubleEndedDynamicQueue.InsertRear(value); // Inserta el valor al frente de la cola dinámica
                        // Limpiar y actualizar el ListBox para la cola dinámica
                        ListQueueData.Items.Clear();
                        foreach (var item in doubleEndedDynamicQueue.GetQueueElements())
                        {
                            ListQueueData.Items.Add(item);  // Agregar cada elemento al ListBox de la cola dinámica
                        }
                        break;
                    default:
                        MessageBox.Show("Please select a double queue type.");
                        break;
                }
                txtDQValue.Clear();
                txtDQValue.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer value.");
            }
        }

        private void btnGetRear_Click(object sender, EventArgs e)
        {
            string selectedList = cmbDQType.SelectedItem.ToString();
            switch (selectedList)
            {
                case "Static":
                    if (doubleEndedStaticQueue.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value at the rear of the queue is: " + doubleEndedStaticQueue.GetRear());
                    break;
                case "Dynamic":
                    if (doubleEndedDynamicQueue.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to peek.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value at the rear of the queue is: " + doubleEndedDynamicQueue.GetRear());
                    break;
            }
        }

        private void btnDeleteFront_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedList = cmbDQType.SelectedItem.ToString();
                switch (selectedList)
                {
                    case "Static":
                        if (doubleEndedStaticQueue.IsEmpty())
                        {
                            MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        MessageBox.Show("The value removed from the queue is: " + doubleEndedStaticQueue.DeleteFront());
                        ListQueueData.Items.Clear();
                        foreach (var item in doubleEndedStaticQueue.GetQueueElements())
                        {
                            ListQueueData.Items.Add(item);
                        }
                        break;
                    case "Dynamic":
                        if (doubleEndedDynamicQueue.IsEmpty())
                        {
                            MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        MessageBox.Show("The value removed from the queue is: " + doubleEndedDynamicQueue.DeleteFront());
                        ListQueueData.Items.Clear();
                        foreach (var item in doubleEndedDynamicQueue.GetQueueElements())
                        {
                            ListQueueData.Items.Add(item);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                // Manejo general de errores inesperados
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDoubleQSize_Click(object sender, EventArgs e)
        {
            string selectedList = cmbDQType.SelectedItem.ToString();
            switch (selectedList)
            {
                case "Static":
                    MessageBox.Show("The size of the queue is: " + doubleEndedStaticQueue.Size());
                    break;
                case "Dynamic":
                    MessageBox.Show("The size of the queue is: " + doubleEndedDynamicQueue.Size());
                    break;
            }
        }

        private void btnDeleteRear_Click(object sender, EventArgs e)
        {
            string selectedList = cmbDQType.SelectedItem.ToString();
            switch (selectedList)
            {
                case "Static":
                    if (doubleEndedStaticQueue.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value removed from the queue is: " + doubleEndedStaticQueue.DeleteRear());
                    ListQueueData.Items.Clear();
                    foreach (var item in doubleEndedStaticQueue.GetQueueElements())
                    {
                        ListQueueData.Items.Add(item);
                    }
                    break;
                case "Dynamic":
                    if (doubleEndedDynamicQueue.IsEmpty())
                    {
                        MessageBox.Show("The queue is empty. There are no items to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show("The value removed from the queue is: " + doubleEndedDynamicQueue.DeleteRear());
                    ListQueueData.Items.Clear();
                    foreach (var item in doubleEndedDynamicQueue.GetQueueElements())
                    {
                        ListQueueData.Items.Add(item);
                    }
                    break;
            }
        }
    }
}
