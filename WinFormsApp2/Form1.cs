using System.Drawing;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        const int gridSize = 10;
        const int cellSize = 30;

        int[,] data = new int[gridSize, gridSize];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitTable();
        }
        private void GenerateNumbers()
        {
            Random rng = new Random();
            for(int x = 0; x < gridSize; x++)
            {
                for(int y = 0; y < gridSize; y++)
                {
                    // generate random number
                    int n = rng.Next(0, 100);
                    data[x, y] = n;
                    // render
                    grid.Rows[y].Cells[x].Value = n;
                }
            }
        }
        private double CalculateAverage()
        {
            int sum = 0;
            for(int x = 0; x < gridSize; x++)
            {
                for(int y = 0; y < gridSize; y++)
                {
                    sum += int.Parse(grid.Rows[y].Cells[x].Value.ToString());
                }
            }

            return (sum / Math.Pow(gridSize, 2));
        }
        private void MarkGreater(double average)
        {
            int marked = 0;
            DataGridViewCellStyle markedStyle = new DataGridViewCellStyle();
            markedStyle.BackColor = Color.Aqua;
            for (int x = 0; x < gridSize; x++)
            {
                for(int y = 0; y < gridSize; y++)
                {
                    int val = int.Parse(grid.Rows[y].Cells[x].Value.ToString());
                    if(val > average)
                    {
                        grid.Rows[y].Cells[x].Style = markedStyle;
                        marked++;
                    }
                }
            }
            markedTextBox.Text = marked.ToString();
        }
        private void InitTable()
        {
            grid.ColumnCount = gridSize;
            grid.RowCount = gridSize;
            for (int i = 0; i < gridSize; i++)
            {
                grid.Columns[i].Width = cellSize;
                grid.Rows[i].Height = cellSize;
            }
        }
        private void ClearGridColors()
        {
            DataGridViewCellStyle resetStyle = new DataGridViewCellStyle();
            for (int x = 0; x < gridSize; x++)
            {
                for (int y = 0; y < gridSize; y++)
                {
                    grid.Rows[y].Cells[x].Style = resetStyle;
                }
            }
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            ClearGridColors();
            GenerateNumbers();
        }

        private void markBtn_Click(object sender, EventArgs e)
        {
            double avg = CalculateAverage();
            avgTextBox.Text = avg.ToString();
            MarkGreater(avg);
        }
    }
}