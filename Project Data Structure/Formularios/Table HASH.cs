using Project_Data_Structure.Codes;
using System;
using System.Collections;
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
    public partial class Table_HASH : Form
    {
        private Hash_TAble hashTable;
        public Table_HASH()
        {
            InitializeComponent();
            hashTable = new Hash_TAble(); // Instanciar la tabla hash
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int key = Math.Abs(txtKey.Text.GetHashCode()) % 10;// Usamos GetHashCode() para la clave (correo)
            string value = txtValue.Text;

            // Insertar en la tabla hash
            hashTable.Insert(key, value);
            MessageBox.Show("Usuario insertado o actualizado.");
            lstAlumnos.Items.Add(key + " " + value);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int key = Convert.ToInt32(TxtSearchId.Text);
            // Buscar en la tabla hash
            string result = hashTable.Search(key);
            if (result != null)
            {
                MessageBox.Show("Usuario encontrado " + result);
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }
    }
}
