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
    

    private void buttonAdmin_Click(object sender, EventArgs e)
    {
        new AdminForm().ShowDialog(); 
    }

    private void btnSinglePlayer_Click(object sender, EventArgs e)
    {
        GameForm game = new GameForm(comboBox1.SelectedItem.ToString(), false);
        game.Show();
    }
    

    private void btnTwoPlayer_Click_1(object sender, EventArgs e)
    {
        GameForm game = new GameForm(comboBox1.SelectedItem.ToString(), true);
        game.Show();
    }
}