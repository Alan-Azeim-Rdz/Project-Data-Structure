using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Data_Structure.Formularios
{
    public partial class Secuential_and_binary : Form
    {
        private int[] data;
        public Secuential_and_binary()
        {
            InitializeComponent();
        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            // Separar los datos por comas y convertirlos en un arreglo de enteros
            data = txtNewNumber.Text.Split(',').Select(int.Parse).ToArray();

            // Limpiar el ListView antes de agregar los nuevos elementos
            lstNumbers.Items.Clear();

            // Agregar los elementos al ListView
            foreach (var num in data)
            {
                lstNumbers.Items.Add(num.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Leer el número a buscar desde el TextBox
            int key = Convert.ToInt32(txtKey.Text);
            string searchMethod = cmbSearchMethod.SelectedItem.ToString();
            int result = -1;



            switch (searchMethod)
            {
                case "Secuencial":
                    result = Search_Algorithms.SequentialSearch(data, key);
                    break;

                case "Binaria":
                    result = Search_Algorithms.BinarySearch(data, key);
                    break;

                default:
                    MessageBox.Show("Método de búsqueda no válido.");
                    return;
            }

            // Mostrar el resultado
            if (result != -1)
            {
                MessageBox.Show("Elemento encontrado en la posición " + result);
            }
            else
            {
                MessageBox.Show("Elemento no encontrado.");
            }
        }
    }
}
