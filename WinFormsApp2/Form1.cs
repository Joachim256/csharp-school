namespace WinFormsApp2
{
    public partial class KinoForm : Form
    {
        Kinosal kino;
        public KinoForm()
        {
            InitializeComponent();
        }
        class Kinosal
        {
            private int pocetRad = 15;
            private int pocetSedadel = 30;
            private bool[,] sedadla;
            public Kinosal()
            {
                sedadla = new bool[pocetSedadel, pocetRad];
            }
            public Kinosal(int sirka, int vyska)
            {
                pocetRad = vyska;
                pocetSedadel = sirka;
                sedadla = new bool[sirka, vyska];
            }
            public void Render(Graphics grafica)
            {
                const int sedadloSizepx = 16;
                const int mezeraSizepx = 2;
                Brush brush;
                for (int y = 0; y < pocetRad; y++)
                {
                    for (int x = 0; x < pocetSedadel; x++)
                    {
                        if (this.sedadla[x, y])
                        {
                            brush = Brushes.Green;
                        }
                        else
                        {
                            brush = Brushes.Red;
                        }
                        grafica.FillRectangle(brush, x * (sedadloSizepx + mezeraSizepx), y * (sedadloSizepx + mezeraSizepx), sedadloSizepx, sedadloSizepx);
                    }
                }
            }
        }

        private void KinoForm_Load(object sender, EventArgs e)
        {
            kino = new Kinosal();
            filenameLabel.Text = "Prázdný sál";
        }

        private void kinoPictureBox_Paint(object sender, PaintEventArgs e)
        {
            kino.Render(e.Graphics);
        }
    }
}