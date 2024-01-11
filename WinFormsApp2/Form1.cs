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
        DateTime countdown;
        private void btnStartCountdown_Click(object sender, EventArgs e)
        {
            countdown = DateTime.Now + new TimeSpan(0, inputTime.Value.Minute, inputTime.Value.Second);
            timerCountdown.Enabled = true;
            btnStartCountdown.Enabled = false;
        }
        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            TimeSpan left = countdown - DateTime.Now;
            if(left.TotalMilliseconds < 0)
            {
                left = new TimeSpan();
                timerCountdown.Enabled = false;
                btnStartCountdown.Enabled = true;
            }
            labelCountdown.Text = left.ToString(@"mm\:ss\.fff");
        }
    }
}