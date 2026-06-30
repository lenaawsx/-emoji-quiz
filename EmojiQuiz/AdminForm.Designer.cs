using System.ComponentModel;

namespace EmojiQuiz;

partial class AdminForm
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
        textEmoji = new System.Windows.Forms.TextBox();
        textAnswer = new System.Windows.Forms.TextBox();
        textCategory = new System.Windows.Forms.TextBox();
        buttonAdd = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // textEmoji
        // 
        textEmoji.Location = new System.Drawing.Point(284, 174);
        textEmoji.Name = "textEmoji";
        textEmoji.Size = new System.Drawing.Size(160, 27);
        textEmoji.TabIndex = 0;
        // 
        // textAnswer
        // 
        textAnswer.Location = new System.Drawing.Point(285, 228);
        textAnswer.Name = "textAnswer";
        textAnswer.Size = new System.Drawing.Size(159, 27);
        textAnswer.TabIndex = 1;
        // 
        // textCategory
        // 
        textCategory.Location = new System.Drawing.Point(285, 275);
        textCategory.Name = "textCategory";
        textCategory.Size = new System.Drawing.Size(159, 27);
        textCategory.TabIndex = 2;
        // 
        // buttonAdd
        // 
        buttonAdd.BackColor = System.Drawing.Color.Plum;
        buttonAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        buttonAdd.ForeColor = System.Drawing.Color.Purple;
        buttonAdd.Location = new System.Drawing.Point(274, 328);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new System.Drawing.Size(186, 56);
        buttonAdd.TabIndex = 3;
        buttonAdd.Text = "Добавить";
        buttonAdd.UseVisualStyleBackColor = false;
        buttonAdd.Click += buttonAdd_Click;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label1.ForeColor = System.Drawing.Color.Purple;
        label1.Location = new System.Drawing.Point(202, 112);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(477, 47);
        label1.TabIndex = 4;
        label1.Text = "ДОБАВИТЬ ВОПРОС";
        // 
        // label2
        // 
        label2.BackColor = System.Drawing.Color.Thistle;
        label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label2.ForeColor = System.Drawing.Color.Purple;
        label2.Location = new System.Drawing.Point(183, 174);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(95, 21);
        label2.TabIndex = 5;
        label2.Text = "Вопрос";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label3.ForeColor = System.Drawing.Color.Purple;
        label3.Location = new System.Drawing.Point(183, 228);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(76, 26);
        label3.TabIndex = 6;
        label3.Text = "Ответ";
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label4.ForeColor = System.Drawing.Color.Purple;
        label4.Location = new System.Drawing.Point(165, 275);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(94, 25);
        label4.TabIndex = 7;
        label4.Text = "Категория";
        // 
        // AdminForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Thistle;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(buttonAdd);
        Controls.Add(textCategory);
        Controls.Add(textAnswer);
        Controls.Add(textEmoji);
        Text = "AdminForm";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button buttonAdd;

    private System.Windows.Forms.TextBox textCategory;

    private System.Windows.Forms.TextBox textAnswer;

    private System.Windows.Forms.TextBox textEmoji;

    #endregion
}