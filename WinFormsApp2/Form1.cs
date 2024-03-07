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
            const int sedadloSizepx = 16;
            const int mezeraSizepx = 2;
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
				Brush brush;
				for (int y = 0; y < pocetRad; y++)
				{
					for (int x = 0; x < pocetSedadel; x++)
					{
						if (this.sedadla[x, y])
						{
							brush = Brushes.Red;
						}
						else
						{
							brush = Brushes.Green;
						}
						grafica.FillRectangle(brush, x * (sedadloSizepx + mezeraSizepx), y * (sedadloSizepx + mezeraSizepx), sedadloSizepx, sedadloSizepx);
					}
				}
			}
			public void ClickSeat(int clickX, int clickY)
			{
				int x = clickX / (sedadloSizepx + mezeraSizepx);
				int y = clickY / (sedadloSizepx + mezeraSizepx);
				if(x >= pocetSedadel || y >= pocetRad) { return; }
				sedadla[x, y] = !sedadla[x, y];
			}
		}

		private void KinoForm_Load(object sender, EventArgs e)
		{
			kino = new Kinosal();
			filenameLabel.Text = "Nový sál";
		}

		private void kinoPictureBox_Paint(object sender, PaintEventArgs e)
		{
			kino.Render(e.Graphics);
		}
		private void kinoPictureBox_MouseClick(object sender, MouseEventArgs e)
		{
			kino.ClickSeat(e.X, e.Y);
			kinoPictureBox.Refresh();
		}
	}
}