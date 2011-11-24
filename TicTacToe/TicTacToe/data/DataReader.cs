using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using TicTacToe.code;

namespace TicTacToe.data
{
    class DataReader
    {
        public string Winning(string winner)
        {
            string path = "ProgressLog.txt";
            int player1Win;
            int player2Win;
            int tieNumber;
            string result = "";
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    player1Win = int.Parse(sr.ReadLine());
                    player2Win = int.Parse(sr.ReadLine());
                    tieNumber = int.Parse(sr.ReadLine());
                }
            }
            else
            {
                player1Win = 0;
                player2Win = 0;
                tieNumber = 0;
            }
            using (StreamWriter sw = new StreamWriter(path))
            {
                if (winner == Global.PLAYER1)
                {
                    player1Win++;
                    result += "Player 1 won this game!";
                }
                else if (winner == Global.PLAYER2)
                {
                    player2Win++;
                    result += "Player 2 won this game!";
                }
                else
                {
                    tieNumber++;
                    result += "The game resulted in a tie.";
                }
                result += "\n\nHistory:\nPlayer 1 won: " + player1Win;
                result += "\nPlayer 2 won: " + player2Win;
                result += "\nTies: " + tieNumber;
                sw.WriteLine(player1Win);
                sw.WriteLine(player2Win);
                sw.WriteLine(tieNumber);
            }
            return result;
        }
    }
}
