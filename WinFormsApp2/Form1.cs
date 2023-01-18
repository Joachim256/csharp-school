namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string addText;
            bool gender;
            int genderint;
            if (radioButtonMale.Checked)
            {
                gender = false;
                genderint = 0;
            }
            else
            {
                gender = true;
                genderint = 1;
            }
            Dictionary<bool, string> genderMap = new Dictionary<bool, string> { { false, "mu�" }, { true, "�ena" } };
            string[] x1 = { "svobodn�", "svobodn�" }; string[] x2 = { "�enat�", "vdan�" }; string[] x3 = { "rozveden�", "rozveden�"}; string[] x4 = { "vdovec", "vdova" };
            Dictionary<string, string[]> lifeStateMap = new Dictionary<string, string[]> {
                { "svobodn�/�", x1 },
                { "�enat�/vdan�", x2 },
                { "rozveden�/�", x3 },
                { "vdovec/vdova", x4 }
            };
            addText = "\r\n" + name.Text + " " + surname.Text + ", " + genderMap[gender] + ", " + lifeStateMap[lifeState.Text][genderint] + ", "
                + " narozen" + (gender ? "a " : " ") + birthDate.Text + ", "
                + "datum z�pisu: " + today.Text;
            output.AppendText(addText);
        }
    }
}