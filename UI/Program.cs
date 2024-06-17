namespace UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm form = new LoginForm();
            form.FormClosed += (s, args) =>
            {
                if (Application.OpenForms.Count == 0)
                {
                    Application.ExitThread();
                }
            }; 

            Application.Run(form);
        }
    }
}