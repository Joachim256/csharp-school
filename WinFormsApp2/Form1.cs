namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<String> dictionary = new List<String>();
        private List<char> letters = new List<char>();
        private bool editing = false;
        private List<String> foundWords = new List<String>();
        private void loadDictionary()
        {
            try
            {
                using (var sr = new StreamReader(@"..\..\..\..\slovnik.txt"))
                {
                    string word;
                    while ((word = sr.ReadLine()) != null)
                    {
                        dictionary.Add(word);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Nepodaøilo se otevøít soubor se slovníkem slov.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadDictionary();
        }
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
            updateList();
        }
        private void lettersBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8) { return; }
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
            updateList();
        }
        private void updateList()
        {
            filterDictionary();
            renderFoundWords();
        }
        private void filterDictionary()
        {
            foundWords.Clear();
            foreach (string word in dictionary)
            {
                bool badWord = false;
                foreach (char c in word)
                {
                    if (!letters.Contains(c))
                    {
                        badWord = true;
                        break;
                    }
                }
                if (!badWord)
                {
                    foundWords.Add(word);
                }
            }
        }
        private void renderFoundWords()
        {
            foundWordsListBox.Items.Clear();
            foreach (string word in foundWords)
            {
                foundWordsListBox.Items.Add(word);
            }
        }

        private void saveWords_Click(object sender, EventArgs e)
        {
            try
            {
                using (var sw = new StreamWriter(@"..\..\..\..\novy.txt"))
                {
                    sw.WriteLine(String.Join("\r\n", foundWords.ToArray()));
                }
                MessageBox.Show("Úspìšnì uloženo do souboru novy.txt", "Uloženo do souboru", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Nepodaøilo se uložit soubor.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}