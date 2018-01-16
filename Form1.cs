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

        private void SettingButtons()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (player1 == true && button1Status == true)
            {
                button1.Text = "x";
                player1 = false;
                player2 = true;
                button1Status = false;
            }
            else if (player2 == true && button1Status == true)
            {
                button1.Text = "o";
                player2 = false;
                player1 = true;
                button1Status = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (player1 == true && button2Status == true)
            {
                button2.Text = "x";
                player1 = false;
                player2 = true;
                button2Status = false;
            }
            else if (player2 == true && button2Status == true)
            {
                button2.Text = "o";
                player2 = false;
                player1 = true;
                button2Status = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (player1 == true && button3Status == true)
            {
                button3.Text = "x";
                player1 = false;
                player2 = true;
                button3Status = false;
            }
            else if (player2 == true && button3Status == true)
            {
                button3.Text = "o";
                player2 = false;
                player1 = true;
                button3Status = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (player1 == true && button4Status == true)
            {
                button4.Text = "x";
                player1 = false;
                player2 = true;
                button4Status = false;
            }
            else if (player2 == true && button4Status == true)
            {
                button4.Text = "o";
                player2 = false;
                player1 = true;
                button4Status = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (player1 == true && button5Status == true)
            {
                button5.Text = "x";
                player1 = false;
                player2 = true;
                button5Status = false;
            }
            else if (player2 == true && button5Status == true)
            {
                button5.Text = "o";
                player2 = false;
                player1 = true;
                button5Status = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (player1 == true && button6Status == true)
            {
                button6.Text = "x";
                player1 = false;
                player2 = true;
                button6Status = false;
            }
            else if (player2 == true && button6Status == true)
            {
                button6.Text = "o";
                player2 = false;
                player1 = true;
                button6Status = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (player1 == true && button7Status == true)
            {
                button7.Text = "x";
                player1 = false;
                player2 = true;
                button7Status = false;
            }
            else if (player2 == true && button7Status == true)
            {
                button7.Text = "o";
                player2 = false;
                player1 = true;
                button7Status = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (player1 == true && button8Status == true)
            {
                button8.Text = "x";
                player1 = false;
                player2 = true;
                button8Status = false;
            }
            else if (player2 == true && button8Status == true)
            {
                button8.Text = "o";
                player2 = false;
                player1 = true;
                button8Status = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (player1 == true && button9Status == true)
            {
                button9.Text = "x";
                player1 = false;
                player2 = true;
                button9Status = false;
            }
            else if (player2 == true && button9Status == true)
            {
                button9.Text = "o";
                player2 = false;
                player1 = true;
                button9Status = false;
            }
        }
    }
}
