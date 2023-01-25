namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void disableMinimize_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.MinimizeBox = false;
        }

        private void enableMinimize_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.MinimizeBox = true;
        }

        private void blueForm_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackColor = Color.Blue;
        }

        private void grayForm_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackColor= Color.Gray;
        }

        private void whiteForm_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackColor = Color.White;
            textBox1.BackColor = Color.Yellow;
            textBox2.BackColor = Color.Yellow;
            textBox3.BackColor = Color.Yellow;
        }

        private void displayField_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text, "Text z políèka 1", MessageBoxButtons.OK);
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
        }

        private void disableAll_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }

        private void enableAll_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
        }

        private void copyField_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            textBox3.Text = textBox1.Text;
        }
    }
}