using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TicTacToe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (Global.PLAY_AGAIN)
            {
                Application.Run(new TicTacToeApplicationWindow());
                Application.Run(new StatisticsForm());
                Application.Run(new PlayAgainForm());
            }
        }
    }
}
