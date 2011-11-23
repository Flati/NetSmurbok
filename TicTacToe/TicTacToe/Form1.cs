using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToeApplicationWindow : Form
    {
        public static String player1 = "X";
        public static String player2 = "O";
        public String currentPlayer = player1;
        public static List<List<string>> matrix = new List<List<string>>();
        public TicTacToeApplicationWindow()
        {
            InitializeComponent();
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

        private void MarkMatrix(int x, int y)
        {
            matrix[x][y] = currentPlayer;
            ChangePlayers();
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