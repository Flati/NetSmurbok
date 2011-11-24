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
    public partial class PlayAgainForm : Form
    {
        public PlayAgainForm()
        {
            InitializeComponent();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            Global.PLAY_AGAIN = true;
            Close();
        }

        private void No_Click(object sender, EventArgs e)
        {
            Global.PLAY_AGAIN = false;
            Close();
        }
    }
}
