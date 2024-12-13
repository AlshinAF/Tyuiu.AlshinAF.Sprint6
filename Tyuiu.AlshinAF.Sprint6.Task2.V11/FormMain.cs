using Tyuiu.AlshinAF.Sprint6.Task2.V11;
using Tyuiu.AlshinAF.Sprint6.Task2.V11.Lib;
namespace Tyuiu.AlshinAF.Sprint6.Task2.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBox1.Text);
                int stopStep = Convert.ToInt32(textBox2.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridView1.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    startStep++;
                
                }

            }
            catch
            {
                MessageBox.Show("¬ведены неверны данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
