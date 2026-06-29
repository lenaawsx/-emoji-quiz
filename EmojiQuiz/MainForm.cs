namespace EmojiQuiz;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void buttonPlay_Click(object sender, EventArgs e)
    {
        new GameForm().ShowDialog();
    }

    private void buttonAdmin_Click(object sender, EventArgs e)
    {
        new AdminForm().ShowDialog(); 
    }
}