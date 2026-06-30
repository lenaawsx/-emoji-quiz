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
        components = new System.ComponentModel.Container();
        labelEmoji = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        labelScore = new System.Windows.Forms.Label();
        labelResult = new System.Windows.Forms.Label();
        timer1 = new System.Windows.Forms.Timer(components);
        labelTime = new System.Windows.Forms.Label();
        labelStatus = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // labelEmoji
        // 
        labelEmoji.Font = new System.Drawing.Font("Segoe UI Emoji", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        labelEmoji.Location = new System.Drawing.Point(195, 45);
        labelEmoji.Name = "labelEmoji";
        labelEmoji.Size = new System.Drawing.Size(579, 171);
        labelEmoji.TabIndex = 0;
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.Plum;
        button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        button1.ForeColor = System.Drawing.Color.Purple;
        button1.Location = new System.Drawing.Point(60, 261);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(167, 68);
        button1.TabIndex = 1;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.BackColor = System.Drawing.Color.Plum;
        button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        button2.ForeColor = System.Drawing.Color.Purple;
        button2.Location = new System.Drawing.Point(249, 261);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(163, 68);
        button2.TabIndex = 2;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.BackColor = System.Drawing.Color.Plum;
        button3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        button3.ForeColor = System.Drawing.Color.Purple;
        button3.Location = new System.Drawing.Point(436, 261);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(166, 68);
        button3.TabIndex = 3;
        button3.Text = "button3";
        button3.UseVisualStyleBackColor = false;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.BackColor = System.Drawing.Color.Plum;
        button4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        button4.ForeColor = System.Drawing.Color.Purple;
        button4.Location = new System.Drawing.Point(626, 261);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(162, 68);
        button4.TabIndex = 4;
        button4.Text = "button4";
        button4.UseVisualStyleBackColor = false;
        button4.Click += button4_Click;
        // 
        // labelScore
        // 
        labelScore.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        labelScore.ForeColor = System.Drawing.Color.Purple;
        labelScore.Location = new System.Drawing.Point(72, 361);
        labelScore.Name = "labelScore";
        labelScore.Size = new System.Drawing.Size(398, 44);
        labelScore.TabIndex = 5;
        labelScore.Text = "Счёт: 0";
        // 
        // labelResult
        // 
        labelResult.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        labelResult.ForeColor = System.Drawing.Color.Purple;
        labelResult.Location = new System.Drawing.Point(509, 366);
        labelResult.Name = "labelResult";
        labelResult.Size = new System.Drawing.Size(279, 75);
        labelResult.TabIndex = 6;
        // 
        // timer1
        // 
        timer1.Enabled = true;
        timer1.Interval = 1000;
        timer1.Tick += timer1_Tick;
        // 
        // labelTime
        // 
        labelTime.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        labelTime.ForeColor = System.Drawing.Color.Purple;
        labelTime.Location = new System.Drawing.Point(70, 392);
        labelTime.Name = "labelTime";
        labelTime.Size = new System.Drawing.Size(103, 30);
        labelTime.TabIndex = 7;
        // 
        // labelStatus
        // 
        labelStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        labelStatus.ForeColor = System.Drawing.Color.Purple;
        labelStatus.Location = new System.Drawing.Point(347, 216);
        labelStatus.Name = "labelStatus";
        labelStatus.Size = new System.Drawing.Size(148, 28);
        labelStatus.TabIndex = 8;
        labelStatus.Text = "\r\n";
        // 
        // GameForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Thistle;
        ClientSize = new System.Drawing.Size(847, 484);
        Controls.Add(labelStatus);
        Controls.Add(labelTime);
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

    private System.Windows.Forms.Label labelStatus;

    private System.Windows.Forms.Label labelTime;

    private System.Windows.Forms.Timer timer1;

    private System.Windows.Forms.Label labelResult;

    private System.Windows.Forms.Label labelScore;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;

    private System.Windows.Forms.Label labelEmoji;

    #endregion
}