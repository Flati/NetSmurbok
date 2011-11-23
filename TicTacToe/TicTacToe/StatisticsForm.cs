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
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
            StatisticsMessage.Text = Global.winMessage;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
