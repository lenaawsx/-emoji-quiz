namespace EmojiQuiz;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        comboBox1.Items.Add("Все");
        comboBox1.Items.AddRange(Db.GetCategories().ToArray());
        comboBox1.SelectedIndex = 0;
    }

    private void buttonPlay_Click(object sender, EventArgs e)
    {
        GameForm game = new GameForm(comboBox1.Text);
        game.Show();
    } 

    private void buttonAdmin_Click(object sender, EventArgs e)
    {
        new AdminForm().ShowDialog(); 
    }
}