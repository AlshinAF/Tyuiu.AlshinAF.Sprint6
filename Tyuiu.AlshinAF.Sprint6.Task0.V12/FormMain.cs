using Tyuiu.AlshinAF.Sprint6.Task0.V12;
using Tyuiu.AlshinAF.Sprint6.Task0.V12.Lib;
namespace Tyuiu.AlshinAF.Sprint6.Task0.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_AAF.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверны данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBoxTask_AAF_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged_AAF(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click_AAF(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы РППб-24-1 Альшин Артур Фаритович", "Сообщение");
        }

        private void textBoxVarX_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVarX_KeyPress_AAF(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 3)
            {
                e.Handled = true;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
