using Tyuiu.AlshinAF.Sprint6.Task5.V30.Lib;
namespace Tyuiu.AlshinAF.Sprint6.Task5.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\artal\source\repos\Tyuiu.AlshinAF.Sprint6\Tyuiu.AlshinAF.Sprint6.Task5.V30\bin\Debug\OutPutDataFileTask5.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Width = 20;
            dataGridView1.Columns[1].Width = 50;
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridView1.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
