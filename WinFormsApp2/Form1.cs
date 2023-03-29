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
        private const int cellSize = 10;

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
            
        }
        // Functions
        private void InitTable()
        {
            grid.ColumnCount = gridSize;
            grid.RowCount = gridSize;
            for (int i = 0; i < gridSize; i++)
            {
                grid.Columns[i].Width = cellSize;
                grid.Rows[i].Height = cellSize;
            }
            grid.ClearSelection();
        }
        private void generateCells()
        {

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
        private void calculateNextStage()
        {

        }

        
    }
}