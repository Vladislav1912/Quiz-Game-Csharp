namespace Quiz_Project_for_Uni
{
    partial class AddQuiz
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
            label1 = new Label();
            QuestionAdd = new TextBox();
            AnswearA = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            AnswearB = new TextBox();
            AnswearC = new TextBox();
            AnswearD = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ChosenIndex = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 32);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 5;
            label1.Text = "Въведете Въпрос";
            // 
            // QuestionAdd
            // 
            QuestionAdd.Location = new Point(196, 29);
            QuestionAdd.Name = "QuestionAdd";
            QuestionAdd.Size = new Size(209, 23);
            QuestionAdd.TabIndex = 10;
            // 
            // AnswearA
            // 
            AnswearA.Location = new Point(90, 76);
            AnswearA.Name = "AnswearA";
            AnswearA.Size = new Size(145, 23);
            AnswearA.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(135, 230);
            button1.Name = "button1";
            button1.Size = new Size(234, 23);
            button1.TabIndex = 12;
            button1.Text = "Добавете въпрос към викторината";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 79);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 13;
            label2.Text = "A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 79);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 14;
            label3.Text = "B";
            // 
            // AnswearB
            // 
            AnswearB.Location = new Point(302, 76);
            AnswearB.Name = "AnswearB";
            AnswearB.Size = new Size(156, 23);
            AnswearB.TabIndex = 15;
            // 
            // AnswearC
            // 
            AnswearC.Location = new Point(90, 121);
            AnswearC.Name = "AnswearC";
            AnswearC.Size = new Size(145, 23);
            AnswearC.TabIndex = 16;
            // 
            // AnswearD
            // 
            AnswearD.Location = new Point(302, 121);
            AnswearD.Name = "AnswearD";
            AnswearD.Size = new Size(156, 23);
            AnswearD.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 124);
            label4.Name = "label4";
            label4.Size = new Size(15, 15);
            label4.TabIndex = 18;
            label4.Text = "C";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(281, 124);
            label5.Name = "label5";
            label5.Size = new Size(15, 15);
            label5.TabIndex = 19;
            label5.Text = "D";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 182);
            label6.Name = "label6";
            label6.Size = new Size(209, 15);
            label6.TabIndex = 20;
            label6.Text = "Вкарайте индекса на верния отговор";
            // 
            // ChosenIndex
            // 
            ChosenIndex.Location = new Point(258, 182);
            ChosenIndex.Name = "ChosenIndex";
            ChosenIndex.Size = new Size(178, 23);
            ChosenIndex.TabIndex = 21;
            // 
            // AddQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 280);
            Controls.Add(ChosenIndex);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(AnswearD);
            Controls.Add(AnswearC);
            Controls.Add(AnswearB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(AnswearA);
            Controls.Add(QuestionAdd);
            Controls.Add(label1);
            Name = "AddQuiz";
            Text = "AddQuiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox QuestionAdd;
        private TextBox AnswearA;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox AnswearB;
        private TextBox AnswearC;
        private TextBox AnswearD;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox ChosenIndex;
    }
}