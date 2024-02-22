namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void render()
        {
            var grafika = splitContainer1.Panel1.CreateGraphics();
            grafika.Clear(Color.White);
            var pero = new Pen(Color.Red, 2);
            Point origin = new Point(0, 0);

            int nlines = (int)nLines.Value;
            int width = splitContainer1.Panel1.Width;
            int height = splitContainer1.Panel1.Height;

            for (int i = 0; i < nlines - 1; i++)
            {
                int x = (i * width / (nlines - 1));
                grafika.DrawLine(pero, origin, new Point(x, height));
            }
            for (int i = 0; i < nlines - 1; i++)
            {
                int y = (i * height / (nlines - 1));
                grafika.DrawLine(pero, origin, new Point(width, y));
            }
            // corner line
            grafika.DrawLine(pero, origin, new Point(width, height));
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            render();
        }
        private void nLines_ValueChanged(object sender, EventArgs e)
        {
            render();
        }
    }
}
