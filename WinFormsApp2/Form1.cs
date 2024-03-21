namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Label[] napisy = new Label[10];
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Label label = new Label();
                label.Location = new Point(10, 10 + i*20);
                label.Text = i.ToString();
                label.Click += Say;
                Controls.Add(label);
            }
        }
        private void Say(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            MessageBox.Show(l.Text);
        }
    }
}