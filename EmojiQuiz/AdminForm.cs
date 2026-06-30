namespace EmojiQuiz;

public partial class AdminForm : Form
{
    public AdminForm()
    {
        InitializeComponent();
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        string emoji  = textEmoji.Text.Trim();    // Trim убирает пробелы по краям
        string answer = textAnswer.Text.Trim();
        string cat    = textCategory.Text.Trim();

        if (emoji == "" || answer == "")
        {
            MessageBox.Show("Заполните эмодзи и ответ.");
            return;
        }
        if (Db.Exists(answer))
        {
            MessageBox.Show("Такой фильм уже есть.");
            return;
        }

        Db.Add(emoji, answer, cat);
        MessageBox.Show("Добавлено.");
        textEmoji.Clear();
        textAnswer.Clear();
        textCategory.Clear();
    }
}