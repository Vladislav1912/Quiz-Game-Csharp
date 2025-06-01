namespace Quiz_Project_for_Uni
{
    partial class AdminTable
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
            dataGridView1 = new DataGridView();
            Question = new DataGridViewTextBoxColumn();
            Answers = new DataGridViewTextBoxColumn();
            CorrectAnswerIndex = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Question, Answers, CorrectAnswerIndex });
            dataGridView1.Location = new Point(20, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(643, 162);
            dataGridView1.TabIndex = 0;
            // 
            // Question
            // 
            Question.FillWeight = 200F;
            Question.HeaderText = "Question";
            Question.Name = "Question";
            Question.Width = 200;
            // 
            // Answers
            // 
            Answers.FillWeight = 200F;
            Answers.HeaderText = "Answers";
            Answers.Name = "Answers";
            Answers.Width = 200;
            // 
            // CorrectAnswerIndex
            // 
            CorrectAnswerIndex.FillWeight = 200F;
            CorrectAnswerIndex.HeaderText = "CorrectAnswerIndex";
            CorrectAnswerIndex.Name = "CorrectAnswerIndex";
            CorrectAnswerIndex.Width = 200;
            // 
            // AdminTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 360);
            Controls.Add(dataGridView1);
            Name = "AdminTable";
            Text = "AdminTable";
            Load += AdminTable_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Question;
        private DataGridViewTextBoxColumn Answers;
        private DataGridViewTextBoxColumn CorrectAnswerIndex;
    }
}