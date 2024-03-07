using System.Text;

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
				if (x >= pocetSedadel || y >= pocetRad) { return; }
				sedadla[x, y] = !sedadla[x, y];
			}
			public void Save(string filename)
			{
				using (var stream = File.Open(filename, FileMode.Create))
				{
					using (var sw = new BinaryWriter(stream, Encoding.UTF8, false)){
						sw.Write((byte)pocetSedadel);
						sw.Write((byte)pocetRad);

						bool[] flat = new bool[pocetRad * pocetSedadel];
						for(int y = 0; y < pocetRad; y++)
						{
							for(int x = 0; x < pocetSedadel; x++)
							{
								flat[y * pocetSedadel + x] = sedadla[x, y];
							}
						}
						byte[] buffer = new byte[(int)Math.Ceiling((float)(pocetRad * pocetSedadel) / 8)];
						for(int i = 0; i < flat.Length; i++)
						{
							buffer[i / 8] |= (byte)((flat[i] ? 1 : 0) << (i % 8));
						}
						sw.Write(buffer);
					}
				}
			}
		}

		private void KinoForm_Load(object sender, EventArgs e)
		{
			kino = new Kinosal(4,4);
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

		private void saveBtn_Click(object sender, EventArgs e)
		{
			if (saveKinoDialog.ShowDialog() != DialogResult.OK) { return; }

			filenameLabel.Text = saveKinoDialog.FileName;
			kino.Save(saveKinoDialog.FileName);
		}
	}
}