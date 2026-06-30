namespace EmojiQuiz;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnSinglePlayer = new System.Windows.Forms.Button();
        buttonAdmin = new System.Windows.Forms.Button();
        comboBox1 = new System.Windows.Forms.ComboBox();
        btnTwoPlayer = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // btnSinglePlayer
        // 
        btnSinglePlayer.Location = new System.Drawing.Point(297, 91);
        btnSinglePlayer.Name = "btnSinglePlayer";
        btnSinglePlayer.Size = new System.Drawing.Size(213, 74);
        btnSinglePlayer.TabIndex = 0;
        btnSinglePlayer.Text = "Игра на одного ";
        btnSinglePlayer.UseVisualStyleBackColor = true;
        btnSinglePlayer.Click += btnSinglePlayer_Click;
        // 
        // buttonAdmin
        // 
        buttonAdmin.Location = new System.Drawing.Point(305, 277);
        buttonAdmin.Name = "buttonAdmin";
        buttonAdmin.Size = new System.Drawing.Size(205, 66);
        buttonAdmin.TabIndex = 1;
        buttonAdmin.Text = "Администратор";
        buttonAdmin.UseVisualStyleBackColor = true;
        buttonAdmin.Click += buttonAdmin_Click;
        // 
        // comboBox1
        // 
        comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new System.Drawing.Point(313, 365);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(197, 28);
        comboBox1.TabIndex = 2;
        // 
        // btnTwoPlayer
        // 
        btnTwoPlayer.Location = new System.Drawing.Point(297, 188);
        btnTwoPlayer.Name = "btnTwoPlayer";
        btnTwoPlayer.Size = new System.Drawing.Size(212, 50);
        btnTwoPlayer.TabIndex = 3;
        btnTwoPlayer.Text = "Игра на двоих";
        btnTwoPlayer.UseVisualStyleBackColor = true;
        btnTwoPlayer.Click += btnTwoPlayer_Click_1;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(btnTwoPlayer);
        Controls.Add(comboBox1);
        Controls.Add(buttonAdmin);
        Controls.Add(btnSinglePlayer);
        Text = "Form1";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnTwoPlayer;

    private System.Windows.Forms.ComboBox comboBox1;

    private System.Windows.Forms.Button btnSinglePlayer;
    private System.Windows.Forms.Button buttonAdmin;

    #endregion
}