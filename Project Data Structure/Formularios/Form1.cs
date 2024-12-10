using Project_Data_Structure.Formularios;

namespace Project_Data_Structure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDataStructure_Click(object sender, EventArgs e)
        {
            Lineale lineale = new Lineale();
            lineale.Show();


        }

        private void BtnDataStructureNotLineal_Click(object sender, EventArgs e)
        {
            NoLineal noLineal = new NoLineal();
            noLineal.Show();
        }

        private void BtnSearchAlgorithms_Click(object sender, EventArgs e)
        {
            FromSeach fromSeach = new FromSeach();
            fromSeach.Show();
        }
    }
}
