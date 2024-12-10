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
    public partial class ElectionQueue : Form
    {
        public ElectionQueue()
        {
            InitializeComponent();
        }

        private void BtnQueue_Click(object sender, EventArgs e)
        {
            FromQueue fromQueue = new FromQueue();
            fromQueue.Show();
        }

        private void BtnPriority_Click(object sender, EventArgs e)
        {
            QueuePriorityFrom queuePriorityFrom = new QueuePriorityFrom();
            queuePriorityFrom.Show();
        }

        private void BtnDouble_Click(object sender, EventArgs e)
        {
            QueueDoubleFrom queueDoubleFrom = new QueueDoubleFrom();
            queueDoubleFrom.Show();
        }
    }
}
