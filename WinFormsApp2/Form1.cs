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
        private void generateNumbers()
        {
            int[] numbers = {-1,-1,-1,-1};
            for (int i = 0; i < 4; i++)
            {
                int n = rng.Next(0, 10);
                if(Array.IndexOf(numbers, n) != -1) { i--; continue; }
                numbers[i] = n;
            }
            // fill in the numbers
            compN1.Text = numbers[0].ToString();
            compN2.Text = numbers[1].ToString();
            compN3.Text = numbers[2].ToString();
            compN4.Text = numbers[3].ToString();
        }
        private void newTurnBtn_Click(object sender, EventArgs e)
        {
            // parse inputs
            TextBox[] uinputs = { userN1, userN2, userN3, userN4 };
            int[] numbers = {0,0,0,0};
            for(int i = 0; i < 4; i++)
            {
                // check for empty textboxes
                if (uinputs[i].Text.Length == 0)
                {
                    MessageBox.Show("Hráè nezadal všechna èísla!", "", MessageBoxButtons.OK);
                    return;
                }
                numbers[i] = int.Parse(uinputs[i].Text);
            }
            // validate numbers
            if(!validateContextInputs(numbers)) { return; }
            // generate comp numbers
            generateNumbers();
            // bump turn count
            turnCount++;
            labelTurnCount.Text = "poèet tahù: " + turnCount.ToString();
            // todo: count matches, add points & display log
        }
        private bool validateContextInputs(int[] numbers)
        {
            var dict = new Dictionary<int, bool>() { {0, false}, {1, false}, {2, false}, {3, false}, {4, false}, {5, false}, {6, false}, {7, false}, {8, false}, {9, false} };
            foreach(int n in numbers)
            {
                if (dict[n] == true)
                {
                    MessageBox.Show("Èísla se nesmí opakovat!", "", MessageBoxButtons.OK);
                    return false;
                }
                else
                {
                    dict[n] = true;
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