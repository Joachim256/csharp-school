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
            Dictionary<bool, string> genderMap = new Dictionary<bool, string> { { false, "muž" }, { true, "žena" } };
            string[] x1 = { "svobodný", "svobodná" }; string[] x2 = { "ženatý", "vdaná" }; string[] x3 = { "rozvedený", "rozvedená"}; string[] x4 = { "vdovec", "vdova" };
            Dictionary<string, string[]> lifeStateMap = new Dictionary<string, string[]> {
                { "svobodný/á", x1 },
                { "ženatý/vdaná", x2 },
                { "rozvedený/á", x3 },
                { "vdovec/vdova", x4 }
            };
            addText = "\r\n" + name.Text + " " + surname.Text + ", " + genderMap[gender] + ", " + lifeStateMap[lifeState.Text][genderint] + ", "
                + " narozen" + (gender ? "a " : " ") + birthDate.Text + ", "
                + "datum zápisu: " + today.Text;
            output.AppendText(addText);
        }
    }
}