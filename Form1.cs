namespace modul3
{
    public partial class Form1 : Form
    {
        int A;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "0";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            A = int.Parse(output.Text);
            output.Text = "";
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            output.Text = (A + int.Parse(output.Text)).ToString();
        }
    }
}
