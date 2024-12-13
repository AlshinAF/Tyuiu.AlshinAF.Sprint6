using System.Security.Cryptography;
using Tyuiu.AlshinAF.Sprint6.Task3.V19.Lib;
namespace Tyuiu.AlshinAF.Sprint6.Task3.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] {
            { 4, 32, -20, 27, 21 },
            { 17, 15, -1, -2, -1 },
            { -3, 18, 12, -10, 29 },
            { 7, -15, 2, -8, 12 },
            { -10, 25, 5, 27, 21 } };
        private void Form1_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            dataGridView1.ColumnCount = columns;
            dataGridView1.RowCount = rows;
            for (int i = 0; i < columns; i++) //задаем ширину столбцов
            {
                dataGridView1.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++) //заполняем сетку данными из массива
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] res = ds.Calculate(mtrx);
                int rows = res.GetUpperBound(0) + 1;
                int columns = res.Length / rows;
                dataGridView2.ColumnCount = columns;
                dataGridView2.RowCount = rows;
                for (int i = 0; i < columns; i++) //задаем ширину столбцов
                {
                    dataGridView2.Columns[i].Width = 25;
                }
                for (int i = 0; i < rows; i++) //заполняем сетку данными из массива
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridView2.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Введены неверны данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
