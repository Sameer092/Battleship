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
    public partial class Game : Form
    {
        private char[,] player1Board;
        private char[,] player2Board;
        private TableLayoutPanel board;
        private TableLayoutPanel board2;
        private Panel panel1;
        private Panel panel2;
        private int dimension;
        private int shipsSize;
        private int turnsToggler;
        private int shipsCount;
        private string gameType;
        private int player1Score;
        private int player2Score;

        public Game()
        {
            InitializeComponent();
        }

        public Game(char[,] player1Board, char[,] player2Board, int dimension, int shipsSize, int shipsCount, string gameType)
        {
            // TODO: Complete member initialization
            this.player1Board = player1Board;
            this.player2Board = player2Board;
            this.dimension = dimension;
            this.shipsSize = shipsSize;
            this.player1Score = 0;
            this.player2Score = 0;
            this.turnsToggler = 1;
            this.gameType = gameType;
            this.shipsCount = shipsCount;
            InitializeComponent();
            this.Text = "P1 Turn";
            SetGameBoards();
        }

        bool isValidTurnByPc(int row, int column)
        {
            var clr = board2.GetControlFromPosition(column, row).BackColor;
            return clr == Color.PowderBlue;
        }

        void performPCAction()
        {
            Random rnd = new Random();
            int row;
            int column;
            do
            {
                row = rnd.Next(0, dimension - 1);
                column = rnd.Next(0, dimension - 1);
            }
            while (!isValidTurnByPc(row, column));

            if (player1Board[row, column] == '1')
            {
                board2.GetControlFromPosition(column, row).BackColor = Color.Green;
                this.player2Score = this.player2Score + 1;
            }
            else
            {
                board2.GetControlFromPosition(column, row).BackColor = Color.Red;
            }
            this.turnsToggler = this.turnsToggler + 1;

            winningCondition();

            
        }

        void computerTurn()
        {
            if (turnsToggler % 2 == 0)
            {
                this.Text = "P1 Turn";
                panel2.Visible = false;
                panel1.Visible = true;
                this.turnsToggler = this.turnsToggler + 1;
                switchBtn.Visible = false;
            }
            else
            {
                this.Text = "PC Turn";
                panel2.Visible = true;
                panel1.Visible = false;
                performPCAction();
            }
        }

        void switchTurn()
        {
            if (turnsToggler % 2 == 0)
            {
                this.Text = "P1 Turn";
                panel2.Visible = false;
                panel1.Visible = true;
            }
            else
            {
                this.Text = "P2 Turn";
                panel2.Visible = true;
                panel1.Visible = false;
                
            }
            switchBtn.Visible = false;
            this.turnsToggler = this.turnsToggler + 1;
        }

        void button_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string[] indexes = btn.Name.Split(',');
            int row = Int32.Parse(indexes[1]);
            int column = Int32.Parse(indexes[0]);
            
            if (btn.BackColor != Color.PowderBlue || switchBtn.Visible)
                return;
            
            if (turnsToggler % 2 != 0)
            {
                if (player2Board[row, column] == '1')
                {
                    board.GetControlFromPosition(column, row).BackColor = Color.Green;
                    this.player1Score = this.player1Score + 1;
                }
                else
                {
                    board.GetControlFromPosition(column, row).BackColor = Color.Red;
                }
            }
            else
            {
                if (player1Board[row, column] == '1')
                {
                    board2.GetControlFromPosition(column, row).BackColor = Color.Green;
                    this.player2Score = this.player2Score + 1;
                }
                else
                {
                    board2.GetControlFromPosition(column, row).BackColor = Color.Red;
                }
            }

            winningCondition();

            switchBtn.Visible = true;
        
        }

        public void winningCondition()
        {
            if (player1Score == shipsCount * shipsSize)
            {
                MessageBox.Show("Player1 won the game");
                this.Close();
            }

            if (player2Score == shipsCount * shipsSize)
            {
                if (gameType == "pvp")
                    MessageBox.Show("Player2 won the game");
                else
                    MessageBox.Show("Computer won the game");

                this.Close();
            }
        }

        public void SetGameBoards()
        {
            int cellSize = 475;
            panel1 = new Panel();
            panel1.Dock = DockStyle.Fill;

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
                    btn.Click += new EventHandler(button_click);
                    btn.Height = cellSize / dimension;
                    btn.BackColor = Color.PowderBlue;
                    board.Controls.Add(btn, i, j);
                }
            }
            board.ColumnCount = dimension;
            board.RowCount = dimension;
            panel1.Controls.Add(board);
            Controls.Add(panel1);

            panel2 = new Panel();
            panel2.Dock = DockStyle.Fill;
            panel2.Visible = false;
            board2 = new TableLayoutPanel();
            board2.Location = new System.Drawing.Point(12, 12);
            board2.Size = new System.Drawing.Size(cellSize, cellSize);
            board2.TabIndex = 0;
            board2.BackColor = Color.Silver;
            board2.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            for (int i = 0; i < dimension; i++)
            {
                board2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
                board2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            }

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    var btn2 = new System.Windows.Forms.Button();
                    btn2.Name = i + "," + j;
                    btn2.Click += new EventHandler(button_click);
                    btn2.Height = cellSize / dimension;
                    btn2.BackColor = Color.PowderBlue;                    
                    board2.Controls.Add(btn2, i, j);

                }
            }
            board2.ColumnCount = dimension;
            board2.RowCount = dimension;
            panel2.Controls.Add(board2);
            Controls.Add(panel2);

        }

        private void switchBtn_Click(object sender, EventArgs e)
        {
            if (gameType == "pvp")
                switchTurn();
            else 
                computerTurn();

        }
    }
}
