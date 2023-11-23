using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_6
{
    public partial class Form1 : Form
    {
        private int randomNumber;
        private int computerScore;
        private int playerScore;
        public Form1()
        {
            InitializeComponent();
            randomNumber = generateRandomNumber();

        }

        private int generateRandomNumber()
        {
            Random random = new Random();
            return random.Next(1, 4);
        }

        private void gameLogic()
        {
            if (computerPictureBox.Image == rock.Image && youPictureBox.Image == scissors.Image)
            {
                resultLabel.Text = "You Loosed !";
                resultLabel.ForeColor = Color.Red;
                computerScore++;
            }else if (computerPictureBox.Image == scissors.Image && youPictureBox.Image == paper.Image)
            {
                resultLabel.Text = "You Loosed !";
                resultLabel.ForeColor = Color.Red;
                computerScore++;
            }
            else if (computerPictureBox.Image == paper.Image && youPictureBox.Image == rock.Image) 
            {
                resultLabel.Text = "You Loosed ! ";
                resultLabel.ForeColor = Color.Red;
                computerScore++;
            }
            else if (youPictureBox.Image == rock.Image && computerPictureBox.Image == scissors.Image)
            {
                resultLabel.Text = "It's a Win !";
                resultLabel.ForeColor = Color.Green;
                playerScore++;
            }
            else if (youPictureBox.Image == scissors.Image && computerPictureBox.Image == paper.Image)
            {
                resultLabel.ForeColor = Color.Green;
                resultLabel.Text = "It's a Win !";
                playerScore++;
            }
            else if (youPictureBox.Image == paper.Image && computerPictureBox.Image == rock.Image)
            {
                resultLabel.Text = "It's a Win !";
                resultLabel.ForeColor = Color.Green;
                playerScore++;
            }
            else
            {
                resultLabel.Text = "It's a tie !";
                resultLabel.ForeColor = Color.Black;
            }

            computerScorelabel.Text = computerScore.ToString();
            playerScorelabel.Text = playerScore.ToString();
            randomNumber = generateRandomNumber();


        }

        private void computerChoice()
        {
            switch (randomNumber)
            {
                case 1:
                    computerPictureBox.Image = rock.Image;
                    break;
                case 2:
                    computerPictureBox.Image = paper.Image;
                    break;
                case 3:
                    computerPictureBox.Image = scissors.Image;
                    break;
            }

            gameLogic();
            

        }


        private void rock_Click(object sender, EventArgs e)
        {
            youPictureBox.Image = rock.Image;
            computerChoice();
        }

        private void paper_Click(object sender, EventArgs e)
        {
            youPictureBox.Image = paper.Image;
            computerChoice();
        }

        private void scissors_Click(object sender, EventArgs e)
        {
            youPictureBox.Image = scissors.Image;
            computerChoice();
        }
    }
}
