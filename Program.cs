using System;
using System.Windows.Forms;

namespace SecurePNG
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 mainForm = new Form1();

            if (args.Length > 0)
            {
                mainForm.HandleDroppedFiles(args);
            }
            else
            {
                Application.Run(mainForm);
            }
        }
    }
}
