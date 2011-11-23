using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TicTacToe
{
    public partial class TicTacToeApplicationWindow : Form
    {
        public static String player1 = "X";
        public static String player2 = "O";
        public String currentPlayer = player1;
        public static List<List<string>> matrix;
        int moveCounter = 0;
        public TicTacToeApplicationWindow()
        {
            InitializeComponent();
            matrix = new List<List<string>>();
            for (int i = 0; i < 3; i++)
            {
                matrix.Add(new List<string>());
                for (int j = 0; j < 3; j++)
                {
                    matrix[i].Add("E");
                }
            }
        }

        public bool isAvailable(Label field)
        {
            if (field.Text == "Select")
                return true;
            return false;
        }

        public void ChangePlayers()
        {
            if (currentPlayer == player1)
                currentPlayer = player2;
            else
                currentPlayer = player1;
        }

        public void MarkField(Label sender)
        {
            sender.Text = currentPlayer;
            sender.Refresh();
        }

        public void WinScreen(String winner)
        {
            int player1Win;
            int player2Win;
            int tieNumber;
            Global.winMessage = "";
            using (StreamReader sr = new StreamReader("ProgressLog.txt"))
            {
                player1Win = int.Parse(sr.ReadLine());
                player2Win = int.Parse(sr.ReadLine());
                tieNumber = int.Parse(sr.ReadLine());
            }
            using (StreamWriter sw = new StreamWriter("ProgressLog.txt"))
            {
                if (winner == player1)
                {
                    player1Win++;
                    Global.winMessage += "Player 1 won this game!";
                }
                else if (winner == player2)
                {
                    player2Win++;
                    Global.winMessage += "Player 2 won this game!";
                }
                else
                {
                    tieNumber++;
                    Global.winMessage += "The game resulted in a tie.";
                }
                Global.winMessage += "\n\nHistory:\nPlayer 1 won: " + player1Win;
                Global.winMessage += "\nPlayer 2 won: " + player2Win;
                Global.winMessage += "\nTies: " + tieNumber;
                sw.WriteLine(player1Win);
                sw.WriteLine(player2Win);
                sw.WriteLine(tieNumber);
            }
            Close();
        }

        public bool Tie()
        {
            if (moveCounter == 9)
                return true;
            return false;
        }

        private void MarkMatrix(int x, int y)
        {
            matrix[x][y] = currentPlayer;
            moveCounter++;
            if (Tie())
                WinScreen("tie");
            if (isWon())
                WinScreen(currentPlayer);
            ChangePlayers();
        }

        private bool isWon()
        {
            for (int i = 0; i < 3; i++)
            {
                if (matrix[i][0] == matrix[i][1] && matrix[i][0] == matrix[i][2])
                {
                    if (matrix[i][0] != "E")
                        return true;
                }
                else if (matrix[0][i] == matrix[1][i] && matrix[0][i] == matrix[2][i])
                {
                    if (matrix[0][i] != "E")
                        return true;
                }
            }
            if (matrix[0][0] == matrix[1][1] && matrix[0][0] == matrix[2][2])
            {
                if (matrix[0][0] != "E")
                    return true;
            }
            else if (matrix[2][0] == matrix[1][1] && matrix[2][0] == matrix[0][2])
            {
                if (matrix[1][1] != "E")
                    return true;
            }
            return false;
        }

        private void TopLeft_Click(object sender, EventArgs e)
        {
            if (isAvailable(TopLeft))
            {
                MarkField(TopLeft);
                MarkMatrix(0, 0);
            }
        }

        private void TopCenter_Click(object sender, EventArgs e)
        {
            if (isAvailable(TopCenter))
            {
                MarkField(TopCenter);
                MarkMatrix(0, 1);
            }
        }

        private void TopRight_Click(object sender, EventArgs e)
        {
            if (isAvailable(TopRight))
            {
                MarkField(TopRight);
                MarkMatrix(0, 2);
            }
        }

        private void MiddleLeft_Click(object sender, EventArgs e)
        {
            if (isAvailable(MiddleLeft))
            {
                MarkField(MiddleLeft);
                MarkMatrix(1, 0);
            }
        }

        private void MiddleCenter_Click(object sender, EventArgs e)
        {
            if (isAvailable(MiddleCenter))
            {
                MarkField(MiddleCenter);
                MarkMatrix(1, 1);
            }
        }

        private void MiddleRight_Click(object sender, EventArgs e)
        {
            if (isAvailable(MiddleRight))
            {
                MarkField(MiddleRight);
                MarkMatrix(1, 2);
            }
        }

        private void BottomLeft_Click(object sender, EventArgs e)
        {
            if (isAvailable(BottomLeft))
            {
                MarkField(BottomLeft);
                MarkMatrix(2, 0);
            }
        }

        private void BottomCenter_Click(object sender, EventArgs e)
        {
            if (isAvailable(BottomCenter))
            {
                MarkField(BottomCenter);
                MarkMatrix(2, 1);
            }
        }

        private void BottomRight_Click(object sender, EventArgs e)
        {
            if (isAvailable(BottomRight))
            {
                MarkField(BottomRight);
                MarkMatrix(2, 2);
            }
        }
    }
}