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

namespace Project_Data_Structure.Formularios
{
    public partial class NoLineal : Form
    {
        public NoLineal()
        {
            InitializeComponent();
        }

        private void BtnTree_Click(object sender, EventArgs e)
        {
            Binary_TreesFrom binary_TreesFrom = new Binary_TreesFrom();
            binary_TreesFrom.Show();
        }

        private void BtnGrafos_Click(object sender, EventArgs e)
        {
            FromGrhaphs graphs = new FromGrhaphs();
           graphs.Show();
        }
    }
}
