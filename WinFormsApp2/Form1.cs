using System.ComponentModel;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int turnCount = 0;
        private int pointCount = 0;
        private Random rng = new Random();
        private int[] userNumbers = {0,0,0,0};
        private int[] compNumbers = {0,0,0,0};
        private Dictionary<int, bool> userNumberDict = new Dictionary<int, bool>() { { 0, false }, { 1, false }, { 2, false }, { 3, false }, { 4, false }, { 5, false }, { 6, false }, { 7, false }, { 8, false }, { 9, false } };
        private Dictionary<int, bool> compNumberDict = new Dictionary<int, bool>() { { 0, false }, { 1, false }, { 2, false }, { 3, false }, { 4, false }, { 5, false }, { 6, false }, { 7, false }, { 8, false }, { 9, false } };
        private void resetVars()
        {
            for(int i = 0; i < 10; i++) { userNumberDict[i] = false; compNumberDict[i] = false; }
        }
        private void generateNumbers()
        {
            for (int i = 0; i < 4; i++)
            {
                int n = rng.Next(0, 10);
                if(Array.IndexOf(compNumbers, n) != -1) { i--; continue; }
                compNumbers[i] = n;
                compNumberDict[n] = true;
            }
            // fill in the numbers
            compN1.Text = compNumbers[0].ToString();
            compN2.Text = compNumbers[1].ToString();
            compN3.Text = compNumbers[2].ToString();
            compN4.Text = compNumbers[3].ToString();
        }
        private void evaluateTurn()
        {
            // count matches
            int matches = 0;
            for(int i = 0; i < 10; i++)
            {
                if (userNumberDict[i] && compNumberDict[i])
                {
                    matches++;
                }
            }
            // add points
            pointCount += 10 * matches;
            labelPointCount.Text = "poèet bodù: " + pointCount;
            // log
            var langDict = new Dictionary<int, string>() { {0, "èísel"}, {1, "èíslo"}, {2, "èísla"}, {3, "èísla"}, {4, "èísla"} };
            logBox.Text += String.Format("\n{0}. tah\nhráèova èísla: {1}\nlosovaná èísla: {2}\nshoda – {3} {4} ({5} bodù)\n--------------------", turnCount, String.Join(", ", userNumbers), String.Join(", ", compNumbers), matches, langDict[matches], matches * 10);
        }
        private void newTurnBtn_Click(object sender, EventArgs e)
        {
            // reset vars
            resetVars();
            // parse inputs
            TextBox[] uinputs = { userN1, userN2, userN3, userN4 };
            for(int i = 0; i < 4; i++)
            {
                // check for empty textboxes
                if (uinputs[i].Text.Length == 0)
                {
                    MessageBox.Show("Hráè nezadal všechna èísla!", "", MessageBoxButtons.OK);
                    return;
                }
                userNumbers[i] = int.Parse(uinputs[i].Text);
            }
            // validate numbers
            if (!validateContextInputs()) { return; }
            // generate comp numbers
            generateNumbers();
            // bump turn count
            turnCount++;
            labelTurnCount.Text = "poèet tahù: " + turnCount.ToString();
            // evaluate and log
            evaluateTurn();
        }
        private bool validateContextInputs()
        {
            foreach(int n in userNumbers)
            {
                if (userNumberDict[n] == true)
                {
                    MessageBox.Show("Èísla se nesmí opakovat!", "", MessageBoxButtons.OK);
                    return false;
                }
                else
                {
                    userNumberDict[n] = true;
                }
            }
            return true;
        }
        private void validateInput(TextBox c, System.ComponentModel.CancelEventArgs eargs)
        {
            string n = c.Text;
            if(n.Length == 0) { return; }
            if(n.Length > 1 || n[0] < 0x30 || n[0] > 0x39)
            {
                eargs.Cancel = true;
                errorProvider1.SetError(c, "Zadejte èíslo od 0 do 9");
            }else{
                eargs.Cancel = false;
                errorProvider1.SetError(c, "");
            }
        }

        private void userN1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            validateInput(userN1, e);
        }

        private void userN2_Validating(object sender, CancelEventArgs e)
        {
            validateInput(userN2, e);
        }

        private void userN3_Validating(object sender, CancelEventArgs e)
        {
            validateInput(userN3, e);
        }

        private void userN4_Validating(object sender, CancelEventArgs e)
        {
            validateInput(userN4, e);
        }
    }
}