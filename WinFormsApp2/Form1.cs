namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void updateTime()
        {
            DateTime t = DateTime.Now;
            labelTime.Text = t.ToLongTimeString();
            labelDate.Text = t.ToShortDateString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            updateTime();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateTime();
        }
        TimeSpan countdown;
        private void btnStartCountdown_Click(object sender, EventArgs e)
        {
            countdown = new TimeSpan(0, inputTime.Value.Minute, inputTime.Value.Second);
            timerCountdown.Enabled = true;
        }
        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            // todo: check if time == 0
            countdown.Add(new TimeSpan(-1));
            labelCountdown.Text = countdown.ToString("mm:ss.fff"); // todo: fix "String was not in a correct format" error
        }
    }
}