using System;
using System.Windows.Forms;

namespace Notepad_C
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length == 0)
            {
                Application.Run(new Main());
            }
            else
            {
                Application.Run(new Main(args));
            }

        }
    }
}