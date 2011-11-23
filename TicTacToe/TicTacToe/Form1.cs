using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using TicTacToe.code;

namespace TicTacToe
{
    public partial class TicTacToeApplicationWindow : Form
    {
        private Logic logic;
        public TicTacToeApplicationWindow()
        {
            InitializeComponent();
            logic = new Logic();
        }

        public void MarkField(Button field)
        {
            if (logic.currentPlayer == Logic.player1)
                field.Image = Image.FromFile("C:\\Users\\Flati\\Desktop\\trunk\\TicTacToe\\TicTacToe\\etc\\kross.png");
            else
                field.Image = Image.FromFile("C:\\Users\\Flati\\Desktop\\trunk\\TicTacToe\\TicTacToe\\etc\\hringur.png");
            field.Update();
        }

        private void MarkMatrix(int x, int y)
        {
            if (logic.MarkMatrix(x,y))
                Close();
        }

        private void TopLeft_Click(object sender, EventArgs e)
        {
            if (logic.isAvailable(0,0))
            {
                MarkField(TopLeft);
                MarkMatrix(0, 0);
            }
        }

        private void TopCenter_Click(object sender, EventArgs e)
        {
            if (logic.isAvailable(0,1))
            {
                MarkField(TopCenter);
                MarkMatrix(0, 1);
            }
        }

        private void TopRight_Click(object sender, EventArgs e)
        {
            if (logic.isAvailable(0,2))
            {
                MarkField(TopRight);
                MarkMatrix(0, 2);
            }
        }

        private void MiddleLeft_Click(object sender, EventArgs e)
        {
            if (logic.isAvailable(1,0))
            {
                MarkField(MiddleLeft);
                MarkMatrix(1, 0);
            }
        }

        private void MiddleCenter_Click(object sender, EventArgs e)
        {
            if (logic.isAvailable(1,1))
            {
                MarkField(MiddleCenter);
                MarkMatrix(1, 1);
            }
        }

        private void MiddleRight_Click(object sender, EventArgs e)
        {
            if (logic.isAvailable(1,2))
            {
                MarkField(MiddleRight);
                MarkMatrix(1, 2);
            }
        }

        private void BottomLeft_Click(object sender, EventArgs e)
        {
            if (logic.isAvailable(2,0))
            {
                MarkField(BottomLeft);
                MarkMatrix(2, 0);
            }
        }

        private void BottomCenter_Click(object sender, EventArgs e)
        {
            if (logic.isAvailable(2,1))
            {
                MarkField(BottomCenter);
                MarkMatrix(2, 1);
            }
        }

        private void BottomRight_Click(object sender, EventArgs e)
        {
            if (logic.isAvailable(2,2))
            {
                MarkField(BottomRight);
                MarkMatrix(2, 2);
            }
        }
    }
}