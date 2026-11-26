namespace ProyectoSimuladorLaboratorio_E3_2027_1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormsLog());
        }
    }
}