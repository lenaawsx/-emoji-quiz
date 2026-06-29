namespace EmojiQuiz;

static class Program
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
        Db.EnsureCreated();
        Db.SeedFromFile("movies_ru_emoji.tsv");
        Application.Run(new MainForm());
    }
}