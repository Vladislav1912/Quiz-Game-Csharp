using Quiz_Project_for_Uni.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Quiz_Project_for_Uni
{
    public partial class QuizFormat : Form
    {
        private List<Quiz> quizes;
        private int currentQuestionIndex = 0;
        private int score = 0;

        public QuizFormat()
        {
            InitializeComponent();
        }

        private void QuizFormat_Load(object sender, EventArgs e)
        {
            LoadQuestions();
            DisplayCurrentQuestion();
        }

        private void LoadQuestions()
        {
            using (var data = new AppDbContext())
            {
                quizes = data.Quizes.ToList();
            }
        }

        private void DisplayCurrentQuestion()
        {
            if (quizes == null || quizes.Count == 0)
            {
                MessageBox.Show("No questions found.");
                return;
            }

            if (currentQuestionIndex >= quizes.Count)
            {
                DialogResult result = MessageBox.Show(
                    $"Quiz complete! Your score: {score} / {quizes.Count}\n\nClick OK to try again!.",
                    "Quiz Finished",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    this.Hide(); 
                    LogIn login = new LogIn(); 
                    login.Show();
                }

                return;
            }

            var currentQuiz = quizes[currentQuestionIndex];
            var answers = currentQuiz.AnswersList;

            questionNum.Text = "Въпрос: ";
            QuizQuestion.Text = $"Question {currentQuestionIndex + 1}";
            QuizQuestion.Text = currentQuiz.Question;


            radioButton1.Text = answers.Count > 0 ? answers[0] : "";
            radioButton2.Text = answers.Count > 1 ? answers[1] : "";
            radioButton3.Text = answers.Count > 2 ? answers[2] : "";
            radioButton4.Text = answers.Count > 3 ? answers[3] : "";


            radioButton1.Visible = answers.Count > 0;
            radioButton2.Visible = answers.Count > 1;
            radioButton3.Visible = answers.Count > 2;
            radioButton4.Visible = answers.Count > 3;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            var currentQuiz = quizes[currentQuestionIndex];
            int selectedIndex = GetSelectedIndex();

            if (selectedIndex == currentQuiz.CorrectAnswerIndex)
            {
                score++;
            }

            currentQuestionIndex++;
            DisplayCurrentQuestion();
        }

        private int GetSelectedIndex()
        {
            if (radioButton1.Checked) return 0;
            if (radioButton2.Checked) return 1;
            if (radioButton3.Checked) return 2;
            if (radioButton4.Checked) return 3;
            return -1;
        }

        private void QuizFormat_Load_1(object sender, EventArgs e)
        {
            LoadQuestions();
            DisplayCurrentQuestion();
        }

       
    }
}
