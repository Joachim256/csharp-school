using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private const int gridSize = 30;

        DataGridViewCellStyle aliveStyle = new DataGridViewCellStyle();
        DataGridViewCellStyle deadStyle = new DataGridViewCellStyle();

        private bool[,] game = new bool[gridSize, gridSize];
        private bool animationRunning = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            aliveStyle.BackColor = Color.Black;
            deadStyle.BackColor = Color.White;
            InitTable();
        }
        // UI
        private void animationMode1_CheckedChanged(object sender, EventArgs e)
        {
            if (animationMode1.Checked)
            {
                panel1.Enabled = true;
                panel2.Enabled = false;
            }
        }
        private void animationMode2_CheckedChanged(object sender, EventArgs e)
        {
            if(animationMode2.Checked)
            {
                panel1.Enabled = false;
                panel2.Enabled = true;
            }
        }
        // Actions
        private void generateCellsBtn_Click(object sender, EventArgs e)
        {
            generateCells();
            updateCells();
        }
        private void animationStepBtn_Click(object sender, EventArgs e)
        {
            calculateNextStage();
            updateCells();
        }
        // Functions
        private void InitTable()
        {
            grid.ColumnCount = gridSize;
            grid.RowCount = gridSize;
            int cellSize = grid.Width / (gridSize);
            for (int i = 0; i < gridSize; i++)
            {
                grid.Columns[i].Width = cellSize;
                grid.Rows[i].Height = cellSize;
            }
            grid.ClearSelection();
        }
        private void generateCells()
        {
            clearCells();
            var rng = new Random();
            int count = Convert.ToInt16(generateCount.Value);
            for(int i = 0; i < count; i++)
            {
                int x = rng.Next(0, gridSize);
                int y = rng.Next(0, gridSize);

                if (game[x, y]) { continue; }

                game[x, y] = true;
            }
        }
        private void updateCells()
        {
            for(int y = 0; y < gridSize; y++)
            {
                for(int x = 0; x < gridSize; x++)
                {
                    grid.Rows[y].Cells[x].Style = game[x,y] ? aliveStyle : deadStyle;
                }
            }
        }
        private void clearCells()
        {
            for(int x = 0; x < gridSize; x++)
            {
                for(int y = 0; y < gridSize; y++)
                {
                    game[x, y] = false;
                }
            }
        }
        private void calculateNextStage()
        {
            bool[,] next = new bool[gridSize, gridSize];
            for(int x = 0; x < gridSize; x++)
            {
                for(int y = 0; y < gridSize; y++)
                {
                    // count alive neighbors
                    int aliveNeighbors = 0;
                    if (x != 0 && game[x-1, y] == true) { aliveNeighbors++; }
                    if (x != gridSize - 1 && game[x+1, y] == true) { aliveNeighbors++; }
                    if (y != 0 && game[x, y-1] == true) { aliveNeighbors++; }
                    if (y != gridSize - 1 && game[x, y+1] == true) { aliveNeighbors++; }
                    if (x != 0 && y != 0 && game[x-1, y-1] == true) { aliveNeighbors++; }
                    if (x != 0 && y != gridSize - 1 && game[x-1, y+1] == true) { aliveNeighbors++; }
                    if (x != gridSize - 1 && y != 0 && game[x+1, y-1] == true) { aliveNeighbors++; }
                    if (x != gridSize - 1 && y != gridSize - 1 && game[x+1, y+1] == true) { aliveNeighbors++; }
                    // apply rules
                    if (game[x, y] == true)
                    {
                        if(aliveNeighbors < 2)
                        {
                            next[x, y] = false;
                        }else if(aliveNeighbors > 4)
                        {
                            next[x, y] = false;
                        }
                        else
                        {
                            next[x, y] = game[x, y];
                        }
                    }
                    else
                    {
                        if(aliveNeighbors == 3)
                        {
                            next[x, y] = true;
                        }
                        else
                        {
                            next[x, y] = game[x, y];
                        }
                    }
                }
            }
        }
    }
}