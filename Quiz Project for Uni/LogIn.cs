using Quiz_Project_for_Uni.Data;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Quiz_Project_for_Uni
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LogInUsername.Text == "" || LogInEmail.Text == "" || LogInPassword.Text == "")
            {
                MessageBox.Show("Enter text in the text boxes!");
                return;
            }

            
            if (LogInEmail.Text == "vladko@gmail.com" && LogInPassword.Text == "vladikukata" && LogInUsername.Text == "VladkoPiratko")
            {
                MessageBox.Show("Admin login successful!");
                this.Hide();
                AddQuiz adminForm = new AddQuiz();
                adminForm.Show();
                return;
            }

            
            using (var context = new AppDbContext())
            {
                var user = context.Persons.FirstOrDefault(p => p.Email == LogInEmail.Text);

                if (user == null)
                {
                    MessageBox.Show("User not found!");
                    return;
                }

                if (!VerifyPassHash(LogInPassword.Text, user.PasswordHash, user.PasswordSalt))
                {
                    MessageBox.Show("Invalid password!");
                    return;
                }

                this.Hide();
                AddQuiz AddQuizForm = new AddQuiz();
                AddQuizForm.Show();
                MessageBox.Show("Success login!");
            }
        }

        private bool VerifyPassHash(string pass, byte[] passHash, byte[] passSalt)
        {
            using (var hmac = new HMACSHA512(passSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(pass));
                return computedHash.SequenceEqual(passHash);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 RegisterForm = new Form1();
            RegisterForm.Show();
        }
    }
}
