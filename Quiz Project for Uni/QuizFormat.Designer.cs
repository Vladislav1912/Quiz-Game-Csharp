namespace Quiz_Project_for_Uni
{
    partial class QuizFormat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            QuizQuestion = new Label();
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            BtnNext = new Button();
            ScoreLabel = new Label();
            questionNum = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // QuizQuestion
            // 
            QuizQuestion.AutoSize = true;
            QuizQuestion.Location = new Point(169, 26);
            QuizQuestion.Name = "QuizQuestion";
            QuizQuestion.Size = new Size(38, 15);
            QuizQuestion.TabIndex = 0;
            QuizQuestion.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(45, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 231);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Отговори:";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(20, 160);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(94, 19);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(20, 123);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(20, 83);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(20, 40);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // BtnNext
            // 
            BtnNext.Location = new Point(267, 307);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(75, 23);
            BtnNext.TabIndex = 6;
            BtnNext.Text = "Next";
            BtnNext.UseVisualStyleBackColor = true;
            BtnNext.Click += BtnNext_Click;
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.Location = new Point(101, 311);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(32, 15);
            ScoreLabel.TabIndex = 7;
            ScoreLabel.Text = "label";
            // 
            // questionNum
            // 
            questionNum.AutoSize = true;
            questionNum.Location = new Point(74, 26);
            questionNum.Name = "questionNum";
            questionNum.Size = new Size(38, 15);
            questionNum.TabIndex = 8;
            questionNum.Text = "label1";
            // 
            // QuizFormat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 342);
            Controls.Add(questionNum);
            Controls.Add(QuizQuestion);
            Controls.Add(ScoreLabel);
            Controls.Add(BtnNext);
            Controls.Add(groupBox1);
            Name = "QuizFormat";
            Text = "Quiz";
            Load += QuizFormat_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label QuizQuestion;
        private GroupBox groupBox1;
        private Button BtnNext;
        private Label ScoreLabel;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label questionNum;
    }
}