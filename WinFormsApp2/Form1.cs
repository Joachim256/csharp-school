namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) { return; }

            labelFilename.Text = openFileDialog1.FileName.Split("\\").Last();
            labelFilepath.Text = openFileDialog1.FileName;
            FileInfo fi = new FileInfo(openFileDialog1.FileName);
            labelSize.Text = fi.Length.ToString() + " bytù";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelFilename.Text = labelFilepath.Text = labelSize.Text = "";
        }
    }
}