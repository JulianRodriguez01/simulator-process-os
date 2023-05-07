using ProyectProcess.models;

namespace ProyectProcess
{
    internal static class Run
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}