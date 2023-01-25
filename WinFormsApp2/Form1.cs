namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void randomizeButton()
        {
            int w = Form1.ActiveForm.ClientSize.Width;
            int h = Form1.ActiveForm.ClientSize.Height;

            Random r = new Random();
            int x = r.Next(0, w - 66);
            int y = r.Next(0, h - 15);

            label1.Location = new Point(x, y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            randomizeButton();
        }
    }
}