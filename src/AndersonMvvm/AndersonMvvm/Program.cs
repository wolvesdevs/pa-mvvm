using AndersonMvvm.Exceptions;
using AndersonMvvm.Views;

namespace AndersonMvvm;

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
        Application.ThreadException += (sender, e) =>
        {
            var exception = e.Exception as ExceptionBase;

            if (exception != null)
            {
                if (exception.MessageKind == MessageKind.Information)
                {
                    MessageBox.Show(exception.Message, "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (exception.MessageKind == MessageKind.Warning)
                {
                    MessageBox.Show(exception.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (exception.MessageKind == MessageKind.Error)
                {
                    MessageBox.Show(exception.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show(exception.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        };

        ApplicationConfiguration.Initialize();
        Application.Run(new MainView());
    }
}
