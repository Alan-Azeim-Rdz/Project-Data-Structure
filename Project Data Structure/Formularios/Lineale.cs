using Project_Data_Structure.Formularios;
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

namespace Project_Data_Structure
{
    public partial class Lineale : Form
    {
        public Lineale()
        {
            InitializeComponent();
        }

        private void BtnQueue_Click(object sender, EventArgs e)
        {
            ElectionQueue election = new ElectionQueue();
            election.Show();
        }

        private void BtnStack_Click(object sender, EventArgs e)
        {
            FromStack fromStack = new FromStack();
            fromStack.Show();
        }

        private void Btnlists_Click(object sender, EventArgs e)
        {
            FromList fromList = new FromList();
            fromList.Show();
        }
    }
}
