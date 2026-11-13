using System;
using System.Windows.Forms;

namespace Snake
{
    /// <summary>
    ///     Класс с точкой входа в программу
    /// </summary>
    internal sealed class Program
    {
        /// <summary>
        ///     Точка входа в программу
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}