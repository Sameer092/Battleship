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
    public partial class Difficulty : Form
    {
        private string gameType;

        public Difficulty()
        {
            InitializeComponent();
        }

        public Difficulty(string gameType)
        {
            // TODO: Complete member initialization
            this.gameType = gameType;
            InitializeComponent();

        }

       
        private void setupDifficultyLevelForm(int dimension, int shipsCount, int shipsSize)
        {
            SetupBoard playerOneBoard = new SetupBoard(dimension, shipsCount, shipsSize, gameType);
            playerOneBoard.Text = "Setup Player1";
            playerOneBoard.FormClosed += new FormClosedEventHandler(Difficulty_FormClosed);
            playerOneBoard.Show();
            this.Hide();
        }

        private void ezBtn_Click(object sender, EventArgs e)
        {
            setupDifficultyLevelForm(8, 5, 2);
        }

        private void Difficulty_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close(); // will exit the application     
        }

        private void mdBtn_Click(object sender, EventArgs e)
        {
            setupDifficultyLevelForm(12, 5, 3);
        }

        private void hdBtn_Click(object sender, EventArgs e)
        {
            setupDifficultyLevelForm(15, 5, 4);
        }
    }
}
