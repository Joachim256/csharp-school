namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 addtextForm = new Form2();

            if (addtextForm.ShowDialog() != DialogResult.OK) { return; }

            if(textarea.Text != "") { textarea.Text += "\r\n"; }
            textarea.Text += addtextForm.AddText;
        }
    }
}
