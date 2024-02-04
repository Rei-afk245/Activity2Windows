namespace Activity2Windows
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length, yard, inches, foot;
            length = Convert.ToInt32(txtlength.Text);
            yard = (int)(length / 91.44);
            foot = (int)((length % 91.44) / 30.48);
            inches = (int)((length % 91.44) % 30.48 / 2.54);
            txtyard.Text = yard.ToString();
            txtfeet.Text = foot.ToString();
            txtinches.Text = inches.ToString();
        }
    }
}
