using Tyuiu.AlshinAF.Sprint6.Task6.V18.Lib;
namespace Tyuiu.AlshinAF.Sprint6.Task6.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        private void button1_Click(object sender, EventArgs e)
        {
            string str = "n";
            textBoxResult.Text = ds.CollectTextFromFile(str, openFilePath);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath = openFileDialog1.FileName;
            textBoxLoadFromFile.Text = File.ReadAllText(openFilePath);
            groupBox1.Text = groupBox1.Text + " " + openFileDialog1.FileName;

        }

        private void textBoxLoadFromFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
