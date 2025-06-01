using Microsoft.IdentityModel.Tokens;
using Quiz_Project_for_Uni.Data;
using Quiz_Project_for_Uni.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Quiz_Project_for_Uni
{
    public partial class AddQuiz : Form
    {
        public AddQuiz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(QuestionAdd.Text)
            || String.IsNullOrEmpty(AnswearA.Text)
            || String.IsNullOrEmpty(AnswearB.Text)
            || String.IsNullOrEmpty(AnswearC.Text)
            || String.IsNullOrEmpty(AnswearD.Text)
            || String.IsNullOrEmpty(ChosenIndex.Text))
            {
                MessageBox.Show("Enter Text in the textboxes!");
                return;
            }
            using (var context = new AppDbContext())
            {
                var answerList = new List<string>
                    {
            AnswearA.Text,
            AnswearB.Text,
            AnswearC.Text,
            AnswearD.Text
         };

                var newQuestion = new Quiz
                {
                    Question = QuestionAdd.Text,
                    CorrectAnswerIndex = int.Parse(ChosenIndex.Text) - 1,
                    AnswersList = answerList
                };

                context.Quizes.Add(newQuestion);
                context.SaveChanges(); 
                this.Hide();
                AdminTable admintable = new AdminTable();
                admintable.Show();
            }
            


        }
    }
}