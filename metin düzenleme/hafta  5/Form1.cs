namespace hafta__5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // label1.Text = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Times New Roman", 16);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Left;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Paste();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}