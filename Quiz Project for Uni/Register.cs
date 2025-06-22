using Quiz_Project_for_Uni.Data;
using System.Text.RegularExpressions;

namespace Quiz_Project_for_Uni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (Username.Text == "" || Email.Text == "" || Password.Text == "" || ConfirmPassword.Text == "")
            {
                MessageBox.Show("Enter text in the textboxes!");
            }
            
            else
            {
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                string usernamePattern = @"^[a-zA-Z0-9_]{3,20}$";
                string passwordPattern = @"^(?=.*[A-Za-z])(?=.*\d).{6,}$";

                if (!Regex.IsMatch(Email.Text, emailPattern))
                {
                    MessageBox.Show("Invalid email format!");
                    return;
                }

                if (!Regex.IsMatch(Username.Text, usernamePattern))
                {
                    MessageBox.Show("Username must be 3-20 characters long and contain only letters, numbers, or underscores.");
                    return;
                }

                if (!Regex.IsMatch(Password.Text, passwordPattern))
                {
                    MessageBox.Show("Password must be at least 6 characters long and contain at least one letter and one number.");
                    return;
                }

                if (Password.Text != ConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords dont match!");
                    return;
                }

                CreatePasswordHash(Password.Text, out byte[] passwordHash, out byte[] passwordSalt);
                using (var context = new AppDbContext())
                {
                    var newPerson = new Person
                    {
                        Name = Username.Text,
                        Email = Email.Text,
                        PasswordHash = passwordHash,
                        PasswordSalt = passwordSalt
                    };

                    context.Persons.Add(newPerson);
                    context.SaveChanges();
                }
                this.Hide();
                LogIn login = new LogIn();
                login.Show();
                MessageBox.Show("Registration successful!");
            }
        }

        private void CreatePasswordHash(string pass, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(pass));
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LogIn loginForm = new LogIn();
            loginForm.Show();
        }

       
    }
}
