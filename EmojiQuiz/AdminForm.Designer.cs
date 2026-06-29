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
        SuspendLayout();
        // 
        // textEmoji
        // 
        textEmoji.Location = new System.Drawing.Point(123, 44);
        textEmoji.Name = "textEmoji";
        textEmoji.Size = new System.Drawing.Size(160, 27);
        textEmoji.TabIndex = 0;
        // 
        // textAnswer
        // 
        textAnswer.Location = new System.Drawing.Point(123, 96);
        textAnswer.Name = "textAnswer";
        textAnswer.Size = new System.Drawing.Size(159, 27);
        textAnswer.TabIndex = 1;
        // 
        // textCategory
        // 
        textCategory.Location = new System.Drawing.Point(123, 152);
        textCategory.Name = "textCategory";
        textCategory.Size = new System.Drawing.Size(159, 27);
        textCategory.TabIndex = 2;
        // 
        // buttonAdd
        // 
        buttonAdd.Location = new System.Drawing.Point(217, 262);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new System.Drawing.Size(186, 49);
        buttonAdd.TabIndex = 3;
        buttonAdd.Text = "Добавить";
        buttonAdd.UseVisualStyleBackColor = true;
        // 
        // AdminForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(buttonAdd);
        Controls.Add(textCategory);
        Controls.Add(textAnswer);
        Controls.Add(textEmoji);
        Text = "AdminForm";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button buttonAdd;

    private System.Windows.Forms.TextBox textCategory;

    private System.Windows.Forms.TextBox textAnswer;

    private System.Windows.Forms.TextBox textEmoji;

    #endregion
}