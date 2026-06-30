namespace EmojiQuiz;

public partial class GameForm : Form
{
    int timeLeft = 15;
    string currentCategory = "Все";
    bool isTwoPlayerMode = false;
    public GameForm()
    {
        InitializeComponent();
        timer1.Interval = 1000;
        timer1.Tick += timer1_Tick;
        NextQuestion();
        
    }
    public GameForm(string category, bool isTwoPlayerMode)
    {
        InitializeComponent();
        currentCategory = category; 
        this.isTwoPlayerMode = isTwoPlayerMode;
        if (!isTwoPlayerMode)
        {
            labelStatus.Visible = false;
        }

        NextQuestion();
    }
   
    static readonly Random rng = new();
    Question? current;   // знак вопроса: пока вопрос не выбран, тут может быть «ничего» (null)
    int score1 = 0;
    int score2 = 0;
    int currentPlayer = 1;
    int questionsAnswered = 0;
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
        if (current == null) return;

        if (chosen == current.Answer)
        {
            labelResult.Text = "Верно!";
            if (isTwoPlayerMode)
            {
                if (currentPlayer == 1) score1++;
                else score2++;
            }
            else
            {
                score1++;
            }
        }
        else
        {
            labelResult.Text = "Ошибка, это " + current.Answer;
        }

        if (isTwoPlayerMode)
        {
            labelScore.Text = $"Счёт: Игрок 1 - {score1}, Игрок 2 - {score2}";
            // Переключаем игрока ТОЛЬКО ПОСЛЕ ответа
            currentPlayer = (currentPlayer == 1) ? 2 : 1;
            labelStatus.Text = "Ход игрока: " + currentPlayer;
        }
        else
        {
            labelScore.Text = "Счёт: " + score1;
        }

        questionsAnswered++;
        if (questionsAnswered >= 10) 
        { 
            ShowResult(); 
            return; 
        }
        NextQuestion();
    }
    void ShowResult()
    {
        timer1.Stop();
        if (isTwoPlayerMode)
        {
            MessageBox.Show($"Игра окончена!\n\nИгрок 1: {score1} очков\nИгрок 2: {score2} очков", "Результаты");
        }
        else
        {
            double percent = (double)score1 / questionsAnswered * 100;
            MessageBox.Show($"Игра окончена!\n\nВерных ответов: {score1} из {questionsAnswered}\nПроцент: {percent:F1}%", "Результаты");
        }
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
            if (isTwoPlayerMode)
            {
                currentPlayer = (currentPlayer == 1) ? 2 : 1;
                labelStatus.Text = "Ход игрока: " + currentPlayer;
            }
            NextQuestion(); 
        }
    }
}