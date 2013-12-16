using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace RobotController
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
