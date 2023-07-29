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
    public partial class BattleShip : Form
    {
        public BattleShip()
        {
            InitializeComponent();
        }

        private void switchToDifficultyForm(string gameType)
        {
            Difficulty diffiCultyForm = new Difficulty(gameType);
            diffiCultyForm.FormClosed += new FormClosedEventHandler(SetupBoard_FormClosed);
            diffiCultyForm.Show();
            this.Hide();
        }

        private void pvpBtn_Click(object sender, EventArgs e)
        {
            switchToDifficultyForm("pvp");
        }

        private void SetupBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close(); // will exit the application     
        }

        private void pvcBtn_Click(object sender, EventArgs e)
        {
            switchToDifficultyForm("pvc");
        }

        void showCredits()
        {
            CreditForm creditForm = new CreditForm();
            creditForm.Show();
        }

        void showRules()
        {
            RulesForm rulesForm = new RulesForm();
            rulesForm.Show();
        }

        private void creditBtn_Click(object sender, EventArgs e)
        {
            showCredits();
        }

        private void rulesBtn_Click(object sender, EventArgs e)
        {
            showRules();
        }
    }
}
