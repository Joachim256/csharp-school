using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calc1Btn_Click(object sender, EventArgs e)
        {
            int zaklad, exp;
            try{
                zaklad = int.Parse(calc1Base.Text);
                exp = int.Parse(calc1Exp.Text);
            }catch{
                ShowError();
                return;
            }
            int vysledek = Mocnina(zaklad, exp);
            calc1Result.Text = vysledek.ToString();
        }
        private void calc2Btn_Click(object sender, EventArgs e)
        {
            int zaklad;
            try{
                zaklad = int.Parse(calc2Base.Text);
            }catch{
                ShowError();
                return;
            }
            int vysledek = Mocnina(zaklad, 2);
            calc2Result.Text = vysledek.ToString();
        }
        private void ShowError()
        {
            MessageBox.Show("Zadaná hodnota není èíslo!", "Uživatelská chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private int Mocnina(int expBase, int exponent = 2)
        {
            int res = 1;
            for(int i = 0; i < exponent; i++)
            {
                res *= expBase;
            }
            return res;
        }
    }
}