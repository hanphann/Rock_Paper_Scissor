using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string compChoice;
        private string playerChoice;
        private string winner;

        private void GetCompChoice()
        {
            // Declare a random number
            Random rand = new Random();

            // Use switch structure to determine the computer's choice
            switch (rand.Next(3) +1)
            {
                case 1:
                    // The choice is Rock
                    compChoice = "Rock";
                    computerChoicePictureBox.Image = Game.Properties.Resources._1;
                    break;
                case 2:
                    // The choice is Paper
                    compChoice = "Paper";
                    computerChoicePictureBox.Image = Game.Properties.Resources._2;
                    break;
                case 3:
                    // The choice is Scissor
                    compChoice = "Scissor";
                    computerChoicePictureBox.Image = Game.Properties.Resources._3;
                    break;
            }
        }

        private void PlayerChoice()
        {
            switch (playerChoice)
            {
                case "Rock":
                    playerChoicePictureBox.Image = Game.Properties.Resources._1;
                    break;
                case "Paper":
                    playerChoicePictureBox.Image = Game.Properties.Resources._2;
                    break;
                case "Scissor":
                    playerChoicePictureBox.Image = Game.Properties.Resources._3;
                    break;
            }
        }

        private void ShowWinner()
        {
            if (compChoice == "Rock" && playerChoice == "Paper")
            {
                winner = "player";
            }
            else if (compChoice == "Rock" && playerChoice == "Scissor")
            {
                winner = "computer";
            }
            else if (compChoice == "Paper" && playerChoice == "Rock")
            {
                winner = "computer";
            }
            else if (compChoice == "Paper" && playerChoice == "Scissor")
            {
                winner = "player";
            }
            else if (compChoice == "Scissor" && playerChoice == "Rock")
            {
                winner = "player";
            }
            else if (compChoice == "Scissor" && playerChoice == "Paper")
            {
                winner = "computer";
            }
            else
            {
                winner = "none";
            }

            // Display the result
            if (winner == "computer")
            {
                resultLabel.Text = "You lose";
            }
            else if (winner == "player")
            {
                resultLabel.Text = "You win";
            }
            else
            {
                resultLabel.Text = "It is a tie!";
            }
        }


        private void rockButton_Click(object sender, EventArgs e)
        {
            playerChoice = "Rock";
            PlayerChoice();
            GetCompChoice();
            ShowWinner();
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            playerChoice = "Paper";
            PlayerChoice();
            GetCompChoice();
            ShowWinner();
        }

        private void scissorButton_Click(object sender, EventArgs e)
        {
            playerChoice = "Scissor";
            PlayerChoice();
            GetCompChoice();
            ShowWinner();
        }
    }
}
