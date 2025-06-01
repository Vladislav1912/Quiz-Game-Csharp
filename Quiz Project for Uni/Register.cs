using Quiz_Project_for_Uni.Data;

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
