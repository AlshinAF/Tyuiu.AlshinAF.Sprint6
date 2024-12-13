using Tyuiu.AlshinAF.Sprint6.Task4.V19.Lib;
namespace Tyuiu.AlshinAF.Sprint6.Task4.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
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
                textBox3.Text = "";
                for (int i = 0; i <= len - 1; i++)
                {
                    textBox3.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверны данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBox3.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
