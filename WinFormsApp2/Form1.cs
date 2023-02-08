namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random rng = new Random();
        private int[] directions = {1, 1};
        private bool changeDir = false;
        private void button_Click(object sender, EventArgs e)
        {
            timer1.Enabled = ! timer1.Enabled;
        }
        private int jmpSize = 1;
        private int jmpSpeed = 40;
        private void jumpSize_ValueChanged(object sender, EventArgs e)
        {
            jmpSize = (int)jumpSize.Value;
        }
        private void jumpSpeed_ValueChanged(object sender, EventArgs e)
        {
            if(jumpSpeed.Value >= 50) { return; }
            jmpSpeed = (int)jumpSpeed.Value;
            timer1.Interval = (int)(50 - jmpSpeed);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(changeDir || rng.Next(0, 2 + jmpSpeed) == 0){
                changeDir = false;
                // change direction
                for(int i = 0; i < 2; i++){
                    directions[i] = (rng.Next(0, 2) == 0) ? -1 : 1;
                }
            }
            // move fly
            int x = fly.Location.X;
            int y = fly.Location.Y;
            x += directions[0] * jmpSize;
            y += directions[1] * jmpSize;
            if (x < 0) { x = 0; changeDir = true; } else if (x > panel.ClientSize.Width - fly.Width) { x = panel.ClientSize.Width - fly.Width; changeDir = true; }
            if (y < 0) { y = 0; changeDir = true; } else if (y > panel.ClientSize.Height - fly.Height) { y = panel.ClientSize.Height - fly.Height; changeDir = true; }
            fly.Location = new Point(x, y);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}