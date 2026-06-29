namespace EmojiQuiz;
using Microsoft.EntityFrameworkCore;

class QuizContext : DbContext
{
    // Таблица вопросов. Запись "=> Set<Question>()" — рекомендованный EF Core способ
    // объявить таблицу так, чтобы не было предупреждения про возможный null.
    public DbSet<Question> Questions => Set<Question>();

    // Говорим EF Core, какую базу использовать: файл quiz.db рядом с программой.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite("Data Source=quiz.db");
    }
}