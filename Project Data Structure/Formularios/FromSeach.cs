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
    public partial class FromSeach : Form
    {
        public FromSeach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Secuential_and_binary secuential_And_Binary = new Secuential_and_binary();
            secuential_And_Binary.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
