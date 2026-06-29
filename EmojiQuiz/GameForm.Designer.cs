using System.ComponentModel;

namespace EmojiQuiz;

partial class GameForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        labelEmoji = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        labelScore = new System.Windows.Forms.Label();
        labelResult = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // labelEmoji
        // 
        labelEmoji.Font = new System.Drawing.Font("Segoe UI Emoji", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        labelEmoji.Location = new System.Drawing.Point(264, 98);
        labelEmoji.Name = "labelEmoji";
        labelEmoji.Size = new System.Drawing.Size(310, 63);
        labelEmoji.TabIndex = 0;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(60, 261);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(139, 52);
        button1.TabIndex = 1;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(249, 261);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(146, 51);
        button2.TabIndex = 2;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(436, 261);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(144, 51);
        button3.TabIndex = 3;
        button3.Text = "button3";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.Location = new System.Drawing.Point(626, 261);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(142, 50);
        button4.TabIndex = 4;
        button4.Text = "button4";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // labelScore
        // 
        labelScore.Location = new System.Drawing.Point(72, 361);
        labelScore.Name = "labelScore";
        labelScore.Size = new System.Drawing.Size(135, 27);
        labelScore.TabIndex = 5;
        labelScore.Text = "Счёт: 0";
        // 
        // labelResult
        // 
        labelResult.Location = new System.Drawing.Point(509, 366);
        labelResult.Name = "labelResult";
        labelResult.Size = new System.Drawing.Size(168, 32);
        labelResult.TabIndex = 6;
        // 
        // GameForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(labelResult);
        Controls.Add(labelScore);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(labelEmoji);
        Text = "GameForm";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label labelResult;

    private System.Windows.Forms.Label labelScore;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;

    private System.Windows.Forms.Label labelEmoji;

    #endregion
}