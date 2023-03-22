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
            GenerateNumbers();
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
    }
}