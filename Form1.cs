namespace SOMA_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            siste1 obs = new siste1();
            obs.num1=double.Parse(textBox1num1.Text);
            obs.num2 = double.Parse(textBox1num1.Text);
            obs.soma();

            label2calc.Text = Convert.ToString(obs.soma());
        }

        private void textBox1num1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2num2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2calc_Click(object sender, EventArgs e)
        {

        }

        private void button1sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}