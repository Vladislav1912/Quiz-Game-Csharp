using Quiz_Project_for_Uni.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Project_for_Uni
{
    public partial class QuizFormat : Form
    {
        public QuizFormat()
        {
            InitializeComponent();
        }


        private void QuizFormat_Load(object sender, EventArgs e)
        {

        }
        private void LoadQuestions()
        {
            using (var data = new AppDbContext)
            {
                var quizes = data.Quizes.ToList();

            }
        }
        private void DisplayCurrentQuestion()
        {
            if (currentQuestionIndex >= quizes.Count)
            {
                MessageBox.Show("Quiz finished! Your score is: ");
                return;
            } 
        
        }
}
