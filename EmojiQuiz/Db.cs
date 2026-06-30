namespace EmojiQuiz;
using Microsoft.EntityFrameworkCore;

static class Db
{
    // Создать базу и таблицу по описанию модели, если их ещё нет.
    public static void EnsureCreated()
    {
        using var ctx = new QuizContext();
        ctx.Database.EnsureCreated();
    }

    // Сколько вопросов в базе.
    public static int Count()
    {
        using var ctx = new QuizContext();
        return ctx.Questions.Count();
    }

    // Добавить вопрос. Используется и админкой, и заполнением из файла.
    public static void Add(string emoji, string answer, string category)
    {
        using var ctx = new QuizContext();
        ctx.Questions.Add(new Question { Emoji = emoji, Answer = answer, Category = category ?? "" });
        ctx.SaveChanges();   // без SaveChanges изменения не попадут в файл базы
    }

    // Случайный вопрос. EF.Functions.Random() превращается в SQL RANDOM().
    public static Question? GetRandom()
    {
        using var ctx = new QuizContext();
        return ctx.Questions
            .OrderBy(q => EF.Functions.Random())
            .FirstOrDefault();   // вернёт null, если база пустая
    }
    public static Question? GetRandom(string category)
    {
        using var ctx = new QuizContext();
        if (category == "Все") return GetRandom();
        return ctx.Questions
            .Where(q => q.Category == category)
            .OrderBy(q => EF.Functions.Random())
            .FirstOrDefault();
    }
    public static List<string> GetCategories()
    {
        using var ctx = new QuizContext();
        return ctx.Questions
            .Select(q => q.Category)
            .Distinct()
            .Where(c => !string.IsNullOrEmpty(c))
            .ToList();
    }

    // Несколько случайных НЕправильных ответов — для вариантов выбора.
    public static List<string> GetWrongAnswers(string correct, int count)
    {
        using var ctx = new QuizContext();
        return ctx.Questions
            .Where(q => q.Answer != correct)      // все ответы, кроме правильного
            .OrderBy(q => EF.Functions.Random())  // в случайном порядке
            .Select(q => q.Answer)                // берём только текст ответа
            .Take(count)                          // сколько просили
            .ToList();
    }

    // Заполнить базу из файла этапа 1. Запускается один раз, если база пустая.
    public static void SeedFromFile(string path)
    {
        if (Count() > 0) return;                  
        using var ctx = new QuizContext();
        foreach (var line in File.ReadLines(path).Skip(1))  
        {
            var p = line.Split('\t');            
            if (p.Length < 3) continue;         
            ctx.Questions.Add(new Question { Emoji = p[2], Answer = p[1], Category = p[3] });
        }
        ctx.SaveChanges();                     
    }
    public static bool Exists(string answer)
    {
        using (var db = new QuizContext())
        {
            return db.Questions.Any(q => q.Answer == answer);
        }
    }
}
