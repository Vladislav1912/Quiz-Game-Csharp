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
            QuizAnswear4 = new Button();
            QuizAnswear1 = new Button();
            QuizAnswear2 = new Button();
            QuizAnswear3 = new Button();
            QuizQuestion = new Label();
            SuspendLayout();
            // 
            // QuizAnswear4
            // 
            QuizAnswear4.Location = new Point(388, 255);
            QuizAnswear4.Name = "QuizAnswear4";
            QuizAnswear4.Size = new Size(75, 23);
            QuizAnswear4.TabIndex = 4;
            QuizAnswear4.Text = "button4";
            QuizAnswear4.UseVisualStyleBackColor = true;
            // 
            // QuizAnswear1
            // 
            QuizAnswear1.Location = new Point(127, 150);
            QuizAnswear1.Name = "QuizAnswear1";
            QuizAnswear1.Size = new Size(75, 23);
            QuizAnswear1.TabIndex = 1;
            QuizAnswear1.Text = "button1";
            QuizAnswear1.UseVisualStyleBackColor = true;
            // 
            // QuizAnswear2
            // 
            QuizAnswear2.Location = new Point(388, 150);
            QuizAnswear2.Name = "QuizAnswear2";
            QuizAnswear2.Size = new Size(75, 23);
            QuizAnswear2.TabIndex = 2;
            QuizAnswear2.Text = "button2";
            QuizAnswear2.UseVisualStyleBackColor = true;
            // 
            // QuizAnswear3
            // 
            QuizAnswear3.Location = new Point(127, 255);
            QuizAnswear3.Name = "QuizAnswear3";
            QuizAnswear3.Size = new Size(75, 23);
            QuizAnswear3.TabIndex = 3;
            QuizAnswear3.Text = "button3";
            QuizAnswear3.UseVisualStyleBackColor = true;
            // 
            // QuizQuestion
            // 
            QuizQuestion.AutoSize = true;
            QuizQuestion.Location = new Point(290, 79);
            QuizQuestion.Name = "QuizQuestion";
            QuizQuestion.Size = new Size(38, 15);
            QuizQuestion.TabIndex = 0;
            QuizQuestion.Text = "label1";
            // 
            // QuizFormat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 379);
            Controls.Add(QuizAnswear4);
            Controls.Add(QuizAnswear3);
            Controls.Add(QuizAnswear2);
            Controls.Add(QuizAnswear1);
            Controls.Add(QuizQuestion);
            Name = "QuizFormat";
            Text = "Quiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button QuizAnswear4;
        private Button QuizAnswear1;
        private Button QuizAnswear2;
        private Button QuizAnswear3;
        private Label QuizQuestion;
    }
}