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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // btnSinglePlayer
        // 
        btnSinglePlayer.BackColor = System.Drawing.Color.Plum;
        btnSinglePlayer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        btnSinglePlayer.ForeColor = System.Drawing.Color.Purple;
        btnSinglePlayer.Location = new System.Drawing.Point(145, 251);
        btnSinglePlayer.Name = "btnSinglePlayer";
        btnSinglePlayer.Size = new System.Drawing.Size(213, 74);
        btnSinglePlayer.TabIndex = 0;
        btnSinglePlayer.Text = "Игра на одного ";
        btnSinglePlayer.UseVisualStyleBackColor = false;
        btnSinglePlayer.Click += btnSinglePlayer_Click;
        // 
        // buttonAdmin
        // 
        buttonAdmin.BackColor = System.Drawing.Color.Violet;
        buttonAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        buttonAdmin.ForeColor = System.Drawing.Color.Purple;
        buttonAdmin.Location = new System.Drawing.Point(284, 353);
        buttonAdmin.Name = "buttonAdmin";
        buttonAdmin.Size = new System.Drawing.Size(212, 70);
        buttonAdmin.TabIndex = 1;
        buttonAdmin.Text = "Администратор";
        buttonAdmin.UseVisualStyleBackColor = false;
        buttonAdmin.Click += buttonAdmin_Click;
        // 
        // comboBox1
        // 
        comboBox1.BackColor = System.Drawing.Color.Plum;
        comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new System.Drawing.Point(424, 201);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(211, 28);
        comboBox1.TabIndex = 2;
        // 
        // btnTwoPlayer
        // 
        btnTwoPlayer.BackColor = System.Drawing.Color.Plum;
        btnTwoPlayer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        btnTwoPlayer.ForeColor = System.Drawing.Color.Purple;
        btnTwoPlayer.Location = new System.Drawing.Point(424, 251);
        btnTwoPlayer.Name = "btnTwoPlayer";
        btnTwoPlayer.Size = new System.Drawing.Size(212, 74);
        btnTwoPlayer.TabIndex = 3;
        btnTwoPlayer.Text = "Игра на двоих";
        btnTwoPlayer.UseVisualStyleBackColor = false;
        btnTwoPlayer.Click += btnTwoPlayer_Click_1;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)204));
        label1.ForeColor = System.Drawing.Color.Purple;
        label1.Location = new System.Drawing.Point(95, 200);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(323, 35);
        label1.TabIndex = 4;
        label1.Text = "Выберите категорию фильмов";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 25.800001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label2.ForeColor = System.Drawing.Color.Purple;
        label2.Location = new System.Drawing.Point(37, 81);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(751, 77);
        label2.TabIndex = 5;
        label2.Text = "УГАДАЙ ФИЛЬМ ПО ЭМОДЗИ\r\n\r\n";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Thistle;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(btnTwoPlayer);
        Controls.Add(comboBox1);
        Controls.Add(buttonAdmin);
        Controls.Add(btnSinglePlayer);
        Text = "Form1";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button btnTwoPlayer;

    private System.Windows.Forms.ComboBox comboBox1;

    private System.Windows.Forms.Button btnSinglePlayer;
    private System.Windows.Forms.Button buttonAdmin;

    #endregion
}