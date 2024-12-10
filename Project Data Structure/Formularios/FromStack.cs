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
using static Project_Data_Structure.Codes.stack;

namespace Project_Data_Structure.Formularios
{
    public partial class FromStack : Form
    {
        private DynamicStack dynamicStack;
        private StaticStack staticStack;
        public FromStack()
        {
            InitializeComponent();
            dynamicStack = new DynamicStack();
            staticStack = new StaticStack();
            ComboBoxStack.SelectedIndex = 0;
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtStackValue.Text, out int value))
            {
                string selectedList = ComboBoxStack.SelectedItem.ToString();
                switch (selectedList)
                {
                    case "Static":
                        staticStack.Push(int.Parse(txtStackValue.Text));
                        UpdateStacks();
                        break;
                    case "Dynamic":
                        Node newNode = new Node(Convert.ToInt32(txtStackValue.Text));
                        dynamicStack.Push(newNode);
                        UpdateStacks();
                        break;
                    default:
                        MessageBox.Show("Please select a stack type.");
                        break;
                }

                txtStackValue.Clear();
                txtStackValue.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer value.");
            }
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            string selectedList = ComboBoxStack.SelectedItem.ToString();
            switch (selectedList)
            {
                case "Static":
                    MessageBox.Show("The poped value is: " + staticStack.Pop());
                    UpdateStacks();
                    break;
                case "Dynamic":
                    //dynamicStack.Pop();
                    //show the poped value in a message box
                    Node poppedNode = dynamicStack.Pop();
                    MessageBox.Show("Element removed from the dynamic stack: " + poppedNode.Value);
                    UpdateStacks();
                    break;
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            string selectedList = ComboBoxStack.SelectedItem.ToString();
            switch (selectedList)
            {
                case "Static":
                    MessageBox.Show("The peeked value is: " + staticStack.Peek());
                    break;
                case "Dynamic":
                    MessageBox.Show("The peeked value is: " + dynamicStack.Peek().Value);
                    break;
            }
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            string selectedList = ComboBoxStack.SelectedItem.ToString();
            switch (selectedList)
            {
                case "Static":
                    MessageBox.Show("The size of the stack is: " + staticStack.Size());
                    break;
                case "Dynamic":
                    MessageBox.Show("The size of the stack is: " + dynamicStack.Size());
                    break;
            }
        }

        private void UpdateStacks()
        {
            lstStaticStack.Items.Clear();
            string selectedList = ComboBoxStack.SelectedItem.ToString();
            if (selectedList == "Static")
            {
                // Actualizar la pila estática
                StaticStack temporal = new StaticStack();
                string elemento;

                // Mostrar los elementos en la pila estática
                while (!staticStack.IsEmpty())
                {
                    elemento = staticStack.Pop().ToString();
                    lstStaticStack.Items.Add(elemento);
                    temporal.Push(int.Parse(elemento));
                }

                // Restaurar los elementos en la pila original
                while (!temporal.IsEmpty())
                {
                    staticStack.Push(int.Parse(temporal.Pop().ToString()));
                }
            }
            else
            {
                Node currentNode = dynamicStack.Peek();
                while (currentNode != null)
                {
                    lstStaticStack.Items.Add(currentNode.Value);
                    currentNode = currentNode.Next;
                }
            }
        }

        private void ComboBoxStack_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstStaticStack.Items.Clear();
            UpdateStacks();
        }

    }
}
