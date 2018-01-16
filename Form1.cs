using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool player1;
        bool player2;
        
        bool button1Status = true;
        bool button2Status = true;
        bool button3Status = true;
        bool button4Status = true;
        bool button5Status = true;
        bool button6Status = true;
        bool button7Status = true;
        bool button8Status = true;
        bool button9Status = true;

        bool gameSession = true;

        public Form1()
        {
            InitializeComponent();
            DecidingStart();
        }

        private void DecidingStart()
        {
            Random myRandom = new Random();
            int randomCoin = myRandom.Next(1, 3);
            if (randomCoin == 1)
                player1 = true;
            else
                player2 = true;

        }

        private void CheckingFinish()
        {
            if (button1.Text == "x" && button2.Text == "x" && button3.Text == "x")
                    { this.textBox1.Text = "Player 1 won."; gameSession = false; }
            else if (button4.Text == "x" && button5.Text == "x" && button6.Text == "x")
                    { this.textBox1.Text = "Player 1 won."; gameSession = false; }
            else if (button7.Text == "x" && button8.Text == "x" && button9.Text == "x")
                    { this.textBox1.Text = "Player 1 won."; gameSession = false; }
            else if (button1.Text == "x" && button4.Text == "x" && button7.Text == "x")
                    { this.textBox1.Text = "Player 1 won."; gameSession = false; }
            else if (button2.Text == "x" && button5.Text == "x" && button8.Text == "x")
                    { this.textBox1.Text = "Player 1 won."; gameSession = false; }
            else if (button3.Text == "x" && button6.Text == "x" && button9.Text == "x")
                    { this.textBox1.Text = "Player 1 won."; gameSession = false; }
            else if (button1.Text == "x" && button5.Text == "x" && button9.Text == "x")
                    { this.textBox1.Text = "Player 1 won."; gameSession = false; }
            else if (button3.Text == "x" && button5.Text == "x" && button7.Text == "x")
                    { this.textBox1.Text = "Player 1 won."; gameSession = false; }

            else if (button1.Text == "o" && button2.Text == "o" && button3.Text == "o")
                    { this.textBox1.Text = "Player 2 won."; gameSession = false; }
            else if (button4.Text == "o" && button5.Text == "o" && button6.Text == "o")
                    { this.textBox1.Text = "Player 2 won."; gameSession = false; }
            else if (button7.Text == "o" && button8.Text == "o" && button9.Text == "o")
                    { this.textBox1.Text = "Player 2 won."; gameSession = false; }
            else if (button1.Text == "o" && button4.Text == "o" && button7.Text == "o")
                    { this.textBox1.Text = "Player 2 won."; gameSession = false; }
            else if (button2.Text == "o" && button5.Text == "o" && button8.Text == "o")
                    { this.textBox1.Text = "Player 2 won."; gameSession = false; }
            else if (button3.Text == "o" && button6.Text == "o" && button9.Text == "o")
                    { this.textBox1.Text = "Player 2 won."; gameSession = false; }
            else if (button1.Text == "o" && button5.Text == "o" && button9.Text == "o")
                    { this.textBox1.Text = "Player 2 won."; gameSession = false; }
            else if (button3.Text == "o" && button5.Text == "o" && button7.Text == "o")
                    { this.textBox1.Text = "Player 2 won."; gameSession = false; }
            else if (button1Status == false && button2Status == false && button3Status == false && button4Status == false 
                    && button5Status == false && button6Status == false && button7Status == false && button8Status == false 
                    && button9Status == false && gameSession == true)
                        { this.textBox1.Text = "The game is a draw"; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (player1 == true && button1Status == true && gameSession == true)
            {
                button1.Text = "x";
                player1 = false;
                player2 = true;
                button1Status = false;
            }
            else if (player2 == true && button1Status == true && gameSession == true)
            {
                button1.Text = "o";
                player2 = false;
                player1 = true;
                button1Status = false;
            }
            CheckingFinish();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (player1 == true && button2Status == true && gameSession == true)
            {
                button2.Text = "x";
                player1 = false;
                player2 = true;
                button2Status = false;
            }
            else if (player2 == true && button2Status == true && gameSession == true)
            {
                button2.Text = "o";
                player2 = false;
                player1 = true;
                button2Status = false;
            }
            CheckingFinish();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (player1 == true && button3Status == true && gameSession == true)
            {
                button3.Text = "x";
                player1 = false;
                player2 = true;
                button3Status = false;
            }
            else if (player2 == true && button3Status == true && gameSession == true)
            {
                button3.Text = "o";
                player2 = false;
                player1 = true;
                button3Status = false;
            }
            CheckingFinish();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (player1 == true && button4Status == true && gameSession == true)
            {
                button4.Text = "x";
                player1 = false;
                player2 = true;
                button4Status = false;
            }
            else if (player2 == true && button4Status == true && gameSession == true)
            {
                button4.Text = "o";
                player2 = false;
                player1 = true;
                button4Status = false;
            }
            CheckingFinish();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (player1 == true && button5Status == true && gameSession == true)
            {
                button5.Text = "x";
                player1 = false;
                player2 = true;
                button5Status = false;
            }
            else if (player2 == true && button5Status == true && gameSession == true)
            {
                button5.Text = "o";
                player2 = false;
                player1 = true;
                button5Status = false;
            }
            CheckingFinish();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (player1 == true && button6Status == true && gameSession == true)
            {
                button6.Text = "x";
                player1 = false;
                player2 = true;
                button6Status = false;
            }
            else if (player2 == true && button6Status == true && gameSession == true)
            {
                button6.Text = "o";
                player2 = false;
                player1 = true;
                button6Status = false;
            }
            CheckingFinish();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (player1 == true && button7Status == true && gameSession == true)
            {
                button7.Text = "x";
                player1 = false;
                player2 = true;
                button7Status = false;
            }
            else if (player2 == true && button7Status == true && gameSession == true)
            {
                button7.Text = "o";
                player2 = false;
                player1 = true;
                button7Status = false;
            }
            CheckingFinish();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (player1 == true && button8Status == true && gameSession == true)
            {
                button8.Text = "x";
                player1 = false;
                player2 = true;
                button8Status = false;
            }
            else if (player2 == true && button8Status == true && gameSession == true)
            {
                button8.Text = "o";
                player2 = false;
                player1 = true;
                button8Status = false;
            }
            CheckingFinish();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (player1 == true && button9Status == true && gameSession == true)
            {
                button9.Text = "x";
                player1 = false;
                player2 = true;
                button9Status = false;
            }
            else if (player2 == true && button9Status == true && gameSession == true)
            {
                button9.Text = "o";
                player2 = false;
                player1 = true;
                button9Status = false;
            }
            CheckingFinish();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
