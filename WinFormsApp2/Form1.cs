using Microsoft.VisualBasic;

namespace WinFormsApp2
{
    public partial class ZapalkyForm : Form
    {
        public ZapalkyForm()
        {
            InitializeComponent();
        }

        enum Misto
        {
            Blank,
            Sirka,
        }
        enum Sirka
        {
            Noones,
            Player1s,
            Player2s,
        }

        private Misto[,] game = new Misto[10,10];
        
        private int gameSize = 5;
        private bool ignoreCellResizeEvents = false;
        private int mouseX;
        private int mouseY;

        private uint playerTurn = 0;

        private void initGameField()
        {
            gameGrid.ColumnCount = gameSize;
            gameGrid.RowCount = gameSize;
            updateCellSizes();
        }
        private void initGameArray()
        {
            for(int x = 0; x < gameSize; x++)
            {
                for(int y = 0; y < gameSize; y++)
                {
                    game[x, y] = Misto.Blank;
                }
            }
        }
        private void updateCellSizes()
        {
            int gw = gameGrid.Width;
            int gh = gameGrid.Height;
            int cellSize;

            if (gw > gh)
            {
                cellSize = gh / gameSize;
            }
            else
            {
                cellSize = gw / gameSize;
            }

            ignoreCellResizeEvents = true;
            for (int i = 0; i < gameSize; i++)
            {
                gameGrid.Columns[i].Width = cellSize;
                gameGrid.Rows[i].Height = cellSize;
            }
            ignoreCellResizeEvents = false;
        }
        private void placeSirka(int x, int y)
        {

        }
        // events
        private void ZapalkyForm_Load(object sender, EventArgs e)
        {
            initGameField();
        }

        private void gameGrid_SelectionChanged(object sender, EventArgs e)
        {
            gameGrid.ClearSelection();
        }

        private void gameGrid_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            if (ignoreCellResizeEvents) { return; }
            Console.WriteLine(e.Column.Index);
            updateCellSizes();
        }
        private void gameGrid_RowHeightChanged(object sender, DataGridViewRowEventArgs e)
        {
            if (ignoreCellResizeEvents) { return; }
            Console.WriteLine(e.Row.Index);
            updateCellSizes();
        }
        private void ZapalkyForm_SizeChanged(object sender, EventArgs e)
        {
            updateCellSizes();
        }

        private void ZapalkyForm_ResizeBegin(object sender, EventArgs e)
        {
            ignoreCellResizeEvents = true;
        }
        private void ZapalkyForm_ResizeEnd(object sender, EventArgs e)
        {
            ignoreCellResizeEvents = false;
        }

        private void gameGrid_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
        }
    }
}