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
        public TicTacToeApplicationWindow()
        {
            InitializeComponent();
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
            if (sender.Text == "Select")
            {
                sender.Text = currentPlayer;
                sender.Refresh();
                ChangePlayers();
            }
        }

        private void TopLeft_Click(object sender, EventArgs e)
        {
            MarkField(TopLeft);
        }

        private void TopCenter_Click(object sender, EventArgs e)
        {
            MarkField(TopCenter);
        }

        private void TopRight_Click(object sender, EventArgs e)
        {
            MarkField(TopRight);
        }

        private void MiddleLeft_Click(object sender, EventArgs e)
        {
            MarkField(MiddleLeft);
        }

        private void MiddleCenter_Click(object sender, EventArgs e)
        {
            MarkField(MiddleCenter);
        }

        private void MiddleRight_Click(object sender, EventArgs e)
        {
            MarkField(MiddleRight);
        }

        private void BottomLeft_Click(object sender, EventArgs e)
        {
            MarkField(BottomLeft);
        }

        private void BottomCenter_Click(object sender, EventArgs e)
        {
            MarkField(BottomCenter);
        }

        private void BottomRight_Click(object sender, EventArgs e)
        {
            MarkField(BottomRight);
        }
    }
}