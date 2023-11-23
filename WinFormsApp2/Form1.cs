namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<char> letters = new List<char>();
        private bool editing = false;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (editing) { return; }
            editing = true;

            int pos = ((lettersBox.SelectionStart + 1) / 2) * 2;
            letters.Clear();
            foreach (char c in lettersBox.Text.ToLower())
            {
                if (c != ' ' && c != ',' && !letters.Contains(c))
                {
                    letters.Add(c);
                }
            }
            lettersBox.Text = "";
            foreach (char c in letters)
            {
                lettersBox.Text += c + ",";
            }
            lettersBox.SelectionStart = pos;
            lettersBox.SelectionLength = 0;

            editing = false;
        }
        private void lettersBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar !=  (char)8) { return; }
            if (editing) { return; }
            editing = true;
            int pos = (lettersBox.SelectionStart + 1) / 2 - 1;
            if (pos < 0) { editing = false; return; };
            letters.Remove(letters[pos]);
            e.Handled = true;
            string res = "";
            foreach (char c in letters) { res += c + ","; }
            lettersBox.Text = res;
            lettersBox.SelectionStart = pos * 2;
            lettersBox.SelectionLength = 0;
            editing = false;
        }
    }
}