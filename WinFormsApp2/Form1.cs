using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;

namespace WinFormsApp2
{
    public partial class ZapalkyForm : Form
    {
        public ZapalkyForm()
        {
            InitializeComponent();
        }

        private int gameSize = 5;

        enum Misto { Empty, Player1, Player2 };
        private Misto[,] game = new Misto[15, 15];

        private Misto playerTurn = Misto.Player1;
        Dictionary<Misto, Color> playerColors = new Dictionary<Misto, Color>();

        private void initGameField()
        {
            gameGrid.ColumnCount = gameSize * 2 - 1;
            gameGrid.RowCount = gameSize * 2 - 1;
            updateCellSizes();
        }
        private void updatePlayerTurnBold()
        {
            (playerTurn == Misto.Player1 ? player1Name : player2Name).Font = new Font(player1Name.Font, FontStyle.Bold);
            (playerTurn == Misto.Player1 ? player2Name : player1Name).Font = new Font(player1Name.Font, FontStyle.Regular);
        }
        private void initGameArray()
        {
            for(int x = 0; x < gameSize; x++)
            {
                for(int y = 0; y < gameSize; y++)
                {
                    game[x, y] = Misto.Empty;
                }
            }
        }
        private void updateCellSizes()
        {
            int gw = gameGrid.Width;
            int gh = gameGrid.Height;
            int smaller;

            if (gw > gh)
            {
                smaller = gh;
            }
            else
            {
                smaller = gw;
            }
            int edgeSize = (int)(0.2 * smaller / gameSize);
            int innerSize = (int)(0.8 * smaller / (gameSize - 1));

            for (int i = 0; i < gameSize * 2 - 1; i++)
            {
                if(i % 2 == 0)
                {
                    // edge
                    gameGrid.Columns[i].Width = edgeSize;
                    gameGrid.Rows[i].Height = edgeSize;
                }
                else
                {
                    // inner
                    gameGrid.Columns[i].Width = innerSize;
                    gameGrid.Rows[i].Height = innerSize;
                }
            }
        }
        private void placeMove(int x, int y)
        {
            if (game[x, y] != Misto.Empty) { return; }

            game[x, y] = playerTurn;
            gameGrid.Rows[y].Cells[x].Style.BackColor = playerColors[playerTurn];

            detectScore();

            toggleTurn();
        }
        private void detectScore()
        {

        }
        private void toggleTurn()
        {
            playerTurn = playerTurn == Misto.Player1 ? Misto.Player2 : Misto.Player1;
            updatePlayerTurnBold();
        }
        // events
        private void ZapalkyForm_Load(object sender, EventArgs e)
        {
            playerColors[Misto.Player1] = Color.Green;
            playerColors[Misto.Player2] = Color.DarkCyan;

            initGameField();
            initGameArray();
            updatePlayerTurnBold();
        }

        private void gameGrid_SelectionChanged(object sender, EventArgs e)
        {
            gameGrid.ClearSelection();
        }

        private void gameGrid_SizeChanged(object sender, EventArgs e)
        {
            updateCellSizes();
        }

        private void gameGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(! (e.RowIndex % 2 == 0 ^ e.ColumnIndex % 2 == 0)) { return; }

            placeMove(e.ColumnIndex, e.RowIndex);
        }
    }
}