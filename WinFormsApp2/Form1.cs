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
        private void button_Click(object sender, EventArgs e)
        {
            timer1.Enabled = ! timer1.Enabled;
        }
        private int jmpSize = 1;
        private void jumpSize_ValueChanged(object sender, EventArgs e)
        {
            jmpSize = (int)jumpSize.Value;
        }
        private void jumpSpeed_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)(500 - jumpSpeed.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(rng.Next(0, 5) == 0){
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
            fly.Location = new Point(x, y);

            //panel.ClientRectangle.Location.X;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}