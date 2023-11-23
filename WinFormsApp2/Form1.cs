namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            string path = filePath.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("Soubor nelze otevøít", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string content;
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.UTF8))
            {
                content = sr.ReadToEnd();
            }

            contentEditor.Text = content;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string path = filePath.Text;
            string content = contentEditor.Text;


            using (StreamWriter sw = new StreamWriter(path, appendOption.Checked))
            {
                sw.Write(content);
                sw.Flush();
            }
        }
    }
}