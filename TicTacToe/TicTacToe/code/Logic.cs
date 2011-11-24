using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using TicTacToe.data;

namespace TicTacToe.code
{
    class Logic
    {
        public string currentPlayer { get; set; }
        private static List<List<string>> matrix;
        private int moveCounter;

        DataReader dataReader;

        public Logic()
        {
            dataReader = new DataReader();
            moveCounter = 0;
            currentPlayer = Global.player1;
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

        public bool IsAvailable(int x, int y)
        {
            if (matrix[x][y] == "E")
                return true;
            return false;
        }

        public void ChangePlayers()
        {
            if (currentPlayer == Global.player1)
                currentPlayer = Global.player2;
            else
                currentPlayer = Global.player1;
        }

        public void WinScreen(String winner)
        {
            Global.winMessage = dataReader.Winning(winner);
        }

        public bool Tie()
        {
            if (moveCounter == 9)
                return true;
            return false;
        }

        public bool MarkMatrix(int x, int y)
        {
            matrix[x][y] = currentPlayer;
            moveCounter++;
            if (IsWon())
            {
                WinScreen(currentPlayer);
                return true;
            }
            if (Tie())
            {
                WinScreen("tie");
                return true;
            }
            ChangePlayers();
            return false;
        }

        private bool IsWon()
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
    }
}
