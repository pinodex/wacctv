using System;
using System.Threading;
using System.Windows.Forms;

namespace WACCTV
{
    static class Program
    {
        static Mutex mutex = new Mutex(false, "WACCTV-RAPH9999");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!mutex.WaitOne(TimeSpan.FromSeconds(2), false))
            {
                MessageBox.Show("WACCTV is already running.");
                return;
            }

            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Main());
            }
            finally
            {
                mutex.ReleaseMutex();
            }
        }
    }
}
