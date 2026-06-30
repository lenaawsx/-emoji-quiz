namespace EmojiQuiz;

public partial class GameForm : Form
{
    int timeLeft = 15;
    string currentCategory = "Все";
    public void SetCategory(string category)
    
    {
        currentCategory = category;
        NextQuestion();
    }
    public GameForm()
    {
        InitializeComponent();
        timer1.Interval = 1000;
        timer1.Tick += timer1_Tick;
        NextQuestion();
        
    }
    public GameForm(string category)
    {
        InitializeComponent();
        currentCategory = category;
        NextQuestion();
    }
   
    static readonly Random rng = new();
    Question? current;   // знак вопроса: пока вопрос не выбран, тут может быть «ничего» (null)
    int score = 0;
    int totalQuestions = 0; 

    void NextQuestion()
    {
        timeLeft = 15;
        timer1.Start();
        labelTime.Text = "Время: " + timeLeft;
        current = Db.GetRandom(currentCategory);
        if (current == null) { labelEmoji.Text = "База пуста"; return; }

        labelEmoji.Text = current.Emoji;

        // один правильный плюс три неправильных, затем перемешать
        var options = Db.GetWrongAnswers(current.Answer, 3);
        options.Add(current.Answer);
        Shuffle(options);

        // Сколько вариантов нашлось, столько кнопок и показываем.
        // Если в базе меньше четырёх разных ответов, лишние кнопки прячем,
        // иначе обращение к options[3] выбросит ошибку и программа упадёт.
        var buttons = new[] { button1, button2, button3, button4 };
        for (int i = 0; i < buttons.Length; i++)
        {
            if (i < options.Count)
            {
                buttons[i].Text = options[i];
                buttons[i].Visible = true;
            }
            else
            {
                buttons[i].Visible = false;
            }
        }
    }


    void CheckAnswer(string chosen)
    {
        timer1.Stop();
        totalQuestions++;
        if (current == null) return;   // вопроса нет (база пустая) — ничего не проверяем

        if (chosen == current.Answer)
        {
            score++;
            labelResult.Text = "Верно";
        }
        else
        {
            labelResult.Text = "Неверно, это " + current.Answer;
        }
        labelScore.Text = "Счёт: " + score;
        if (totalQuestions >= 10) // Например, игра до 10 вопросов
        {
            ShowResult();
            return;
        }
        NextQuestion();
    }
    void ShowResult()
    {
        double percent = (double)score / totalQuestions * 100;
        MessageBox.Show($"Игра окончена!\n\nВерных ответов: {score} из {totalQuestions}\nПроцент: {percent:F1}%", 
            "Результаты");
        this.Close(); 
    }
    void Shuffle(List<string> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = rng.Next(i + 1);
            (list[i], list[j]) = (list[j], list[i]);   // меняем местами два элемента
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        CheckAnswer(button1.Text);
    }

    private void button2_Click(object sender, EventArgs e)
    {
        CheckAnswer(button2.Text);
    }

    private void button3_Click(object sender, EventArgs e)
    {
        CheckAnswer(button3.Text);
    }

    private void button4_Click(object sender, EventArgs e)
    {
        CheckAnswer(button4.Text);
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        timeLeft--;
        labelTime.Text = "Время: " + timeLeft;

        if (timeLeft <= 0)
        {
            timer1.Stop();
            labelResult.Text = "Время вышло!";
            NextQuestion(); 
        }
    }
}