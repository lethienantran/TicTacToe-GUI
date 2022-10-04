using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] board = new string[9];
        int currentTurn = 0; 
        
        //return player's symbol XO on the board after their turn
        public String playerSymbol(int turn)
        {
            if(turn % 2 == 0 )
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }
        public void WinnerColor(int index)
        {
            switch(index)
            {
                case 0:
                    grid1.BackColor = System.Drawing.Color.Red;
                    break;
                case 1:
                    grid2.BackColor = System.Drawing.Color.Red;
                    break;
                case 2:
                    grid3.BackColor = System.Drawing.Color.Red;
                    break;
                case 3:
                    grid4.BackColor = System.Drawing.Color.Red;
                    break;
                case 4:
                    grid5.BackColor = System.Drawing.Color.Red;
                    break;
                case 5:
                    grid6.BackColor = System.Drawing.Color.Red;
                    break;
                case 6:
                    grid7.BackColor = System.Drawing.Color.Red;
                    break;
                case 7:
                    grid8.BackColor = System.Drawing.Color.Red;
                    break;
                case 8:
                    grid9.BackColor = System.Drawing.Color.Red;
                    break;

            }
        }
        public void Restart()
        {
            board = new string[9];
            currentTurn = 0;
            grid1.Text = "";
            grid2.Text = "";
            grid3.Text = "";
            grid4.Text = "";
            grid5.Text = "";
            grid6.Text = "";
            grid7.Text = "";
            grid8.Text = "";
            grid9.Text = "";
            grid1.BackColor = System.Drawing.Color.White;
            grid2.BackColor = System.Drawing.Color.White;
            grid3.BackColor = System.Drawing.Color.White;
            grid4.BackColor = System.Drawing.Color.White;
            grid5.BackColor = System.Drawing.Color.White;
            grid6.BackColor = System.Drawing.Color.White;
            grid7.BackColor = System.Drawing.Color.White;
            grid8.BackColor = System.Drawing.Color.White;
            grid9.BackColor = System.Drawing.Color.White;
        }
        public void CheckTie()
        {
            int count = 0;
            for(int i = 0; i < board.Length; i++)
            {
                if (board[i] != null)
                    count++;
                if(count == 9)
                {
                    Restart();
                    MessageBox.Show("Tie!", "That's a Tie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        public void CheckWinner()
        {
            int totalWinningPossibility = 8;
            String winnerString = "";
            int winTile1 = 0, winTile2 = 0, winTile3 = 0;

            for(int i = 0; i < totalWinningPossibility; i++)
            {
                switch(i)
                {
                    // 2 diagonal winning cases
                    case 0:
                        winnerString = board[0] + board[4] + board[8];
                        winTile1 = 0; 
                        winTile2 = 4; 
                        winTile3 = 8;
                        break;
                    case 1:
                        winnerString = board[2] + board[4] + board[6];
                        winTile1 = 2;
                        winTile2 = 4;
                        winTile3 = 6;
                        break;
                    // 3 horizontal winning cases
                    case 2:
                        winnerString = board[0] + board[1] + board[2];
                        winTile1 = 0;
                        winTile2 = 1;
                        winTile3 = 2;
                        break;
                    case 3:
                        winnerString = board[3] + board[4] + board[5];
                        winTile1 = 3;
                        winTile2 = 4;
                        winTile3 = 5;
                        break;
                    case 4:
                        winnerString = board[6] + board[7] + board[8];
                        winTile1 = 6;
                        winTile2 = 7;
                        winTile3 = 8;
                        break;
                   // 3 vertical winning cases
                    case 5:
                        winnerString = board[0] + board[3] + board[6];
                        winTile1 = 0;
                        winTile2 = 3;
                        winTile3 = 6;
                        break;
                    case 6:
                        winnerString = board[1] + board[4] + board[7];
                        winTile1 = 1;
                        winTile2 = 4;
                        winTile3 = 7;
                        break;
                    case 7:
                        winnerString = board[2] + board[5] + board[8];
                        winTile1 = 2;
                        winTile2 = 5;
                        winTile3 = 8;
                        break;
                }
                if(winnerString == "XXX") 
                {
                    WinnerColor(winTile1);
                    WinnerColor(winTile2);
                    WinnerColor(winTile3);
                    MessageBox.Show("X won!", "WOOHOO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Restart();
                }
                else if(winnerString == "OOO")
                {
                    WinnerColor(winTile1);
                    WinnerColor(winTile2);
                    WinnerColor(winTile3);
                    MessageBox.Show("O won!", "WOOHOO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Restart();
                }
                CheckTie();
            }
        }

        private void grid1_Click(object sender, EventArgs e)
        {
            currentTurn++;
            board[0] = playerSymbol(currentTurn);
            grid1.Text = board[0];
            CheckWinner(); 
        }

        private void grid2_Click(object sender, EventArgs e)
        {
            currentTurn++;
            board[1] = playerSymbol(currentTurn);
            grid2.Text = board[1];
            CheckWinner();
        }

        private void grid3_Click(object sender, EventArgs e)
        {
            currentTurn++;
            board[2] = playerSymbol(currentTurn);
            grid3.Text = board[2];
            CheckWinner();
        }

        private void grid4_Click(object sender, EventArgs e)
        {
            currentTurn++;
            board[3] = playerSymbol(currentTurn);
            grid4.Text = board[3];
            CheckWinner();
        }

        private void grid5_Click(object sender, EventArgs e)
        {
            currentTurn++;
            board[4] = playerSymbol(currentTurn);
            grid5.Text = board[4];
            CheckWinner();
        }

        private void grid6_Click(object sender, EventArgs e)
        {
            currentTurn++;
            board[5] = playerSymbol(currentTurn);
            grid6.Text = board[5];
            CheckWinner();
        }

        private void grid7_Click(object sender, EventArgs e)
        {
            currentTurn++;
            board[6] = playerSymbol(currentTurn);
            grid7.Text = board[6];
            CheckWinner();
        }

        private void grid8_Click(object sender, EventArgs e)
        {
            currentTurn++;
            board[7] = playerSymbol(currentTurn);
            grid8.Text = board[7];
            CheckWinner();
        }

        private void grid9_Click(object sender, EventArgs e)
        {
            currentTurn++;
            board[8] = playerSymbol(currentTurn);
            grid9.Text = board[8];
            CheckWinner();
        }
    }
}
