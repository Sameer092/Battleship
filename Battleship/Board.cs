using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    public partial class SetupBoard : Form
    {
        private int dimension;
        private int shipsCount;
        private int remainingShips;
        private int shipsSize;
        private string gameType;
        private TableLayoutPanel board;
        private char[,] boardArray;
        private char[,] boardP1;

        public SetupBoard()
        {
            InitializeComponent();
        }

        public SetupBoard(int dimension, int shipsCount, int shipsSize, string gameType)
        {
            // TODO: Complete member initialization
            this.dimension = dimension;
            this.shipsCount = shipsCount;
            this.shipsSize = shipsSize;
            this.gameType = gameType;
            remainingShips = shipsCount;
            InitializeComponent();

            boardArray = new char[dimension, dimension];            
            SetGameBoard();
        }

        public void SetP1Board(char[,] oldBoard)
        {
            boardP1 = new char[dimension, dimension];

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    boardP1[i, j] = oldBoard[i, j];
                }
            }
        }

        public bool isValidInput(int row, int column, bool isHorizontal, char[,] currentBoard)
        {
            if (isHorizontal)
            {
                if (column + shipsSize > dimension)
                {
                    return false;
                }

                for (int i = 0; i < shipsSize; i++)
                    if (currentBoard[row, column + i] == '1')
                        return false;
            }
            else
            {
                if (row + shipsSize > dimension)
                {
                    return false;
                }

                for (int i = 0; i < shipsSize; i++)
                    if (currentBoard[row + i, column] == '1')
                        return false;
            }
            return true;
        }

        private void Currnet_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close(); // will exit the application     
        }

        void generateComputerBoard()
        {
            int totalShipsToPlaced = this.shipsCount;
            boardP1 = new char[dimension, dimension];

            for (int i = 0; i < dimension; i++)
                for (int j = 0; j < dimension; j++)
                    boardP1[i, j] = '0';

            while (totalShipsToPlaced > 0)
            {
                // guess two numbers between 0 to dimension - shipsSize
                Random rnd = new Random();
                int row = rnd.Next(0, dimension - shipsSize);
                int column = rnd.Next(0, dimension - shipsSize);
                bool isHorizontal = rnd.Next(0, 2) == 1;

                if (isValidInput(row, column, isHorizontal, boardP1))
                {
                    if (isHorizontal)
                        for (int i = 0; i < shipsSize; i++)
                            boardP1[row, column + i] = '1';

                    else
                        for (int i = 0; i < shipsSize; i++)
                            boardP1[row + i, column] = '1';
                }
                else
                    continue;

                totalShipsToPlaced--;
            }
        }

        void next()
        {
            if (gameType == "pvp")
            {
                if (this.boardP1 != null)
                {
                    // pass both boards to the next screen
                    Game player1Game = new Game(boardP1, boardArray, dimension, shipsSize, shipsCount, gameType);
                    player1Game.FormClosed += new FormClosedEventHandler(Currnet_FormClosed);
                    player1Game.Show();
                    this.Hide();
                }
                else
                {
                    SetupBoard playerTwoBoard = new SetupBoard(dimension, shipsCount, shipsSize, gameType);
                    playerTwoBoard.SetP1Board(boardArray);
                    playerTwoBoard.Text = "Setup Player2";
                    playerTwoBoard.FormClosed += new FormClosedEventHandler(Currnet_FormClosed);
                    playerTwoBoard.Show();
                    this.Hide();
                }
            }
            else
            {
                generateComputerBoard();
                Game player1Game = new Game(boardArray, boardP1, dimension, shipsSize, shipsCount, gameType);
                player1Game.FormClosed += new FormClosedEventHandler(Currnet_FormClosed);
                player1Game.Show();
                this.Hide();
                // pass both boards to the next screen

            }
        }

        void turnComplete()
        {
            this.remainingShips = this.remainingShips - 1;
            remaining.Text = "Remaining: " + remainingShips.ToString();

            if (this.remainingShips == 0)
                next();
        }

        void button_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string[] indexes = btn.Name.Split(',');
            int row = Int32.Parse(indexes[1]);
            int column = Int32.Parse(indexes[0]);

            if (isValidInput(row, column, horizontal.Checked, boardArray))
            {
                if (horizontal.Checked)
                {
                    for (int i = 0; i < shipsSize; i++)
                    {
                        board.GetControlFromPosition(column + i, row).BackColor = Color.Red;
                        boardArray[row, column + i] = '1';
                    }

                }
                else
                {
                    for (int i = 0; i < shipsSize; i++)
                    {
                        board.GetControlFromPosition(column, row + i).BackColor = Color.Red;
                        boardArray[row + i, column] = '1';
                    }
                }

                turnComplete();
                
            }
            
        }

        public void SetGameBoard() {
            int cellSize = 475;
            board = new TableLayoutPanel();
            board.Location = new System.Drawing.Point(12, 12);
            board.Size = new System.Drawing.Size(cellSize, cellSize);
            board.TabIndex = 0;  
            board.BackColor = Color.Silver;
            board.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            for (int i = 0; i < dimension; i++)
            {
                board.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
                board.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            }

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    var btn = new System.Windows.Forms.Button();
                    btn.Name = i + "," + j;
                    btn.BackColor = Color.PowderBlue;
                    btn.Click += new EventHandler(button_click);
                    btn.Height = cellSize / dimension;
                    board.Controls.Add(btn, i, j);

                    boardArray[i, j] = '0';
                }
            }
            board.ColumnCount = dimension;
            board.RowCount = dimension;
            Controls.Add(board);
            remaining.Text = "Remaining: " + remainingShips.ToString();
        }
    }
}
